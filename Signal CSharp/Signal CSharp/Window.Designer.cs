namespace Signal_CSharp
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SignalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Amp1Text = new System.Windows.Forms.TextBox();
            this.SpectreChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NoiseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Phase3Text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Phase2Text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Phase1Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Freq3Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Freq2Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Freq1Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Amp3Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Amp2Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NoiseText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SpectreEnergyText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectreChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignalChart
            // 
            chartArea4.Name = "ChartArea1";
            this.SignalChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.SignalChart.Legends.Add(legend4);
            this.SignalChart.Location = new System.Drawing.Point(13, 13);
            this.SignalChart.Name = "SignalChart";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.LegendText = "Исходный";
            series5.Name = "Signal";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.LegendText = "Очищенный";
            series6.Name = "Restored";
            this.SignalChart.Series.Add(series5);
            this.SignalChart.Series.Add(series6);
            this.SignalChart.Size = new System.Drawing.Size(602, 300);
            this.SignalChart.TabIndex = 0;
            this.SignalChart.Text = "chart1";
            // 
            // ResearchButton
            // 
            this.ResearchButton.Location = new System.Drawing.Point(975, 425);
            this.ResearchButton.Name = "ResearchButton";
            this.ResearchButton.Size = new System.Drawing.Size(157, 61);
            this.ResearchButton.TabIndex = 1;
            this.ResearchButton.Text = "Исследовать";
            this.ResearchButton.UseVisualStyleBackColor = true;
            this.ResearchButton.Click += new System.EventHandler(this.ResearchButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Амплитуда №1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amp1Text
            // 
            this.Amp1Text.Location = new System.Drawing.Point(112, 18);
            this.Amp1Text.Name = "Amp1Text";
            this.Amp1Text.Size = new System.Drawing.Size(54, 20);
            this.Amp1Text.TabIndex = 3;
            this.Amp1Text.Text = "1";
            this.Amp1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpectreChart
            // 
            chartArea5.AxisX.Interval = 0.1D;
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea5.Name = "ChartArea1";
            this.SpectreChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.SpectreChart.Legends.Add(legend5);
            this.SpectreChart.Location = new System.Drawing.Point(621, 13);
            this.SpectreChart.Name = "SpectreChart";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.DarkGreen;
            series7.Legend = "Legend1";
            series7.LegendText = "Спектр";
            series7.Name = "SpectreSeries";
            this.SpectreChart.Series.Add(series7);
            this.SpectreChart.Size = new System.Drawing.Size(511, 300);
            this.SpectreChart.TabIndex = 4;
            this.SpectreChart.Text = "chart2";
            // 
            // NoiseChart
            // 
            chartArea6.Name = "ChartArea1";
            this.NoiseChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.NoiseChart.Legends.Add(legend6);
            this.NoiseChart.Location = new System.Drawing.Point(13, 319);
            this.NoiseChart.Name = "NoiseChart";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.LegendText = "Шум";
            series8.Name = "NoiseSeries";
            this.NoiseChart.Series.Add(series8);
            this.NoiseChart.Size = new System.Drawing.Size(602, 310);
            this.NoiseChart.TabIndex = 5;
            this.NoiseChart.Text = "chart4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Phase3Text);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Phase2Text);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Phase1Text);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Freq3Text);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Freq2Text);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Freq1Text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Amp3Text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Amp2Text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Amp1Text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(621, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры синусоид";
            // 
            // Phase3Text
            // 
            this.Phase3Text.Location = new System.Drawing.Point(450, 70);
            this.Phase3Text.Name = "Phase3Text";
            this.Phase3Text.Size = new System.Drawing.Size(54, 20);
            this.Phase3Text.TabIndex = 19;
            this.Phase3Text.Text = "2";
            this.Phase3Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(366, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Фаза №3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phase2Text
            // 
            this.Phase2Text.Location = new System.Drawing.Point(450, 44);
            this.Phase2Text.Name = "Phase2Text";
            this.Phase2Text.Size = new System.Drawing.Size(54, 20);
            this.Phase2Text.TabIndex = 17;
            this.Phase2Text.Text = "3";
            this.Phase2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(366, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Фаза №2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phase1Text
            // 
            this.Phase1Text.Location = new System.Drawing.Point(450, 18);
            this.Phase1Text.Name = "Phase1Text";
            this.Phase1Text.Size = new System.Drawing.Size(54, 20);
            this.Phase1Text.TabIndex = 15;
            this.Phase1Text.Text = "0";
            this.Phase1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(366, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Фаза №1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq3Text
            // 
            this.Freq3Text.Location = new System.Drawing.Point(288, 70);
            this.Freq3Text.Name = "Freq3Text";
            this.Freq3Text.Size = new System.Drawing.Size(54, 20);
            this.Freq3Text.TabIndex = 13;
            this.Freq3Text.Text = "0.2";
            this.Freq3Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(204, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Частота №3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq2Text
            // 
            this.Freq2Text.Location = new System.Drawing.Point(288, 44);
            this.Freq2Text.Name = "Freq2Text";
            this.Freq2Text.Size = new System.Drawing.Size(54, 20);
            this.Freq2Text.TabIndex = 11;
            this.Freq2Text.Text = "0.15";
            this.Freq2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(204, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Частота №2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq1Text
            // 
            this.Freq1Text.Location = new System.Drawing.Point(288, 18);
            this.Freq1Text.Name = "Freq1Text";
            this.Freq1Text.Size = new System.Drawing.Size(54, 20);
            this.Freq1Text.TabIndex = 9;
            this.Freq1Text.Text = "0.05";
            this.Freq1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(204, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Частота №1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amp3Text
            // 
            this.Amp3Text.Location = new System.Drawing.Point(112, 70);
            this.Amp3Text.Name = "Amp3Text";
            this.Amp3Text.Size = new System.Drawing.Size(54, 20);
            this.Amp3Text.TabIndex = 7;
            this.Amp3Text.Text = "3";
            this.Amp3Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Амплитуда №3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amp2Text
            // 
            this.Amp2Text.Location = new System.Drawing.Point(112, 44);
            this.Amp2Text.Name = "Amp2Text";
            this.Amp2Text.Size = new System.Drawing.Size(54, 20);
            this.Amp2Text.TabIndex = 5;
            this.Amp2Text.Text = "4";
            this.Amp2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Амплитуда №2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeText
            // 
            this.SizeText.Location = new System.Drawing.Point(733, 424);
            this.SizeText.Name = "SizeText";
            this.SizeText.Size = new System.Drawing.Size(54, 20);
            this.SizeText.TabIndex = 21;
            this.SizeText.Text = "128";
            this.SizeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(630, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Отсчёты";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountText
            // 
            this.AmountText.Location = new System.Drawing.Point(733, 450);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(54, 20);
            this.AmountText.TabIndex = 23;
            this.AmountText.Text = "3";
            this.AmountText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(630, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Синусоиды";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoiseText
            // 
            this.NoiseText.Location = new System.Drawing.Point(733, 476);
            this.NoiseText.Name = "NoiseText";
            this.NoiseText.Size = new System.Drawing.Size(54, 20);
            this.NoiseText.TabIndex = 25;
            this.NoiseText.Text = "15";
            this.NoiseText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(630, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Шум, %";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SquareLabel
            // 
            this.SquareLabel.Location = new System.Drawing.Point(708, 543);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(179, 23);
            this.SquareLabel.TabIndex = 26;
            this.SquareLabel.Text = "0";
            this.SquareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(627, 543);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "Отклонение: ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpectreEnergyText
            // 
            this.SpectreEnergyText.Location = new System.Drawing.Point(909, 425);
            this.SpectreEnergyText.Name = "SpectreEnergyText";
            this.SpectreEnergyText.Size = new System.Drawing.Size(54, 20);
            this.SpectreEnergyText.TabIndex = 21;
            this.SpectreEnergyText.Text = "95";
            this.SpectreEnergyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(825, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 23);
            this.label14.TabIndex = 20;
            this.label14.Text = "Очистка, %";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 641);
            this.Controls.Add(this.SpectreEnergyText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SquareLabel);
            this.Controls.Add(this.NoiseText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SizeText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NoiseChart);
            this.Controls.Add(this.SpectreChart);
            this.Controls.Add(this.ResearchButton);
            this.Controls.Add(this.SignalChart);
            this.Name = "Window";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectreChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SignalChart;
        private System.Windows.Forms.Button ResearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amp1Text;
        private System.Windows.Forms.DataVisualization.Charting.Chart SpectreChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart NoiseChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Freq3Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Freq2Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Freq1Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Amp3Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Amp2Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phase3Text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Phase2Text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Phase1Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SizeText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NoiseText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SpectreEnergyText;
        private System.Windows.Forms.Label label14;
    }
}

