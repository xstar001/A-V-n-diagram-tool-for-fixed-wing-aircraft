
namespace VnPlot
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_in_VgCr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_in_VgMaxInt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_in_VgDv = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_in_NMax = new System.Windows.Forms.TextBox();
            this.textBox_in_NMin = new System.Windows.Forms.TextBox();
            this.textBox_in_Cla = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_in_Vcr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_in_Vmax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_in_Chord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_in_Area = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_in_M = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_in_Rho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_in_CLmin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_in_CLMax = new System.Windows.Forms.TextBox();
            this.button_Compute = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.button_Copy = new System.Windows.Forms.Button();
            this.label_EMail = new System.Windows.Forms.Label();
            this.button_ExportOrg = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl_Output = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart_Vn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_SaveInput = new System.Windows.Forms.Button();
            this.button_LoadInput = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl_Output.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Vn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "+Lift coefficient (CLmax)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.textBox_in_Cla);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox_in_Vcr);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_in_Vmax);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_in_Chord);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_in_Area);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_in_M);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_in_Rho);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox_in_VgCr);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBox_in_VgMaxInt);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBox_in_VgDv);
            this.panel3.Location = new System.Drawing.Point(2, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 81);
            this.panel3.TabIndex = 9;
            // 
            // textBox_in_VgCr
            // 
            this.textBox_in_VgCr.Location = new System.Drawing.Point(250, 3);
            this.textBox_in_VgCr.Name = "textBox_in_VgCr";
            this.textBox_in_VgCr.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_VgCr.TabIndex = 19;
            this.textBox_in_VgCr.Text = "15.24";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(221, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "maximum gust intensity (m/s) [FAR23]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "Vgust for cruise (m/s) [FAR23]";
            // 
            // textBox_in_VgMaxInt
            // 
            this.textBox_in_VgMaxInt.Location = new System.Drawing.Point(250, 54);
            this.textBox_in_VgMaxInt.Name = "textBox_in_VgMaxInt";
            this.textBox_in_VgMaxInt.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_VgMaxInt.TabIndex = 27;
            this.textBox_in_VgMaxInt.Text = "20.11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "Vgust for dive (m/s) [FAR23]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "Vgust for design speed for ";
            // 
            // textBox_in_VgDv
            // 
            this.textBox_in_VgDv.Location = new System.Drawing.Point(250, 29);
            this.textBox_in_VgDv.Name = "textBox_in_VgDv";
            this.textBox_in_VgDv.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_VgDv.TabIndex = 21;
            this.textBox_in_VgDv.Text = "7.62";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_in_NMax);
            this.panel1.Controls.Add(this.textBox_in_NMin);
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 57);
            this.panel1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "- Load factor max (|Nmin|)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "+ Load factor max (Nmax)";
            // 
            // textBox_in_NMax
            // 
            this.textBox_in_NMax.Location = new System.Drawing.Point(253, 3);
            this.textBox_in_NMax.Name = "textBox_in_NMax";
            this.textBox_in_NMax.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_NMax.TabIndex = 3;
            this.textBox_in_NMax.Text = "3.8";
            // 
            // textBox_in_NMin
            // 
            this.textBox_in_NMin.Location = new System.Drawing.Point(253, 30);
            this.textBox_in_NMin.Name = "textBox_in_NMin";
            this.textBox_in_NMin.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_NMin.TabIndex = 5;
            this.textBox_in_NMin.Text = "2";
            // 
            // textBox_in_Cla
            // 
            this.textBox_in_Cla.Location = new System.Drawing.Point(254, 375);
            this.textBox_in_Cla.Name = "textBox_in_Cla";
            this.textBox_in_Cla.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_Cla.TabIndex = 25;
            this.textBox_in_Cla.Text = "5.87";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "Aircraft lift curve slope (1/rad)";
            // 
            // textBox_in_Vcr
            // 
            this.textBox_in_Vcr.Location = new System.Drawing.Point(254, 265);
            this.textBox_in_Vcr.Name = "textBox_in_Vcr";
            this.textBox_in_Vcr.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_Vcr.TabIndex = 23;
            this.textBox_in_Vcr.Text = "28";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "Cruise speed (m/s)";
            // 
            // textBox_in_Vmax
            // 
            this.textBox_in_Vmax.Location = new System.Drawing.Point(254, 126);
            this.textBox_in_Vmax.Name = "textBox_in_Vmax";
            this.textBox_in_Vmax.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_Vmax.TabIndex = 15;
            this.textBox_in_Vmax.Text = "61.1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dive (Max) air speed (m/s)";
            // 
            // textBox_in_Chord
            // 
            this.textBox_in_Chord.Location = new System.Drawing.Point(254, 98);
            this.textBox_in_Chord.Name = "textBox_in_Chord";
            this.textBox_in_Chord.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_Chord.TabIndex = 13;
            this.textBox_in_Chord.Text = "0.48";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Reference chord (m)";
            // 
            // textBox_in_Area
            // 
            this.textBox_in_Area.Location = new System.Drawing.Point(254, 70);
            this.textBox_in_Area.Name = "textBox_in_Area";
            this.textBox_in_Area.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_Area.TabIndex = 11;
            this.textBox_in_Area.Text = "2.8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Refernce area (m^2)";
            // 
            // textBox_in_M
            // 
            this.textBox_in_M.Location = new System.Drawing.Point(254, 42);
            this.textBox_in_M.Name = "textBox_in_M";
            this.textBox_in_M.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_M.TabIndex = 9;
            this.textBox_in_M.Text = "120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aircraft mass (kg)";
            // 
            // textBox_in_Rho
            // 
            this.textBox_in_Rho.Location = new System.Drawing.Point(254, 14);
            this.textBox_in_Rho.Name = "textBox_in_Rho";
            this.textBox_in_Rho.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_Rho.TabIndex = 7;
            this.textBox_in_Rho.Text = "1.112";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Air density (kg/m^3)";
            // 
            // textBox_in_CLmin
            // 
            this.textBox_in_CLmin.Location = new System.Drawing.Point(251, 31);
            this.textBox_in_CLmin.Name = "textBox_in_CLmin";
            this.textBox_in_CLmin.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_CLmin.TabIndex = 17;
            this.textBox_in_CLmin.Text = "0.8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "-Lift coefficient (|CLmin|)";
            // 
            // textBox_in_CLMax
            // 
            this.textBox_in_CLMax.Location = new System.Drawing.Point(251, 3);
            this.textBox_in_CLMax.Name = "textBox_in_CLMax";
            this.textBox_in_CLMax.Size = new System.Drawing.Size(100, 21);
            this.textBox_in_CLMax.TabIndex = 1;
            this.textBox_in_CLMax.Text = "1.3";
            // 
            // button_Compute
            // 
            this.button_Compute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Compute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Compute.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Compute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Compute.Location = new System.Drawing.Point(6, 414);
            this.button_Compute.Name = "button_Compute";
            this.button_Compute.Size = new System.Drawing.Size(75, 23);
            this.button_Compute.TabIndex = 3;
            this.button_Compute.Text = "Compute";
            this.button_Compute.UseVisualStyleBackColor = false;
            this.button_Compute.Click += new System.EventHandler(this.button_Compute_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Close.Location = new System.Drawing.Point(358, 414);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_Output
            // 
            this.textBox_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Output.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Output.Location = new System.Drawing.Point(6, 6);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Output.Size = new System.Drawing.Size(526, 340);
            this.textBox_Output.TabIndex = 5;
            // 
            // button_Copy
            // 
            this.button_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Copy.Enabled = false;
            this.button_Copy.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Copy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Copy.Location = new System.Drawing.Point(86, 414);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(75, 23);
            this.button_Copy.TabIndex = 6;
            this.button_Copy.Text = "Copy";
            this.button_Copy.UseVisualStyleBackColor = false;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // label_EMail
            // 
            this.label_EMail.AutoSize = true;
            this.label_EMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_EMail.ForeColor = System.Drawing.Color.Blue;
            this.label_EMail.Location = new System.Drawing.Point(703, 419);
            this.label_EMail.Name = "label_EMail";
            this.label_EMail.Size = new System.Drawing.Size(215, 12);
            this.label_EMail.TabIndex = 7;
            this.label_EMail.Text = "Vn-Diagram Calculator, By YuH, NWPU";
            this.label_EMail.Click += new System.EventHandler(this.label_EMail_Click);
            // 
            // button_ExportOrg
            // 
            this.button_ExportOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_ExportOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ExportOrg.Enabled = false;
            this.button_ExportOrg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ExportOrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_ExportOrg.Location = new System.Drawing.Point(197, 348);
            this.button_ExportOrg.Name = "button_ExportOrg";
            this.button_ExportOrg.Size = new System.Drawing.Size(123, 23);
            this.button_ExportOrg.TabIndex = 8;
            this.button_ExportOrg.Text = "Export origin";
            this.button_ExportOrg.UseVisualStyleBackColor = false;
            this.button_ExportOrg.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_in_CLMax);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox_in_CLmin);
            this.panel2.Location = new System.Drawing.Point(6, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 55);
            this.panel2.TabIndex = 9;
            // 
            // tabControl_Output
            // 
            this.tabControl_Output.Controls.Add(this.tabPage1);
            this.tabControl_Output.Controls.Add(this.tabPage2);
            this.tabControl_Output.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl_Output.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl_Output.Location = new System.Drawing.Point(378, 4);
            this.tabControl_Output.Name = "tabControl_Output";
            this.tabControl_Output.SelectedIndex = 0;
            this.tabControl_Output.Size = new System.Drawing.Size(544, 402);
            this.tabControl_Output.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.textBox_Output);
            this.tabPage1.Controls.Add(this.button_ExportOrg);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Export Origin Data";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.chart_Vn);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "V-n Diagram";
            // 
            // chart_Vn
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Vn.ChartAreas.Add(chartArea1);
            this.chart_Vn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart_Vn.Enabled = false;
            this.chart_Vn.Location = new System.Drawing.Point(6, 3);
            this.chart_Vn.Name = "chart_Vn";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart_Vn.Series.Add(series1);
            this.chart_Vn.Size = new System.Drawing.Size(525, 367);
            this.chart_Vn.TabIndex = 0;
            this.chart_Vn.Text = "V-n Diagram";
            // 
            // button_SaveInput
            // 
            this.button_SaveInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_SaveInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SaveInput.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SaveInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_SaveInput.Location = new System.Drawing.Point(166, 414);
            this.button_SaveInput.Name = "button_SaveInput";
            this.button_SaveInput.Size = new System.Drawing.Size(91, 23);
            this.button_SaveInput.TabIndex = 11;
            this.button_SaveInput.Text = "Save input";
            this.button_SaveInput.UseVisualStyleBackColor = false;
            this.button_SaveInput.Click += new System.EventHandler(this.button_SaveInput_Click);
            // 
            // button_LoadInput
            // 
            this.button_LoadInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_LoadInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_LoadInput.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_LoadInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_LoadInput.Location = new System.Drawing.Point(262, 414);
            this.button_LoadInput.Name = "button_LoadInput";
            this.button_LoadInput.Size = new System.Drawing.Size(91, 23);
            this.button_LoadInput.TabIndex = 12;
            this.button_LoadInput.Text = "Load input";
            this.button_LoadInput.UseVisualStyleBackColor = false;
            this.button_LoadInput.Click += new System.EventHandler(this.button_LoadInput_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(924, 442);
            this.Controls.Add(this.button_LoadInput);
            this.Controls.Add(this.button_SaveInput);
            this.Controls.Add(this.tabControl_Output);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_EMail);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Compute);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Vn Plot (Ver 2021.1024.1233)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl_Output.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Vn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_in_CLMax;
        private System.Windows.Forms.TextBox textBox_in_NMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_in_NMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_in_Rho;
        private System.Windows.Forms.TextBox textBox_in_M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_in_Area;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_in_Chord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_in_Vmax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_in_CLmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Compute;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TextBox textBox_in_VgCr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_in_VgDv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_in_Vcr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_in_Cla;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_in_VgMaxInt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Label label_EMail;
        private System.Windows.Forms.Button button_ExportOrg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl_Output;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Vn;
        private System.Windows.Forms.Button button_SaveInput;
        private System.Windows.Forms.Button button_LoadInput;
    }
}

