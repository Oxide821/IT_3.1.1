using System;

namespace Signal_CSharp
{
    public struct Complex
    {
        public double Real { get; set; }
        public double Image { get; set; }
    };

    class Calculation
    {
        private double[] ampArray, freqArray, phaseArray;
        private int size, amount, element = 15, noise;
        private double signal_en, summ, noise_en, sumSquare, spectreEnergy, energyPercent;

        private double[] signal, signalNoise, gaussElement, noiseFinal;
        Random rand;

        Complex[] spectre, cleanSignal;

        public Calculation(double[] ampArray, double[] freqArray, double[] phaseArray, int[] dataArray)
        {
            this.ampArray = new double[3];
            this.ampArray = ampArray;

            this.freqArray = new double[3];
            this.freqArray = freqArray;

            this.phaseArray = new double[3];
            this.phaseArray = phaseArray;

            size = dataArray[0];
            amount = dataArray[1];
            noise = dataArray[2];
            energyPercent = dataArray[3];

            signal = new double[this.size];
            signalNoise = new double[this.size];
            gaussElement = new double[element];
            noiseFinal = new double[this.size];
            spectre = new Complex[this.size];
            cleanSignal = new Complex[this.size];
            rand = new Random();
        }

        //исходный график
        internal void CreateGraph()
        {
           //удалить и посмотреть
            for (int i = 0; i < size; i++)
            {
                signal[i] = 0;
            }
            //до сих
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    signal[j] += Function(ampArray[i], freqArray[i], j, phaseArray[i]);
                }
            }
        }

        //зашумлённый сигнал
        internal void AddNoise()
        {
            //чек зис хуйня
            for (int i = 0; i < element; i++)
            {
                gaussElement[i] = 0;
            }
            //от до сих
            //заполнение массива случайных коэффициентов
            for (int i = 0; i < size; i++)
            {
                signalNoise[i] = 0;
                for (int j = 0; j < element; j++)
                {
                    gaussElement[j] = GetRandom(-0.5, 0.5);
                    signalNoise[i] += gaussElement[j];
                }
                signalNoise[i] /= element;
            }
            //вычисление энергии сигнала
            for (int i = 0; i < size; i++)
            {
                signal_en += (signal[i] * signal[i]);
                summ += (signalNoise[i] * signalNoise[i]);
            }

            noise_en = noise * signal_en / 100; //энергия шума
            double alpha = Math.Sqrt(noise_en / summ);

            //прибавляем шум к основному сигналу и получаем итоговый зашумлённый сигнал
            for (int i = 0; i < size; i++)
            {
                noiseFinal[i] = signal[i] + alpha * signalNoise[i];
            }
        }

        internal void CreateSpectre()
        {
            for (int i = 0; i < size; i++)
            {
                spectre[i].Real = noiseFinal[i];
                spectre[i].Image = 0;
            }
            
            Fourea(spectre, size, -1);
        }

        internal void ClearSignal()
        {
            spectreEnergy = 0;
            for (int i = 0; i < size / 2; i++)
            {
                spectreEnergy += Math.Sqrt((spectre[i].Real * spectre[i].Real) + (spectre[i].Image * spectre[i].Image));
            }

            spectreEnergy = spectreEnergy * energyPercent / 100;

            int count1 = 0, count2;//границы обрезания спектра
            double Ep = 0;
            for (int i = 0; i < size / 2; i++)
            {
                Ep += Math.Sqrt(spectre[i].Real * spectre[i].Real + spectre[i].Image * spectre[i].Image);
                count1 = i + 1;
                if (Ep > spectreEnergy) break;
            }
            count2 = size - count1;

            //зануляем спектр в заданных границах
            for (int i = count1; i < count2; i++)
            {
                spectre[i].Real = 0;
                spectre[i].Image = 0;
            }
            //копируем спектр для его очистки
            for (int i = 0; i < size; i++)
            {
                cleanSignal[i].Real = spectre[i].Real;
                cleanSignal[i].Image = spectre[i].Image;
            }
            //ОПФ
            Fourea(cleanSignal, size, 1);
            //СКОткл
            for (int i = 0; i < size; i++)
            {
                sumSquare += (signal[i] - cleanSignal[i].Real) * (signal[i] - cleanSignal[i].Real);
            }
            sumSquare = Math.Sqrt(Math.Abs(sumSquare));
        }

        /*=================== МЕТОДЫ ДЛЯ РАСЧЕТОВ ===================*/

        internal double Function(double amp, double freq, int current, double phase)
        {
            return amp * Math.Sin(2 * Math.PI * freq * current + phase);
        }

        double GetRandom(double minimum, double maximum)
        {
            return rand.NextDouble() * (maximum - minimum) + minimum;
        }

        internal void Fourea(Complex[] spectr, int n, int direct)
        {
            int i, j, istep;
            int m, mmax;
            double r, r1, theta, w_r, w_i, temp_r, temp_i;
            double pi = 3.1415926f;

            r = pi * direct;
            j = 0;
            for (i = 0; i < n; i++)
            {
                if (i < j)
                {
                    temp_r = spectr[j].Real;
                    temp_i = spectr[j].Image;
                    spectr[j].Real = spectr[i].Real;
                    spectr[j].Image = spectr[i].Image;
                    spectr[i].Real = temp_r;
                    spectr[i].Image = temp_i;
                }
                m = n >> 1;
                while (j >= m) { j -= m; m = (m + 1) / 2; }
                j += m;
            }

            mmax = 1;
            while (mmax < n)
            {
                istep = mmax << 1;
                r1 = r / (float)mmax;
                for (m = 0; m < mmax; m++)
                {
                    theta = r1 * m;
                    w_r = (float)Math.Cos((double)theta);
                    w_i = (float)Math.Sin((double)theta);
                    for (i = m; i < n; i += istep)
                    {
                        j = i + mmax;
                        temp_r = w_r * spectr[j].Real - w_i * spectr[j].Image;
                        temp_i = w_r * spectr[j].Image + w_i * spectr[j].Real;
                        spectr[j].Real = spectr[i].Real - temp_r;
                        spectr[j].Image = spectr[i].Image - temp_i;
                        spectr[i].Real += temp_r;
                        spectr[i].Image += temp_i;
                    }
                }
                mmax = istep;
            }

            if (direct > 0)
            {
                for (i = 0; i < n; i++)
                {
                    spectr[i].Real /= (float)n;
                    spectr[i].Image /= (float)n;
                }
            }
        }

        /*=================== МЕТОДЫ ДЛЯ ВОЗВРАТА ===================*/

        internal double[] GetSignal()
        {
            return signal;
        }

        internal double[] GetNoise()
        {
            return noiseFinal;
        }

        internal double[] GetSpectre()
        {
            double[] spectreAbs = new double[size];
            for (int i = 0; i < size; i++)
            {
                spectreAbs[i] = Math.Sqrt(spectre[i].Real * spectre[i].Real + spectre[i].Image * spectre[i].Image);
            }

            return spectreAbs;
        }

        internal double[] GetClean()
        {
            double[] clean = new double[size];

            for (int i = 0; i < size; i++)
            {
                clean[i] = cleanSignal[i].Real;
            }

            return clean;
        }

        internal double GetSquare()
        {
            if (noise == 0)
                return 0;
            else
                return sumSquare;
        }
    }
}
