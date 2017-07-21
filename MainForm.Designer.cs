using MetroFramework.Forms;

namespace Scope
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ComboboxCOM = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.RadioButtonRepeat = new MetroFramework.Controls.MetroRadioButton();
            this.RadioButtonOnce = new MetroFramework.Controls.MetroRadioButton();
            this.LabelConnect = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxSampleRate = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.CheckBoxAUP = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxGNDA = new MetroFramework.Controls.MetroCheckBox();
            this.LabelMinAV = new MetroFramework.Controls.MetroLabel();
            this.LabelMinA = new MetroFramework.Controls.MetroLabel();
            this.LabelOffsetA = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TrackBarOffsetA = new MetroFramework.Controls.MetroTrackBar();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.RadioButtonX10A = new MetroFramework.Controls.MetroRadioButton();
            this.RadioButtonX1A = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LabelGainA = new MetroFramework.Controls.MetroLabel();
            this.TrackBarGainA = new MetroFramework.Controls.MetroTrackBar();
            this.LabelRMSAV = new MetroFramework.Controls.MetroLabel();
            this.LabelFreqAV = new MetroFramework.Controls.MetroLabel();
            this.LabelMaxAV = new MetroFramework.Controls.MetroLabel();
            this.LabelRMSA = new MetroFramework.Controls.MetroLabel();
            this.LabelMaxA = new MetroFramework.Controls.MetroLabel();
            this.LabelFreqA = new MetroFramework.Controls.MetroLabel();
            this.ToggleA = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.CheckBoxBUP = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxGNDB = new MetroFramework.Controls.MetroCheckBox();
            this.LabelMinBV = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.LabelOffsetB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.TrackBarOffsetB = new MetroFramework.Controls.MetroTrackBar();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.RadioButtonX10B = new MetroFramework.Controls.MetroRadioButton();
            this.RadioButtonX1B = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.LabelGainB = new MetroFramework.Controls.MetroLabel();
            this.TrackBarGainB = new MetroFramework.Controls.MetroTrackBar();
            this.LabelRMSBV = new MetroFramework.Controls.MetroLabel();
            this.LabelFreqBV = new MetroFramework.Controls.MetroLabel();
            this.LabelMaxBV = new MetroFramework.Controls.MetroLabel();
            this.LabelRMSB = new MetroFramework.Controls.MetroLabel();
            this.LabelFreqB = new MetroFramework.Controls.MetroLabel();
            this.LabelAmpB = new MetroFramework.Controls.MetroLabel();
            this.ToggleB = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.ButtonStartStop = new MetroFramework.Controls.MetroButton();
            this.ButtonCapture = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextBoxRawData = new System.Windows.Forms.TextBox();
            this.ButtonSave = new MetroFramework.Controls.MetroButton();
            this.Log = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboboxCOM
            // 
            this.ComboboxCOM.FormattingEnabled = true;
            this.ComboboxCOM.ItemHeight = 23;
            this.ComboboxCOM.Location = new System.Drawing.Point(147, 27);
            this.ComboboxCOM.Name = "ComboboxCOM";
            this.ComboboxCOM.Size = new System.Drawing.Size(131, 29);
            this.ComboboxCOM.TabIndex = 2;
            this.ComboboxCOM.UseSelectable = true;
            this.ComboboxCOM.SelectedIndexChanged += new System.EventHandler(this.ComboboxCOM_SelectedIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.RadioButtonRepeat);
            this.metroPanel1.Controls.Add(this.RadioButtonOnce);
            this.metroPanel1.Controls.Add(this.LabelConnect);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.ComboBoxSampleRate);
            this.metroPanel1.Controls.Add(this.ComboboxCOM);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(950, 87);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(281, 122);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel6.Location = new System.Drawing.Point(5, 96);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "CHẾ ĐỘ";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // RadioButtonRepeat
            // 
            this.RadioButtonRepeat.AutoSize = true;
            this.RadioButtonRepeat.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RadioButtonRepeat.Location = new System.Drawing.Point(205, 97);
            this.RadioButtonRepeat.Name = "RadioButtonRepeat";
            this.RadioButtonRepeat.Size = new System.Drawing.Size(73, 19);
            this.RadioButtonRepeat.TabIndex = 28;
            this.RadioButtonRepeat.Text = "LẶP LẠI";
            this.RadioButtonRepeat.UseSelectable = true;
            // 
            // RadioButtonOnce
            // 
            this.RadioButtonOnce.AutoSize = true;
            this.RadioButtonOnce.Checked = true;
            this.RadioButtonOnce.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RadioButtonOnce.Location = new System.Drawing.Point(78, 97);
            this.RadioButtonOnce.Name = "RadioButtonOnce";
            this.RadioButtonOnce.Size = new System.Drawing.Size(86, 19);
            this.RadioButtonOnce.TabIndex = 27;
            this.RadioButtonOnce.TabStop = true;
            this.RadioButtonOnce.Text = "MỘT LẦN";
            this.RadioButtonOnce.UseSelectable = true;
            // 
            // LabelConnect
            // 
            this.LabelConnect.AutoSize = true;
            this.LabelConnect.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelConnect.ForeColor = System.Drawing.Color.DimGray;
            this.LabelConnect.Location = new System.Drawing.Point(7, 2);
            this.LabelConnect.Name = "LabelConnect";
            this.LabelConnect.Size = new System.Drawing.Size(112, 19);
            this.LabelConnect.TabIndex = 7;
            this.LabelConnect.Text = "CHƯA  KẾT NỐI";
            this.LabelConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelConnect.UseCustomBackColor = true;
            this.LabelConnect.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel4.Location = new System.Drawing.Point(5, 65);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "TỐC ĐỘ LẤY MẪU";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel3.Location = new System.Drawing.Point(5, 37);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "CỔNG COM";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // ComboBoxSampleRate
            // 
            this.ComboBoxSampleRate.BackColor = System.Drawing.Color.YellowGreen;
            this.ComboBoxSampleRate.FormattingEnabled = true;
            this.ComboBoxSampleRate.ItemHeight = 23;
            this.ComboBoxSampleRate.Location = new System.Drawing.Point(147, 62);
            this.ComboBoxSampleRate.Name = "ComboBoxSampleRate";
            this.ComboBoxSampleRate.Size = new System.Drawing.Size(131, 29);
            this.ComboBoxSampleRate.TabIndex = 6;
            this.ComboBoxSampleRate.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.CheckBoxAUP);
            this.metroPanel2.Controls.Add(this.CheckBoxGNDA);
            this.metroPanel2.Controls.Add(this.LabelMinAV);
            this.metroPanel2.Controls.Add(this.LabelMinA);
            this.metroPanel2.Controls.Add(this.LabelOffsetA);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.TrackBarOffsetA);
            this.metroPanel2.Controls.Add(this.metroPanel5);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.LabelGainA);
            this.metroPanel2.Controls.Add(this.TrackBarGainA);
            this.metroPanel2.Controls.Add(this.LabelRMSAV);
            this.metroPanel2.Controls.Add(this.LabelFreqAV);
            this.metroPanel2.Controls.Add(this.LabelMaxAV);
            this.metroPanel2.Controls.Add(this.LabelRMSA);
            this.metroPanel2.Controls.Add(this.LabelMaxA);
            this.metroPanel2.Controls.Add(this.LabelFreqA);
            this.metroPanel2.Controls.Add(this.ToggleA);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.ForeColor = System.Drawing.Color.Coral;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(950, 215);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(281, 202);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 14;
            // 
            // CheckBoxAUP
            // 
            this.CheckBoxAUP.AutoSize = true;
            this.CheckBoxAUP.Location = new System.Drawing.Point(224, 135);
            this.CheckBoxAUP.Name = "CheckBoxAUP";
            this.CheckBoxAUP.Size = new System.Drawing.Size(38, 15);
            this.CheckBoxAUP.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBoxAUP.TabIndex = 37;
            this.CheckBoxAUP.Text = "UP";
            this.CheckBoxAUP.UseSelectable = true;
            this.CheckBoxAUP.CheckedChanged += new System.EventHandler(this.CheckBoxAUP_CheckedChanged);
            // 
            // CheckBoxGNDA
            // 
            this.CheckBoxGNDA.AutoSize = true;
            this.CheckBoxGNDA.Location = new System.Drawing.Point(224, 114);
            this.CheckBoxGNDA.Name = "CheckBoxGNDA";
            this.CheckBoxGNDA.Size = new System.Drawing.Size(48, 15);
            this.CheckBoxGNDA.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBoxGNDA.TabIndex = 36;
            this.CheckBoxGNDA.Text = "GND";
            this.CheckBoxGNDA.UseSelectable = true;
            this.CheckBoxGNDA.CheckedChanged += new System.EventHandler(this.CheckBoxGNDA_CheckedChanged);
            // 
            // LabelMinAV
            // 
            this.LabelMinAV.AutoSize = true;
            this.LabelMinAV.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelMinAV.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelMinAV.Location = new System.Drawing.Point(122, 132);
            this.LabelMinAV.Name = "LabelMinAV";
            this.LabelMinAV.Size = new System.Drawing.Size(49, 19);
            this.LabelMinAV.TabIndex = 35;
            this.LabelMinAV.Text = "0.00 V";
            this.LabelMinAV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelMinAV.UseCustomBackColor = true;
            this.LabelMinAV.UseCustomForeColor = true;
            // 
            // LabelMinA
            // 
            this.LabelMinA.AutoSize = true;
            this.LabelMinA.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelMinA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelMinA.Location = new System.Drawing.Point(14, 132);
            this.LabelMinA.Name = "LabelMinA";
            this.LabelMinA.Size = new System.Drawing.Size(36, 19);
            this.LabelMinA.TabIndex = 34;
            this.LabelMinA.Text = "MIN";
            this.LabelMinA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMinA.UseCustomBackColor = true;
            this.LabelMinA.UseCustomForeColor = true;
            // 
            // LabelOffsetA
            // 
            this.LabelOffsetA.AutoSize = true;
            this.LabelOffsetA.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelOffsetA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelOffsetA.Location = new System.Drawing.Point(198, 71);
            this.LabelOffsetA.Name = "LabelOffsetA";
            this.LabelOffsetA.Size = new System.Drawing.Size(30, 19);
            this.LabelOffsetA.TabIndex = 32;
            this.LabelOffsetA.Text = "0 V";
            this.LabelOffsetA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelOffsetA.UseCustomBackColor = true;
            this.LabelOffsetA.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.metroLabel7.Location = new System.Drawing.Point(9, 71);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "ĐIỆN ÁP BÙ";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // TrackBarOffsetA
            // 
            this.TrackBarOffsetA.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarOffsetA.LargeChange = 1;
            this.TrackBarOffsetA.Location = new System.Drawing.Point(14, 95);
            this.TrackBarOffsetA.Maximum = 255;
            this.TrackBarOffsetA.Name = "TrackBarOffsetA";
            this.TrackBarOffsetA.Size = new System.Drawing.Size(258, 12);
            this.TrackBarOffsetA.TabIndex = 30;
            this.TrackBarOffsetA.Text = "TrackBarOffsetA";
            this.TrackBarOffsetA.Value = 0;
            this.TrackBarOffsetA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarOffsetA_Scroll);
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.RadioButtonX10A);
            this.metroPanel5.Controls.Add(this.RadioButtonX1A);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(76, 2);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(116, 26);
            this.metroPanel5.TabIndex = 15;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // RadioButtonX10A
            // 
            this.RadioButtonX10A.AutoSize = true;
            this.RadioButtonX10A.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RadioButtonX10A.Location = new System.Drawing.Point(60, 3);
            this.RadioButtonX10A.Name = "RadioButtonX10A";
            this.RadioButtonX10A.Size = new System.Drawing.Size(49, 19);
            this.RadioButtonX10A.Style = MetroFramework.MetroColorStyle.Blue;
            this.RadioButtonX10A.TabIndex = 28;
            this.RadioButtonX10A.Text = "X10";
            this.RadioButtonX10A.UseSelectable = true;
            // 
            // RadioButtonX1A
            // 
            this.RadioButtonX1A.AutoSize = true;
            this.RadioButtonX1A.Checked = true;
            this.RadioButtonX1A.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RadioButtonX1A.Location = new System.Drawing.Point(3, 3);
            this.RadioButtonX1A.Name = "RadioButtonX1A";
            this.RadioButtonX1A.Size = new System.Drawing.Size(41, 19);
            this.RadioButtonX1A.Style = MetroFramework.MetroColorStyle.Blue;
            this.RadioButtonX1A.TabIndex = 27;
            this.RadioButtonX1A.TabStop = true;
            this.RadioButtonX1A.Text = "X1";
            this.RadioButtonX1A.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.metroLabel1.Location = new System.Drawing.Point(14, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "KHUYẾCH ĐẠI";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // LabelGainA
            // 
            this.LabelGainA.AutoSize = true;
            this.LabelGainA.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelGainA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelGainA.Location = new System.Drawing.Point(198, 31);
            this.LabelGainA.Name = "LabelGainA";
            this.LabelGainA.Size = new System.Drawing.Size(43, 19);
            this.LabelGainA.TabIndex = 26;
            this.LabelGainA.Text = "1/1 V";
            this.LabelGainA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelGainA.UseCustomBackColor = true;
            this.LabelGainA.UseCustomForeColor = true;
            // 
            // TrackBarGainA
            // 
            this.TrackBarGainA.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarGainA.LargeChange = 1;
            this.TrackBarGainA.Location = new System.Drawing.Point(14, 53);
            this.TrackBarGainA.Maximum = 64;
            this.TrackBarGainA.Minimum = 1;
            this.TrackBarGainA.Name = "TrackBarGainA";
            this.TrackBarGainA.Size = new System.Drawing.Size(258, 12);
            this.TrackBarGainA.TabIndex = 25;
            this.TrackBarGainA.Text = "TrackBarGainA";
            this.TrackBarGainA.Value = 1;
            this.TrackBarGainA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarGainA_Scroll);
            // 
            // LabelRMSAV
            // 
            this.LabelRMSAV.AutoSize = true;
            this.LabelRMSAV.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelRMSAV.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelRMSAV.Location = new System.Drawing.Point(121, 154);
            this.LabelRMSAV.Name = "LabelRMSAV";
            this.LabelRMSAV.Size = new System.Drawing.Size(49, 19);
            this.LabelRMSAV.TabIndex = 24;
            this.LabelRMSAV.Text = "0.00 V";
            this.LabelRMSAV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelRMSAV.UseCustomBackColor = true;
            this.LabelRMSAV.UseCustomForeColor = true;
            // 
            // LabelFreqAV
            // 
            this.LabelFreqAV.AutoSize = true;
            this.LabelFreqAV.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelFreqAV.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelFreqAV.Location = new System.Drawing.Point(121, 178);
            this.LabelFreqAV.Name = "LabelFreqAV";
            this.LabelFreqAV.Size = new System.Drawing.Size(37, 19);
            this.LabelFreqAV.TabIndex = 23;
            this.LabelFreqAV.Text = "0 Hz";
            this.LabelFreqAV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelFreqAV.UseCustomBackColor = true;
            this.LabelFreqAV.UseCustomForeColor = true;
            // 
            // LabelMaxAV
            // 
            this.LabelMaxAV.AutoSize = true;
            this.LabelMaxAV.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelMaxAV.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelMaxAV.Location = new System.Drawing.Point(121, 110);
            this.LabelMaxAV.Name = "LabelMaxAV";
            this.LabelMaxAV.Size = new System.Drawing.Size(49, 19);
            this.LabelMaxAV.TabIndex = 22;
            this.LabelMaxAV.Text = "0.00 V";
            this.LabelMaxAV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelMaxAV.UseCustomBackColor = true;
            this.LabelMaxAV.UseCustomForeColor = true;
            // 
            // LabelRMSA
            // 
            this.LabelRMSA.AutoSize = true;
            this.LabelRMSA.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelRMSA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelRMSA.Location = new System.Drawing.Point(14, 154);
            this.LabelRMSA.Name = "LabelRMSA";
            this.LabelRMSA.Size = new System.Drawing.Size(84, 19);
            this.LabelRMSA.TabIndex = 17;
            this.LabelRMSA.Text = "HIỆU DỤNG";
            this.LabelRMSA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelRMSA.UseCustomBackColor = true;
            this.LabelRMSA.UseCustomForeColor = true;
            // 
            // LabelMaxA
            // 
            this.LabelMaxA.AutoSize = true;
            this.LabelMaxA.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelMaxA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelMaxA.Location = new System.Drawing.Point(14, 110);
            this.LabelMaxA.Name = "LabelMaxA";
            this.LabelMaxA.Size = new System.Drawing.Size(39, 19);
            this.LabelMaxA.TabIndex = 15;
            this.LabelMaxA.Text = "MAX";
            this.LabelMaxA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMaxA.UseCustomBackColor = true;
            this.LabelMaxA.UseCustomForeColor = true;
            // 
            // LabelFreqA
            // 
            this.LabelFreqA.AutoSize = true;
            this.LabelFreqA.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelFreqA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelFreqA.Location = new System.Drawing.Point(14, 178);
            this.LabelFreqA.Name = "LabelFreqA";
            this.LabelFreqA.Size = new System.Drawing.Size(57, 19);
            this.LabelFreqA.TabIndex = 16;
            this.LabelFreqA.Text = "TẦN SỐ";
            this.LabelFreqA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelFreqA.UseCustomBackColor = true;
            this.LabelFreqA.UseCustomForeColor = true;
            // 
            // ToggleA
            // 
            this.ToggleA.AutoSize = true;
            this.ToggleA.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToggleA.Checked = true;
            this.ToggleA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToggleA.Cursor = System.Windows.Forms.Cursors.Default;
            this.ToggleA.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ToggleA.Location = new System.Drawing.Point(197, 5);
            this.ToggleA.Name = "ToggleA";
            this.ToggleA.Size = new System.Drawing.Size(80, 17);
            this.ToggleA.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToggleA.TabIndex = 6;
            this.ToggleA.Text = "On";
            this.ToggleA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToggleA.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ToggleA.UseCustomBackColor = true;
            this.ToggleA.UseCustomForeColor = true;
            this.ToggleA.UseSelectable = true;
            this.ToggleA.CheckedChanged += new System.EventHandler(this.ToggleA_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel2.Location = new System.Drawing.Point(7, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "KÊNH A";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.CheckBoxBUP);
            this.metroPanel3.Controls.Add(this.CheckBoxGNDB);
            this.metroPanel3.Controls.Add(this.LabelMinBV);
            this.metroPanel3.Controls.Add(this.metroLabel13);
            this.metroPanel3.Controls.Add(this.LabelOffsetB);
            this.metroPanel3.Controls.Add(this.metroLabel9);
            this.metroPanel3.Controls.Add(this.TrackBarOffsetB);
            this.metroPanel3.Controls.Add(this.metroPanel6);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.LabelGainB);
            this.metroPanel3.Controls.Add(this.TrackBarGainB);
            this.metroPanel3.Controls.Add(this.LabelRMSBV);
            this.metroPanel3.Controls.Add(this.LabelFreqBV);
            this.metroPanel3.Controls.Add(this.LabelMaxBV);
            this.metroPanel3.Controls.Add(this.LabelRMSB);
            this.metroPanel3.Controls.Add(this.LabelFreqB);
            this.metroPanel3.Controls.Add(this.LabelAmpB);
            this.metroPanel3.Controls.Add(this.ToggleB);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.ForeColor = System.Drawing.Color.Coral;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(950, 423);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(281, 212);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.UseCustomForeColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 14;
            // 
            // CheckBoxBUP
            // 
            this.CheckBoxBUP.AutoSize = true;
            this.CheckBoxBUP.Location = new System.Drawing.Point(224, 135);
            this.CheckBoxBUP.Name = "CheckBoxBUP";
            this.CheckBoxBUP.Size = new System.Drawing.Size(38, 15);
            this.CheckBoxBUP.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBoxBUP.TabIndex = 39;
            this.CheckBoxBUP.Text = "UP";
            this.CheckBoxBUP.UseSelectable = true;
            this.CheckBoxBUP.CheckedChanged += new System.EventHandler(this.CheckBoxBUP_CheckedChanged);
            // 
            // CheckBoxGNDB
            // 
            this.CheckBoxGNDB.AutoSize = true;
            this.CheckBoxGNDB.Location = new System.Drawing.Point(224, 112);
            this.CheckBoxGNDB.Name = "CheckBoxGNDB";
            this.CheckBoxGNDB.Size = new System.Drawing.Size(48, 15);
            this.CheckBoxGNDB.Style = MetroFramework.MetroColorStyle.Red;
            this.CheckBoxGNDB.TabIndex = 38;
            this.CheckBoxGNDB.Text = "GND";
            this.CheckBoxGNDB.UseSelectable = true;
            this.CheckBoxGNDB.CheckedChanged += new System.EventHandler(this.CheckBoxGNDB_CheckedChanged);
            // 
            // LabelMinBV
            // 
            this.LabelMinBV.AutoSize = true;
            this.LabelMinBV.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelMinBV.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelMinBV.Location = new System.Drawing.Point(124, 133);
            this.LabelMinBV.Name = "LabelMinBV";
            this.LabelMinBV.Size = new System.Drawing.Size(49, 19);
            this.LabelMinBV.TabIndex = 37;
            this.LabelMinBV.Text = "0.00 V";
            this.LabelMinBV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelMinBV.UseCustomBackColor = true;
            this.LabelMinBV.UseCustomForeColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.metroLabel13.Location = new System.Drawing.Point(14, 133);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(36, 19);
            this.metroLabel13.TabIndex = 36;
            this.metroLabel13.Text = "MIN";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // LabelOffsetB
            // 
            this.LabelOffsetB.AutoSize = true;
            this.LabelOffsetB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelOffsetB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelOffsetB.Location = new System.Drawing.Point(193, 68);
            this.LabelOffsetB.Name = "LabelOffsetB";
            this.LabelOffsetB.Size = new System.Drawing.Size(30, 19);
            this.LabelOffsetB.TabIndex = 34;
            this.LabelOffsetB.Text = "0 V";
            this.LabelOffsetB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelOffsetB.UseCustomBackColor = true;
            this.LabelOffsetB.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.metroLabel9.Location = new System.Drawing.Point(14, 68);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(83, 19);
            this.metroLabel9.TabIndex = 33;
            this.metroLabel9.Text = "ĐIỆN ÁP BÙ";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // TrackBarOffsetB
            // 
            this.TrackBarOffsetB.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarOffsetB.LargeChange = 1;
            this.TrackBarOffsetB.Location = new System.Drawing.Point(14, 92);
            this.TrackBarOffsetB.Maximum = 255;
            this.TrackBarOffsetB.Name = "TrackBarOffsetB";
            this.TrackBarOffsetB.Size = new System.Drawing.Size(258, 11);
            this.TrackBarOffsetB.TabIndex = 32;
            this.TrackBarOffsetB.Text = "TrackBarOffsetB";
            this.TrackBarOffsetB.Value = 0;
            this.TrackBarOffsetB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarOffsetB_Scroll);
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.RadioButtonX10B);
            this.metroPanel6.Controls.Add(this.RadioButtonX1B);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(78, 2);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(116, 26);
            this.metroPanel6.TabIndex = 16;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // RadioButtonX10B
            // 
            this.RadioButtonX10B.AutoSize = true;
            this.RadioButtonX10B.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RadioButtonX10B.Location = new System.Drawing.Point(60, 4);
            this.RadioButtonX10B.Name = "RadioButtonX10B";
            this.RadioButtonX10B.Size = new System.Drawing.Size(49, 19);
            this.RadioButtonX10B.Style = MetroFramework.MetroColorStyle.Red;
            this.RadioButtonX10B.TabIndex = 30;
            this.RadioButtonX10B.Text = "X10";
            this.RadioButtonX10B.UseSelectable = true;
            // 
            // RadioButtonX1B
            // 
            this.RadioButtonX1B.AutoSize = true;
            this.RadioButtonX1B.Checked = true;
            this.RadioButtonX1B.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RadioButtonX1B.Location = new System.Drawing.Point(3, 3);
            this.RadioButtonX1B.Name = "RadioButtonX1B";
            this.RadioButtonX1B.Size = new System.Drawing.Size(41, 19);
            this.RadioButtonX1B.Style = MetroFramework.MetroColorStyle.Red;
            this.RadioButtonX1B.TabIndex = 29;
            this.RadioButtonX1B.TabStop = true;
            this.RadioButtonX1B.Text = "X1";
            this.RadioButtonX1B.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.metroLabel5.Location = new System.Drawing.Point(14, 32);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "KHUYẾCH ĐẠI";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // LabelGainB
            // 
            this.LabelGainB.AutoSize = true;
            this.LabelGainB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelGainB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelGainB.Location = new System.Drawing.Point(193, 34);
            this.LabelGainB.Name = "LabelGainB";
            this.LabelGainB.Size = new System.Drawing.Size(43, 19);
            this.LabelGainB.TabIndex = 28;
            this.LabelGainB.Text = "1/1 V";
            this.LabelGainB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelGainB.UseCustomBackColor = true;
            this.LabelGainB.UseCustomForeColor = true;
            // 
            // TrackBarGainB
            // 
            this.TrackBarGainB.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarGainB.LargeChange = 1;
            this.TrackBarGainB.Location = new System.Drawing.Point(14, 54);
            this.TrackBarGainB.Maximum = 64;
            this.TrackBarGainB.Minimum = 1;
            this.TrackBarGainB.Name = "TrackBarGainB";
            this.TrackBarGainB.Size = new System.Drawing.Size(258, 11);
            this.TrackBarGainB.TabIndex = 27;
            this.TrackBarGainB.Text = "TrackBarGainB";
            this.TrackBarGainB.Value = 1;
            this.TrackBarGainB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarGainB_Scroll);
            // 
            // LabelRMSBV
            // 
            this.LabelRMSBV.AutoSize = true;
            this.LabelRMSBV.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelRMSBV.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelRMSBV.Location = new System.Drawing.Point(124, 158);
            this.LabelRMSBV.Name = "LabelRMSBV";
            this.LabelRMSBV.Size = new System.Drawing.Size(49, 19);
            this.LabelRMSBV.TabIndex = 21;
            this.LabelRMSBV.Text = "0.00 V";
            this.LabelRMSBV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelRMSBV.UseCustomBackColor = true;
            this.LabelRMSBV.UseCustomForeColor = true;
            // 
            // LabelFreqBV
            // 
            this.LabelFreqBV.AutoSize = true;
            this.LabelFreqBV.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelFreqBV.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelFreqBV.Location = new System.Drawing.Point(123, 181);
            this.LabelFreqBV.Name = "LabelFreqBV";
            this.LabelFreqBV.Size = new System.Drawing.Size(37, 19);
            this.LabelFreqBV.TabIndex = 20;
            this.LabelFreqBV.Text = "0 Hz";
            this.LabelFreqBV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelFreqBV.UseCustomBackColor = true;
            this.LabelFreqBV.UseCustomForeColor = true;
            // 
            // LabelMaxBV
            // 
            this.LabelMaxBV.AutoSize = true;
            this.LabelMaxBV.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelMaxBV.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelMaxBV.Location = new System.Drawing.Point(124, 108);
            this.LabelMaxBV.Name = "LabelMaxBV";
            this.LabelMaxBV.Size = new System.Drawing.Size(49, 19);
            this.LabelMaxBV.TabIndex = 19;
            this.LabelMaxBV.Text = "0.00 V";
            this.LabelMaxBV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelMaxBV.UseCustomBackColor = true;
            this.LabelMaxBV.UseCustomForeColor = true;
            // 
            // LabelRMSB
            // 
            this.LabelRMSB.AutoSize = true;
            this.LabelRMSB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelRMSB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelRMSB.Location = new System.Drawing.Point(14, 158);
            this.LabelRMSB.Name = "LabelRMSB";
            this.LabelRMSB.Size = new System.Drawing.Size(84, 19);
            this.LabelRMSB.TabIndex = 18;
            this.LabelRMSB.Text = "HIỆU DỤNG";
            this.LabelRMSB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelRMSB.UseCustomBackColor = true;
            this.LabelRMSB.UseCustomForeColor = true;
            // 
            // LabelFreqB
            // 
            this.LabelFreqB.AutoSize = true;
            this.LabelFreqB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelFreqB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelFreqB.Location = new System.Drawing.Point(14, 181);
            this.LabelFreqB.Name = "LabelFreqB";
            this.LabelFreqB.Size = new System.Drawing.Size(57, 19);
            this.LabelFreqB.TabIndex = 14;
            this.LabelFreqB.Text = "TẦN SỐ";
            this.LabelFreqB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelFreqB.UseCustomBackColor = true;
            this.LabelFreqB.UseCustomForeColor = true;
            // 
            // LabelAmpB
            // 
            this.LabelAmpB.AutoSize = true;
            this.LabelAmpB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelAmpB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelAmpB.Location = new System.Drawing.Point(14, 106);
            this.LabelAmpB.Name = "LabelAmpB";
            this.LabelAmpB.Size = new System.Drawing.Size(39, 19);
            this.LabelAmpB.TabIndex = 13;
            this.LabelAmpB.Text = "MAX";
            this.LabelAmpB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAmpB.UseCustomBackColor = true;
            this.LabelAmpB.UseCustomForeColor = true;
            // 
            // ToggleB
            // 
            this.ToggleB.AutoSize = true;
            this.ToggleB.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToggleB.Checked = true;
            this.ToggleB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToggleB.Cursor = System.Windows.Forms.Cursors.Default;
            this.ToggleB.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ToggleB.Location = new System.Drawing.Point(195, 6);
            this.ToggleB.Name = "ToggleB";
            this.ToggleB.Size = new System.Drawing.Size(80, 17);
            this.ToggleB.Style = MetroFramework.MetroColorStyle.Red;
            this.ToggleB.TabIndex = 6;
            this.ToggleB.Text = "On";
            this.ToggleB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToggleB.UseCustomBackColor = true;
            this.ToggleB.UseCustomForeColor = true;
            this.ToggleB.UseSelectable = true;
            this.ToggleB.CheckedChanged += new System.EventHandler(this.ToggleB_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel8.Location = new System.Drawing.Point(8, 6);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "KÊNH B";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // ButtonStartStop
            // 
            this.ButtonStartStop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonStartStop.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonStartStop.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonStartStop.Location = new System.Drawing.Point(948, 641);
            this.ButtonStartStop.Name = "ButtonStartStop";
            this.ButtonStartStop.Size = new System.Drawing.Size(96, 40);
            this.ButtonStartStop.Style = MetroFramework.MetroColorStyle.Blue;
            this.ButtonStartStop.TabIndex = 7;
            this.ButtonStartStop.Text = "KẾT NỐI";
            this.ButtonStartStop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ButtonStartStop.UseCustomBackColor = true;
            this.ButtonStartStop.UseCustomForeColor = true;
            this.ButtonStartStop.UseSelectable = true;
            this.ButtonStartStop.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonCapture
            // 
            this.ButtonCapture.Enabled = false;
            this.ButtonCapture.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonCapture.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonCapture.Location = new System.Drawing.Point(1053, 641);
            this.ButtonCapture.Name = "ButtonCapture";
            this.ButtonCapture.Size = new System.Drawing.Size(86, 40);
            this.ButtonCapture.Style = MetroFramework.MetroColorStyle.Blue;
            this.ButtonCapture.TabIndex = 8;
            this.ButtonCapture.Text = "LẤY MẪU";
            this.ButtonCapture.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ButtonCapture.UseCustomBackColor = true;
            this.ButtonCapture.UseCustomForeColor = true;
            this.ButtonCapture.UseSelectable = true;
            this.ButtonCapture.Click += new System.EventHandler(this.ButtonCapture_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pacifico", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(305, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mô hình USB Oscilloscope";
            // 
            // TextBoxRawData
            // 
            this.TextBoxRawData.Location = new System.Drawing.Point(948, 11);
            this.TextBoxRawData.Multiline = true;
            this.TextBoxRawData.Name = "TextBoxRawData";
            this.TextBoxRawData.Size = new System.Drawing.Size(129, 70);
            this.TextBoxRawData.TabIndex = 12;
            this.TextBoxRawData.Visible = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonSave.Location = new System.Drawing.Point(1145, 641);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(86, 40);
            this.ButtonSave.Style = MetroFramework.MetroColorStyle.Blue;
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "LƯU LẠI";
            this.ButtonSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ButtonSave.UseCustomBackColor = true;
            this.ButtonSave.UseCustomForeColor = true;
            this.ButtonSave.UseSelectable = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Log
            // 
            // 
            // 
            // 
            this.Log.CustomButton.Image = null;
            this.Log.CustomButton.Location = new System.Drawing.Point(58, 2);
            this.Log.CustomButton.Name = "";
            this.Log.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Log.CustomButton.TabIndex = 1;
            this.Log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Log.CustomButton.UseSelectable = true;
            this.Log.CustomButton.Visible = false;
            this.Log.Lines = new string[] {
        "Command"};
            this.Log.Location = new System.Drawing.Point(5, 24);
            this.Log.MaxLength = 32767;
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.PasswordChar = '\0';
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Log.SelectedText = "";
            this.Log.SelectionLength = 0;
            this.Log.SelectionStart = 0;
            this.Log.ShortcutsEnabled = true;
            this.Log.Size = new System.Drawing.Size(78, 22);
            this.Log.TabIndex = 23;
            this.Log.Text = "Command";
            this.Log.UseSelectable = true;
            this.Log.Visible = false;
            this.Log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Log.WaterMarkFont = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 700);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxRawData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonCapture);
            this.Controls.Add(this.ButtonStartStop);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox ComboboxCOM;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox ComboBoxSampleRate;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle ToggleA;
        private MetroFramework.Controls.MetroLabel LabelConnect;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroToggle ToggleB;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton ButtonStartStop;
        private MetroFramework.Controls.MetroButton ButtonCapture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.Windows.Forms.TextBox TextBoxRawData;
        private MetroFramework.Controls.MetroLabel LabelFreqA;
        private MetroFramework.Controls.MetroLabel LabelMaxA;
        private MetroFramework.Controls.MetroLabel LabelFreqB;
        private MetroFramework.Controls.MetroLabel LabelAmpB;
        private MetroFramework.Controls.MetroLabel LabelRMSA;
        private MetroFramework.Controls.MetroLabel LabelRMSB;
        private MetroFramework.Controls.MetroLabel LabelRMSAV;
        private MetroFramework.Controls.MetroLabel LabelFreqAV;
        private MetroFramework.Controls.MetroLabel LabelMaxAV;
        private MetroFramework.Controls.MetroLabel LabelRMSBV;
        private MetroFramework.Controls.MetroLabel LabelFreqBV;
        private MetroFramework.Controls.MetroLabel LabelMaxBV;
        private MetroFramework.Controls.MetroButton ButtonSave;
        private MetroFramework.Controls.MetroLabel LabelGainA;
        private MetroFramework.Controls.MetroTrackBar TrackBarGainA;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton RadioButtonX10A;
        private MetroFramework.Controls.MetroRadioButton RadioButtonX1A;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroRadioButton RadioButtonX10B;
        private MetroFramework.Controls.MetroRadioButton RadioButtonX1B;
        private MetroFramework.Controls.MetroLabel LabelGainB;
        private MetroFramework.Controls.MetroTrackBar TrackBarGainB;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroRadioButton RadioButtonRepeat;
        private MetroFramework.Controls.MetroRadioButton RadioButtonOnce;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTrackBar TrackBarOffsetA;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTrackBar TrackBarOffsetB;
        private MetroFramework.Controls.MetroLabel LabelOffsetA;
        private MetroFramework.Controls.MetroLabel LabelOffsetB;
        private MetroFramework.Controls.MetroTextBox Log;
        private MetroFramework.Controls.MetroLabel LabelMinAV;
        private MetroFramework.Controls.MetroLabel LabelMinA;
        private MetroFramework.Controls.MetroLabel LabelMinBV;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroCheckBox CheckBoxGNDA;
        private MetroFramework.Controls.MetroCheckBox CheckBoxGNDB;
        private MetroFramework.Controls.MetroCheckBox CheckBoxAUP;
        private MetroFramework.Controls.MetroCheckBox CheckBoxBUP;
    }
}

