
namespace serial_servo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(24, 104);
            this.trackBar1.Maximum = 240;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(244, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = " servo angle (deg)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(33, 172);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "servo ID";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(366, 104);
            this.trackBar2.Maximum = 240;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(244, 56);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "duration (ms)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM26",
            "COM27",
            "COM28",
            "COM29",
            "COM30",
            "COM31",
            "COM32",
            "COM33",
            "COM34",
            "COM35",
            "COM36",
            "COM37",
            "COM38",
            "COM39",
            "COM40",
            "COM41",
            "COM42",
            "COM43",
            "COM44",
            "COM45",
            "COM46",
            "COM47",
            "COM48",
            "COM49",
            "COM50",
            "COM51",
            "COM52",
            "COM53",
            "COM54",
            "COM55",
            "COM56",
            "COM57",
            "COM58",
            "COM59",
            "COM60",
            "COM61",
            "COM62",
            "COM63",
            "COM64",
            "COM65",
            "COM66",
            "COM67",
            "COM68",
            "COM69",
            "COM70",
            "COM71",
            "COM72",
            "COM73",
            "COM74",
            "COM75",
            "COM76",
            "COM77",
            "COM78",
            "COM79",
            "COM80",
            "COM81",
            "COM82",
            "COM83",
            "COM84",
            "COM85",
            "COM86",
            "COM87",
            "COM88",
            "COM89",
            "COM90",
            "COM91",
            "COM92",
            "COM93",
            "COM94",
            "COM95",
            "COM96",
            "COM97",
            "COM98",
            "COM99",
            "COM100",
            "COM101",
            "COM102",
            "COM103",
            "COM104",
            "COM105",
            "COM106",
            "COM107",
            "COM108",
            "COM109",
            "COM110",
            "COM111",
            "COM112",
            "COM113",
            "COM114",
            "COM115",
            "COM116",
            "COM117",
            "COM118",
            "COM119",
            "COM120",
            "COM121",
            "COM122",
            "COM123",
            "COM124",
            "COM125",
            "COM126",
            "COM127",
            "COM128",
            "COM129",
            "COM130",
            "COM131",
            "COM132",
            "COM133",
            "COM134",
            "COM135",
            "COM136",
            "COM137",
            "COM138",
            "COM139",
            "COM140",
            "COM141",
            "COM142",
            "COM143",
            "COM144",
            "COM145",
            "COM146",
            "COM147",
            "COM148",
            "COM149",
            "COM150",
            "COM151",
            "COM152",
            "COM153",
            "COM154",
            "COM155",
            "COM156",
            "COM157",
            "COM158",
            "COM159",
            "COM160",
            "COM161",
            "COM162",
            "COM163",
            "COM164",
            "COM165",
            "COM166",
            "COM167",
            "COM168",
            "COM169",
            "COM170",
            "COM171",
            "COM172",
            "COM173",
            "COM174",
            "COM175",
            "COM176",
            "COM177",
            "COM178",
            "COM179",
            "COM180",
            "COM181",
            "COM182",
            "COM183",
            "COM184",
            "COM185",
            "COM186",
            "COM187",
            "COM188",
            "COM189",
            "COM190",
            "COM191",
            "COM192",
            "COM193",
            "COM194",
            "COM195",
            "COM196",
            "COM197",
            "COM198",
            "COM199",
            "COM200",
            "COM201",
            "COM202",
            "COM203",
            "COM204",
            "COM205",
            "COM206",
            "COM207",
            "COM208",
            "COM209",
            "COM210",
            "COM211",
            "COM212",
            "COM213",
            "COM214",
            "COM215",
            "COM216",
            "COM217",
            "COM218",
            "COM219",
            "COM220",
            "COM221",
            "COM222",
            "COM223",
            "COM224",
            "COM225",
            "COM226"});
            this.comboBox1.Location = new System.Drawing.Point(33, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Serial port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(503, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 27);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Disconnect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Serial port buffer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
    }
}

