using System;
using System.Windows.Forms;

namespace Signal_CSharp
{
    public partial class Window : Form
    {
        private double[] ampArray, freqArray, phaseArray;
        private int[] dataArray;
        private int size;
        private double sumSquare;
        private double[] signal, noiseFinal, spectre, clean;

        public Window()
        {
            InitializeComponent();
        }

        public void InitializeModel()
        {
            ampArray = new double[3];
            ampArray[0] = Convert.ToDouble(Amp1Text.Text);
            ampArray[1] = Convert.ToDouble(Amp2Text.Text);
            ampArray[2] = Convert.ToDouble(Amp3Text.Text);

            freqArray = new double[3];
            freqArray[0] = Convert.ToDouble(Freq1Text.Text);
            freqArray[1] = Convert.ToDouble(Freq2Text.Text);
            freqArray[2] = Convert.ToDouble(Freq3Text.Text);

            phaseArray = new double[3];
            phaseArray[0] = Convert.ToDouble(Phase1Text.Text);
            phaseArray[1] = Convert.ToDouble(Phase2Text.Text);
            phaseArray[2] = Convert.ToDouble(Phase3Text.Text);

            dataArray = new int[4];
            dataArray[0] = Convert.ToInt32(SizeText.Text);
            dataArray[1] = Convert.ToInt32(AmountText.Text);
            dataArray[2] = Convert.ToInt32(NoiseText.Text);
            dataArray[3] = Convert.ToInt32(SpectreEnergyText.Text);

            size = dataArray[0];
        }

        //чтобы по дефолту при запуске были графики и значения
        private void Window_Load(object sender, EventArgs e)
        {
            ResearchButton_Click(sender, e);
        }

        private void ResearchButton_Click(object sender, EventArgs e)
        {
            InitializeModel();
            Calculation model = new Calculation(ampArray, freqArray, phaseArray, dataArray);

            model.CreateGraph();
            model.AddNoise();
            model.CreateSpectre();
            model.ClearSignal();

            signal = new double[size];
            signal = model.GetSignal();

            noiseFinal = new double[size];
            noiseFinal = model.GetNoise();

            spectre = new double[size];
            spectre = model.GetSpectre();

            clean = new double[size];
            clean = model.GetClean();

            sumSquare = model.GetSquare();

            SignalChart.Series[0].Points.Clear();
            SignalChart.Series[1].Points.Clear();
            NoiseChart.Series[0].Points.Clear();
            SpectreChart.Series[0].Points.Clear();

            //отрисовка графиков
            for (int i = 1; i < size; i++)
            {
                SignalChart.Series[0].Points.AddXY(i, signal[i]);
                SignalChart.Series[1].Points.AddXY(i, clean[i]);
                NoiseChart.Series[0].Points.AddXY(i, noiseFinal[i]);
                SpectreChart.Series[0].Points.AddXY(i / (double)size, spectre[i]);
            }

            SquareLabel.Text = sumSquare.ToString();
        }
    }
}
