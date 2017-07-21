using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
using OxyPlot.Axes;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using SerialPortListener.Serial;

namespace Scope
{

    public partial class MainForm : MetroForm
    {
        /// <summary>
        /// Variables
        /// </summary>
        SerialPortManager _spManager;
        string afont = "Tahoma";
        int fontsize = 12;
        string[] SampleRateList = new string[] { "1 µs/Sample", "2 µs/Sample", "3 µs/Sample", "5 µs/Sample",
        "10 µs/Sample","20 µs/Sample","50 µs/Sample","100 µs/Sample","200 µs/Sample","500 µs/Sample",
        "1 ms/Sample","2 ms/Sample","5 ms/Sample","10 ms/Sample","20 ms/Sample","50 ms/Sample","100 ms/Sample"};
        UInt32[] SampleRateValueList = new UInt32[] {0,2,3,5,
                                                    10,20,50,100,200,500,
                                                    1000,2000,5000,10000,20000,50000,100000};
        UInt32 SampleRateValue = 0;
        UInt32[] XMajorStep = new UInt32[] {50,100,150,200,
                                            500,1000,2000,4000,10000,20000,
                                            50000,100000,250000,500000,1000000,2000000,5000000};
        
        //===================================================================
        string[] SelectChanelCmd = new string[] { ">", "<", "=" };//{A,B,A&B}
        //===================================================================
        int CHAX1Cmd = 1;
        int CHAX10Cmd = 10;
        //===================================================================
        int CHBX1Cmd = 1;
        int CHBX10Cmd = 10;
        //===================================================================
        string StopCmd = "!";
        //===================================================================
        UInt16[] ChannelA = new UInt16[400];
        UInt16[] ChannelB = new UInt16[400];
        double[] ChannelAVoltage = new double[400];
        double[] ChannelBVoltage = new double[400];

        UInt16 SampleCount = 400;
        UInt32 TimerValue;
        Double TimerStep = 2 * Math.Pow(10,-8);
        bool Connected = false;
        double step;
        double FreqA;
        double FreqB;
        double RMSA;
        double RMSB;
        PlotView Scope = new PlotView();
        double ErrA = 0.14;
        double ErrB = 0.14;
        double err = 0.1; //For calculate Frequency
        int GainA;
        int GainB;
        int CHAX;
        int CHBX;
        double CHAOffset;
        double CHBOffset;

        public MainForm()
        {   
            InitializeComponent();
            _spManager = new SerialPortManager();
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            serialSettingsBindingSource.DataSource = mySerialSettings;
            ComboboxCOM.DataSource = (mySerialSettings.PortNameCollection.Length > 0) ? mySerialSettings.PortNameCollection : new string[] { "Chưa có" };
            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            ComboBoxSampleRate.DataSource = SampleRateList;
        }
        private int FindSampleRateIndex(UInt32 Value)
        {
            int index=0;
            if(Value == 0)
            {
                index = 0;
            }
            if (Value == 2)
            {
                index = 1;
            }
            if (Value == 3)
            {
                index = 2;
            }
            if (Value == 5)
            {
                index = 3;
            }
            if (Value == 10)
            {
                index = 4;
            }
            if (Value == 20)
            {
                index = 5;
            }
            if (Value == 50)
            {
                index = 6;
            }
            if (Value == 100)
            {
                index = 7;
            }
            if (Value == 200)
            {
                index = 8;
            }
            if (Value == 500)
            {
                index = 9;
            }
            if (Value == 1000)
            {
                index = 10;
            }
            if (Value == 2000)
            {
                index = 11;
            }
            if (Value == 5000)
            {
                index = 12;
            }
            if (Value == 10000)
            {
                index = 13;
            }
            if (Value == 20000)
            {
                index = 14;
            }
            if (Value == 50000)
            {
                index = 15;
            }
            if (Value == 100000)
            {
                index = 16;
            }
            return index;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DrawScope();
        }
        private void ComboboxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            _spManager.CurrentSerialSettings.PortName = ComboboxCOM.SelectedItem.ToString();
        }

        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }
            // This application is connected to a GPS sending ASCCI characters, so data is converted to text
            string str = Encoding.ASCII.GetString(e.Data);
            TextBoxRawData.AppendText(str);
            if (TextBoxRawData.TextLength == 4021)
            {
                string[] RawData = TextBoxRawData.Text.Split(',');
                TextBoxRawData.Clear();
                _spManager.Dispose();
                if (RawData.Length > SampleCount * 2)
                {
                    for (int i = 0; i < RawData.Length; i++)
                    {
                        if (i < SampleCount)
                        {
                            UInt16 ADC;
                            if (UInt16.TryParse(RawData[i], out ADC))
                            {
                                ChannelA[i] = ADC;
                            }
                        }
                        if ((i >= SampleCount) && (i < (RawData.Length - 2)))
                        {
                            UInt16 ADC;
                            if (UInt16.TryParse(RawData[i], out ADC))
                            {
                                ChannelB[i - SampleCount] = ADC;
                            }
                        }
                        if (i == (RawData.Length - 2))
                        {
                            if (UInt32.TryParse(RawData[i], out TimerValue))
                            {

                            }
                        }
                        if (i == (RawData.Length - 1))
                        {
                            if (UInt32.TryParse(RawData[i], out SampleRateValue))
                            {
                                DrawScope();
                                if (RadioButtonRepeat.Checked)
                                {
                                    _spManager.clearInBuffer();
                                    _spManager.clearOutBuffer();
                                    _spManager.Dispose();
                                    _spManager.Dispose();
                                    _spManager.Dispose();
                                    _spManager.StartListening();
                                    if((ToggleA.Checked==true)||(ToggleB.Checked==true))
                                    {
                                        sendCmd();
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
        private void sendCmd()
        {
            string cmd = "";
            cmd += SampleRateValueList[ComboBoxSampleRate.SelectedIndex].ToString() + ",";
            //================================
            if(RadioButtonX1A.Checked == true)
            {
                cmd += CHAX1Cmd.ToString() + ",";
                CHAX = 1;
            }
            else if (RadioButtonX10A.Checked == true)
            {
                cmd += CHAX10Cmd.ToString() + ",";
                CHAX = 10;
            }

            cmd += GainValue(TrackBarGainA.Value).ToString() + ",";
            GainA = TrackBarGainA.Value;

            cmd += (255 - TrackBarOffsetA.Value).ToString() + ",";
            CHAOffset = 3.3 / 255 * TrackBarOffsetA.Value;

            //=================================
            if (RadioButtonX1B.Checked == true)
            {
                cmd += CHBX1Cmd.ToString() + ",";
                CHBX = 1;
            }
            else if (RadioButtonX10B.Checked == true)
            {
                cmd += CHBX10Cmd.ToString() + ",";
                CHBX = 10;
            }

            cmd += GainValue(TrackBarGainB.Value).ToString() + ",";
            GainB = TrackBarGainB.Value;

            cmd += (255 - TrackBarOffsetB.Value).ToString() + ",";
            CHBOffset = 3.3 / 255 * TrackBarOffsetB.Value;

            cmd += "@";
            Log.Text = cmd;
            _spManager.clearInBuffer();
            _spManager.clearOutBuffer();
            _spManager.SendData(cmd);
        }
        private double CalculateVoltage(UInt16 ADCValue,int X, int Gain, double Offset, double Err)
        {
            double Voltage = 0;
            double scale = 1;
            if(X == 10)
            {
                scale = 10;
            }
            else
            {
                scale = 1;
            }
            Voltage = ((3.3 * ADCValue) / (1024 * Gain)-Offset) * 11 * scale;
            return Voltage;
        }
        private void CalculateFreqAndRMS()
        {
            double MaxA, MaxB, MinA, MinB;
            double MidA, MidB;
            double SumMidA = 0;
            double SumMidB = 0;
            int BeginA = 0;
            int EndA = 0;
            int MiddA = 0;
            int BeginB = 0;
            int EndB = 0;
            int MiddB = 0;
            int i = 0;
            double[] AVoltage = new double[400];
            double[] BVoltage = new double[400];
            try
            {
                    for(int dt = 0; dt < 400; dt ++)
                    {
                        AVoltage[dt] = ChannelAVoltage[dt];
                    }
                    for (int dt = 0; dt < 400; dt++)
                    {
                        BVoltage[dt] = ChannelBVoltage[dt];
                    }
                MaxA = AVoltage.Max();
                MinA = AVoltage.Min();
                MidA = (MaxA + MinA) / 2;
                MaxB = BVoltage.Max();
                MinB = BVoltage.Min();
                MidB = (MaxB + MinB) / 2;
                if(ToggleA.Checked == true)
                {
                    if (AVoltage[0] > MidA)
                    {
                        for (i = 1; i < SampleCount; i++)
                        {
                            if ((AVoltage[i] <= MidA) && (BeginA == 0))
                            {
                                BeginA = i;
                            }
                            if ((BeginA != 0) && (AVoltage[i] >= MidA) && (MiddA == 0))
                            {
                                MiddA = i;
                            }
                            if ((MiddA != 0) && (AVoltage[i] <= MidA) && (EndA == 0))
                            {
                                EndA = i;
                            }
                            if ((EndA != 0) && (BeginA != 0) && (EndA > BeginA) && (MaxA - MinA > err))
                            {
                                FreqA = 1 / ((EndA - BeginA) * step * Math.Pow(10, -6));
                                LabelFreqAV.Text = String.Format("{0:0.0} Hz", FreqA);
                                for (int j = BeginA; j <= EndA; j++)
                                {
                                    SumMidA += Math.Pow(AVoltage[j + 1], 2);
                                }
                                RMSA = Math.Sqrt(SumMidA / (EndA - BeginA));
                                SumMidA = 0;
                                LabelRMSAV.Text = String.Format("{0:0.00} V", RMSA);
                            }
                            else
                            {
                                LabelFreqAV.Text = "? Hz";
                                LabelRMSAV.Text = "? V";
                            }
                        }
                    }
                    else if (AVoltage[0] < MidA)
                    {
                        for (i = 1; i < SampleCount; i++)
                        {
                            if ((AVoltage[i] >= MidA) && (BeginA == 0))
                            {
                                BeginA = i;
                            }
                            if ((BeginA != 0) && (AVoltage[i] <= MidA) && (MiddA == 0))
                            {
                                MiddA = i;
                            }
                            if ((MiddA != 0) && (AVoltage[i] >= MidA) && (EndA == 0))
                            {
                                EndA = i;
                            }
                            if ((EndA != 0) && (BeginA != 0) && (EndA > BeginA) && (MaxA - MinA > err))
                            {
                                FreqA = 1 / ((EndA - BeginA) * step * Math.Pow(10, -6));
                                LabelFreqAV.Text = String.Format("{0:0.0} Hz", FreqA);
                                for (int j = BeginA; j <= EndA; j++)
                                {
                                    SumMidA += Math.Pow(AVoltage[j + 1], 2);
                                }
                                RMSA = Math.Sqrt(SumMidA / (EndA - BeginA));
                                SumMidA = 0;
                                LabelRMSAV.Text = String.Format("{0:0.00} V", RMSA);
                            }
                            else
                            {
                                LabelFreqAV.Text = "? Hz";
                                LabelRMSAV.Text = "? V";
                            }
                        }
                    }
                }

                if(ToggleB.Checked == true)
                {
                    if (BVoltage[0] > MidB)
                    {
                        for (i = 1; i < SampleCount; i++)
                        {
                            if ((BVoltage[i] <= MidB) && (BeginB == 0))
                            {
                                BeginB = i;
                            }
                            if ((BeginB != 0) && (BVoltage[i] >= MidB) && (MiddB == 0))
                            {
                                MiddB = i;
                            }
                            if ((MiddB != 0) && (BVoltage[i] <= MidB) && (EndB == 0))
                            {
                                EndB = i;
                            }
                            if ((EndB != 0) && (BeginB != 0) && (EndB > BeginB) && (MaxB - MinB > err))
                            {
                                FreqB = 1 / ((EndB - BeginB) * step * Math.Pow(10, -6));
                                LabelFreqBV.Text = String.Format("{0:0.0} Hz", FreqB);
                                for (int j = BeginB; j <= EndB; j++)
                                {
                                    SumMidB += Math.Pow(BVoltage[j + 1], 2);
                                }
                                RMSB = Math.Sqrt(SumMidB / (EndB - BeginB));
                                SumMidB = 0;
                                LabelRMSBV.Text = String.Format("{0:0.00} V", RMSB);
                            }
                            else
                            {
                                LabelFreqBV.Text = "? Hz";
                                LabelRMSBV.Text = "? V";
                            }
                        }
                    }
                    else if (BVoltage[0] < MidB)
                    {
                        for (i = 1; i < SampleCount; i++)
                        {
                            if ((BVoltage[i] >= MidB) && (BeginB == 0))
                            {
                                BeginB = i;
                            }
                            if ((BeginB != 0) && (BVoltage[i] <= MidB) && (MiddB == 0))
                            {
                                MiddB = i;
                            }
                            if ((MiddB != 0) && (BVoltage[i] >= MidB) && (EndB == 0))
                            {
                                EndB = i;
                            }
                            if ((EndB != 0) && (BeginB != 0) && (EndB > BeginB) && (MaxB - MinB > err))
                            {
                                FreqB = 1 / ((EndB - BeginB) * step * Math.Pow(10, -6));
                                LabelFreqBV.Text = String.Format("{0:0.0} Hz", FreqB);
                                for (int j = BeginB; j <= EndB; j++)
                                {
                                    SumMidB += Math.Pow(BVoltage[j + 1], 2);
                                }
                                RMSB = Math.Sqrt(SumMidB / (EndB - BeginB));
                                SumMidB = 0;
                                LabelRMSBV.Text = String.Format("{0:0.00} V", RMSB);
                            }
                            else
                            {
                                LabelFreqBV.Text = "0 Hz";
                                LabelRMSBV.Text = "? V";
                            }
                        }
                    }
                }
                BeginA = 0;
                MiddA = 0;
                EndA = 0;
                BeginB = 0;
                MiddB = 0;
                EndB = 0;
            }
            catch
            {
                //LabelFreqA.Text = e.Message;
            }
        }
        private void DrawScope()
        {
            if(!Controls.Contains(Scope))
            {
                Scope.Location = new Point(30, 90);
                Scope.Size = new Size(900, 600);
                Controls.Add(Scope);
            }
            PlotModel Model = new PlotModel
            {
                Title = "",
                DefaultFont = afont,
                DefaultFontSize = fontsize,
                LegendTitle = "",
                PlotType = PlotType.XY,
                TitleFont = afont,
                Culture = System.Globalization.CultureInfo.CurrentCulture,
                LegendSymbolLength = 24,
                Padding = new OxyThickness(0, 20, 30, 0)
            };
            Model.InvalidatePlot(true);
            Scope.Model = Model;
            LinearAxis YAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = -20,
                Maximum = 20,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                Title = "Điện áp (V)",
                MajorStep = 4,
                Font = afont,
                FontSize = fontsize,
                LabelFormatter = _formatter
            };
            LinearAxis XAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Maximum = 400,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                Title = "Thời gian (µs) ",
                MajorStep = 50,
                Font = afont,
                FontSize = fontsize,
                LabelFormatter = _time_formatter
            };
            Scope.Model.Axes.Add(XAxis);
            Scope.Model.Axes.Add(YAxis);

            //Timer 32bit, 100MHz, 50 MIPS, 2*(10^-8) sec/step,2*(10^-8)*50 = 1 µs
            if (TimerValue > 0)
            {
                double TimeRange = TimerValue * Math.Pow(10, 6) * TimerStep; //Micro Second
                step = TimeRange / SampleCount; //Micro Second
                for (int dt = 0; dt < SampleCount; dt++)
                {
                    try
                    {
                        ChannelAVoltage[dt] = CalculateVoltage(ChannelA[dt], CHAX, GainA, CHAOffset, ErrA);
                        ChannelBVoltage[dt] = CalculateVoltage(ChannelB[dt], CHBX, GainB, CHBOffset, ErrB);
                    }
                    catch (Exception e)
                    {
                        TextBoxRawData.Text = e.Message + " Voltage\r\n";
                    }
                }
                double MaxA = ChannelAVoltage.Max();
                double MinA = ChannelAVoltage.Min();
                double MaxB = ChannelBVoltage.Max();
                double MinB = ChannelBVoltage.Min();
                double MidA = (MaxA + MinA) / 2;
                double MidB = (MaxB + MinB) / 2;
                if(ToggleA.Checked == true)
                {
                    LabelMaxAV.Text = String.Format("{0:0.00}V", ChannelAVoltage.Max());
                    LabelMinAV.Text = String.Format("{0:0.00}V", ChannelAVoltage.Min());
                }
                if(ToggleB.Checked == true)
                {
                    LabelMaxBV.Text = String.Format("{0:0.00}V", ChannelBVoltage.Max());
                    LabelMinBV.Text = String.Format("{0:0.00}V", ChannelBVoltage.Min());
                }

                double MaxY = Math.Max(MaxA, MaxB);
                if (MaxY == 0) MaxY = 20;
                MaxY = Math.Abs(Math.Min(MinA, MinB)) > MaxY ? Math.Abs(Math.Min(MinA, MinB)) + Math.Abs(Math.Min(MinA, MinB)) : MaxY + MaxY;
                if(CheckBoxAUP.Checked || CheckBoxBUP.Checked)
                {
                    MaxY = 3 * MaxY;
                }
                double MinY = -MaxY;
                YAxis.Maximum = MaxY;
                YAxis.Minimum = MinY;
                YAxis.MajorStep = MaxY / 5;
                XAxis.Minimum = 0;
                XAxis.Maximum = TimeRange;
                XAxis.MajorStep = XMajorStep[FindSampleRateIndex(SampleRateValue)];
                var CHA = new LineSeries
                {
                    Color = OxyColors.Blue,
                    MarkerType = MarkerType.None,
                    MarkerSize = 1,
                    MarkerStroke = OxyColors.White,
                    MarkerFill = OxyColors.Black,
                    MarkerStrokeThickness = 1,
                    LineStyle = LineStyle.Solid,
                    Smooth = false,
                    StrokeThickness = 1,
                    Title = "KÊNH A",
                    TrackerFormatString = "{0}\n{1}: {2:0.00}\n{3}: {4:0.00}"
                };

                var CHB = new LineSeries
                {
                    Color = OxyColors.Red,
                    MarkerType = MarkerType.None,
                    MarkerSize = 1,
                    MarkerStroke = OxyColors.White,
                    MarkerFill = OxyColors.Teal,
                    MarkerStrokeThickness = 1,
                    LineStyle = LineStyle.Solid,
                    Smooth = false,
                    StrokeThickness = 1,
                    Title = "KÊNH B",
                    TrackerFormatString = "{0}\n{1}: {2:0.00}\n{3}: {4:0.00}"
                };

                for (int dt = 0; dt < SampleCount; dt++)
                {
                    if ((MinA >= 0) && (CheckBoxGNDA.Checked == true))
                    {
                        ChannelAVoltage[dt] = ChannelAVoltage[dt] - MinA;
                    }
                    if ((MinB >= 0) && (CheckBoxGNDB.Checked == true))
                    {
                        ChannelBVoltage[dt] = ChannelBVoltage[dt] - MinB;
                    }
                    try
                    {
                        if(CheckBoxAUP.Checked)
                        {
                            CHA.Points.Add(new DataPoint(step * dt, ChannelAVoltage[dt]+3*MaxB));
                            CHB.Points.Add(new DataPoint(step * dt, ChannelBVoltage[dt]));
                        }
                        else if (CheckBoxBUP.Checked)
                        {
                            CHA.Points.Add(new DataPoint(step * dt, ChannelAVoltage[dt]));
                            CHB.Points.Add(new DataPoint(step * dt, ChannelBVoltage[dt]+3*MaxA));
                        }
                        else
                        {
                            CHA.Points.Add(new DataPoint(step * dt, ChannelAVoltage[dt]));
                            CHB.Points.Add(new DataPoint(step * dt, ChannelBVoltage[dt]));
                        }
                    }
                    catch (Exception e)
                    {
                        TextBoxRawData.AppendText(e.Message + "Points");
                    }
                }
                if(ToggleA.Checked == true)
                {
                    Scope.Model.Series.Add(CHA);
                }
                if(ToggleB.Checked == true)
                {
                    Scope.Model.Series.Add(CHB);
                }
                CalculateFreqAndRMS();
                Scope.Update();
                Scope.Refresh();
            }
        }
        private static string _formatter(double d)
        {
            if (d < 1E3)
            {
                return String.Format("{0:0.00}", d);
            }
            else if (d >= 1E3 && d < 1E6)
            {
                return String.Format("{0:0.00}K", d / 1E3);
            }
            else if (d >= 1E6 && d < 1E9)
            {
                return String.Format("{0:0.00}M", d / 1E6);
            }
            else if (d >= 1E9)
            {
                return String.Format("{0:0.00}B", d / 1E9);
            }
            else
            {
                return String.Format("{0:0.00}", d);
            }
        }
        private static string _time_formatter(double d)
        {
            if (d < 1E3)
            {
                return String.Format("{0:0}µs", d);
            }
            else if (d >= 1E3 && d < 1E6)
            {
                return String.Format("{0:0.0}ms", d / 1E3);
            }
            else if (d >= 1E6 && d < 1E9)
            {
                return String.Format("{0:0.0}s", d / 1E6);
            }
            else if (d >= 1E9)
            {
                return String.Format("{0:0.0}B", d / 1E9);
            }
            else
            {
                return String.Format("{0:0}µs", d);
            }
        }
        private void SaveData()
        {
            string csv=null;
            DateTime dt = DateTime.Now;
            string filename = ".\\Saved\\csv\\"+dt.ToString("dd_MM_yyyy_hh_mm")+".csv";
            string imgfilename = ".\\Saved\\png\\" + dt.ToString("dd_MM_yyyy_hh_mm") + ".png";
            try
            {
                for(int i = 0; i<SampleCount; i++)
                {
                    csv += ChannelAVoltage[i].ToString()+";"+ChannelBVoltage[i].ToString()+"\r\n";
                }
                File.AppendAllText(@filename, "Channel A;Channel B\r\n" + csv,Encoding.UTF8);
                File.AppendAllText(@filename, "Vrms A;Freq A;Vrms B;Freq B\r\n" + LabelRMSAV.Text + ";" + LabelFreqAV.Text +";"+LabelRMSBV.Text+";"+LabelFreqBV.Text, Encoding.UTF8);
                var pngExporter = new PngExporter { Width = 900, Height = 480, Background = OxyColors.White };
                pngExporter.ExportToFile(Scope.Model, imgfilename);
            }
            catch
            {

            }
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if(Connected == false)
                {
                    _spManager.StartListening();
                    sendCmd();
                    ComboboxCOM.Enabled = false;
                    LabelConnect.Text = "ĐÃ KẾT NỐI THIẾT BỊ";
                    ButtonStartStop.Text = "NGẮT";
                    Connected = true;
                    ButtonStartStop.Focus();
                    ButtonCapture.Enabled = true;
                    ButtonSave.Enabled = true;
                }
                else
                {
                    _spManager.SendData(StopCmd);
                    _spManager.SendData(StopCmd);
                    _spManager.SendData(StopCmd);
                    _spManager.StopListening();
                    _spManager.Dispose();
                    _spManager.Dispose();
                    _spManager.Dispose();
                    TextBoxRawData.Clear();
                    ComboboxCOM.Enabled = true;
                    LabelConnect.Text = "CHƯA KẾT NỐI";
                    ButtonStartStop.Text = "KẾT NỐI";
                    ButtonCapture.Text = "LẤY MẪU";
                    Connected = false;
                    ButtonCapture.Enabled = false;
                    ButtonSave.Enabled = false;
                }
                ButtonCapture.Focus();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\r\n\r\nKhông kết nối được với cổng COM :\r\n" + ex.Message, "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void ToggleA_CheckedChanged(object sender, EventArgs e)
        {
            DrawScope();
            if(ToggleA.Checked == false)
            {
                LabelMaxAV.Text = "0.00V";
                LabelMinAV.Text = "0.00V";
                LabelRMSAV.Text = "0.00V";
                LabelFreqAV.Text = "0.00Hz";
            }
        }

        private void ToggleB_CheckedChanged(object sender, EventArgs e)
        {
            DrawScope();
            if (ToggleB.Checked == false)
            {
                LabelMaxBV.Text = "0.00V";
                LabelMinBV.Text = "0.00V";
                LabelRMSBV.Text = "0.00V";
                LabelFreqBV.Text = "0.00Hz";
            }
        }

        private void ButtonCapture_Click(object sender, EventArgs e)
        {
            _spManager.SendData(StopCmd);
            _spManager.SendData(StopCmd);
            _spManager.Dispose();
            _spManager.Dispose();
            _spManager.Dispose();
            _spManager.StartListening();
            TextBoxRawData.Clear();
            sendCmd();
        }

        private int GainValue(int gain)
        {
            int value=0;
            if (gain == 1)
            {
                value = 0;
            }
            else
            {
                value = 256 - 256 / gain;
            }
            return value;
        }

        private void TrackBarGainA_Scroll(object sender, ScrollEventArgs e)
        {
            LabelGainA.Text = (TrackBarGainA.Value > 0 ? TrackBarGainA.Value.ToString() : "1") + "/1 V";
        }

        private void TrackBarGainB_Scroll(object sender, ScrollEventArgs e)
        {
            LabelGainB.Text = (TrackBarGainB.Value > 0 ? TrackBarGainB.Value.ToString() : "1") + "/1 V";
        }

        private void TrackBarOffsetA_Scroll(object sender, ScrollEventArgs e)
        {
            LabelOffsetA.Text = String.Format("{0:0.00}", 3.3 / 255 * TrackBarOffsetA.Value) + " V";
        }

        private void TrackBarOffsetB_Scroll(object sender, ScrollEventArgs e)
        {
            LabelOffsetB.Text = String.Format("{0:0.00}", 3.3 / 255 * TrackBarOffsetB.Value) + " V";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void CheckBoxAUP_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxAUP.Checked == true)
            {
                CheckBoxBUP.Checked = false;
            }
            DrawScope();
        }

        private void CheckBoxBUP_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxBUP.Checked == true)
            {
                CheckBoxAUP.Checked = false;
            }
            DrawScope();
        }

        private void CheckBoxGNDA_CheckedChanged(object sender, EventArgs e)
        {
            DrawScope();
        }

        private void CheckBoxGNDB_CheckedChanged(object sender, EventArgs e)
        {
            DrawScope();
        }
    }
}