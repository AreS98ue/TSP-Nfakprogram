namespace DronV1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtboxBrojKlijenata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrojKlijenata = new System.Windows.Forms.Button();
            this.txtboxXza1 = new System.Windows.Forms.TextBox();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.lblYza1 = new System.Windows.Forms.Label();
            this.txtboxYza1 = new System.Windows.Forms.TextBox();
            this.lblXza1 = new System.Windows.Forms.Label();
            this.txtBoxPutanja = new System.Windows.Forms.TextBox();
            this.txtBoxDistanca = new System.Windows.Forms.TextBox();
            this.txtBoxKordinate = new System.Windows.Forms.TextBox();
            this.txtBoxDuzinaSvakePutanje = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxPutanja2 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxBrojKlijenata
            // 
            this.txtboxBrojKlijenata.Location = new System.Drawing.Point(110, 56);
            this.txtboxBrojKlijenata.Name = "txtboxBrojKlijenata";
            this.txtboxBrojKlijenata.Size = new System.Drawing.Size(29, 20);
            this.txtboxBrojKlijenata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj gradova";
            // 
            // btnBrojKlijenata
            // 
            this.btnBrojKlijenata.Location = new System.Drawing.Point(251, 42);
            this.btnBrojKlijenata.Name = "btnBrojKlijenata";
            this.btnBrojKlijenata.Size = new System.Drawing.Size(75, 23);
            this.btnBrojKlijenata.TabIndex = 2;
            this.btnBrojKlijenata.Text = "Potvrdi";
            this.btnBrojKlijenata.UseVisualStyleBackColor = true;
            this.btnBrojKlijenata.Click += new System.EventHandler(this.btnBrojKlijenata_Click);
            // 
            // txtboxXza1
            // 
            this.txtboxXza1.Location = new System.Drawing.Point(47, 19);
            this.txtboxXza1.Name = "txtboxXza1";
            this.txtboxXza1.Size = new System.Drawing.Size(31, 20);
            this.txtboxXza1.TabIndex = 3;
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.lblYza1);
            this.grpBox1.Controls.Add(this.txtboxYza1);
            this.grpBox1.Controls.Add(this.lblXza1);
            this.grpBox1.Controls.Add(this.txtboxXza1);
            this.grpBox1.Controls.Add(this.txtboxBrojKlijenata);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Location = new System.Drawing.Point(12, 29);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(194, 94);
            this.grpBox1.TabIndex = 4;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Pozicija pocetne tacke";
            // 
            // lblYza1
            // 
            this.lblYza1.AutoSize = true;
            this.lblYza1.Location = new System.Drawing.Point(107, 23);
            this.lblYza1.Name = "lblYza1";
            this.lblYza1.Size = new System.Drawing.Size(32, 13);
            this.lblYza1.TabIndex = 6;
            this.lblYza1.Text = "y osa";
            // 
            // txtboxYza1
            // 
            this.txtboxYza1.Location = new System.Drawing.Point(146, 19);
            this.txtboxYza1.Name = "txtboxYza1";
            this.txtboxYza1.Size = new System.Drawing.Size(31, 20);
            this.txtboxYza1.TabIndex = 5;
            // 
            // lblXza1
            // 
            this.lblXza1.AutoSize = true;
            this.lblXza1.Location = new System.Drawing.Point(8, 23);
            this.lblXza1.Name = "lblXza1";
            this.lblXza1.Size = new System.Drawing.Size(32, 13);
            this.lblXza1.TabIndex = 4;
            this.lblXza1.Text = "x osa";
            // 
            // txtBoxPutanja
            // 
            this.txtBoxPutanja.Location = new System.Drawing.Point(228, 153);
            this.txtBoxPutanja.Name = "txtBoxPutanja";
            this.txtBoxPutanja.ReadOnly = true;
            this.txtBoxPutanja.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxPutanja.Size = new System.Drawing.Size(136, 20);
            this.txtBoxPutanja.TabIndex = 5;
            // 
            // txtBoxDistanca
            // 
            this.txtBoxDistanca.Location = new System.Drawing.Point(237, 235);
            this.txtBoxDistanca.Name = "txtBoxDistanca";
            this.txtBoxDistanca.ReadOnly = true;
            this.txtBoxDistanca.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxDistanca.Size = new System.Drawing.Size(118, 20);
            this.txtBoxDistanca.TabIndex = 6;
            // 
            // txtBoxKordinate
            // 
            this.txtBoxKordinate.Location = new System.Drawing.Point(12, 153);
            this.txtBoxKordinate.Multiline = true;
            this.txtBoxKordinate.Name = "txtBoxKordinate";
            this.txtBoxKordinate.ReadOnly = true;
            this.txtBoxKordinate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxKordinate.Size = new System.Drawing.Size(200, 107);
            this.txtBoxKordinate.TabIndex = 7;
            // 
            // txtBoxDuzinaSvakePutanje
            // 
            this.txtBoxDuzinaSvakePutanje.Location = new System.Drawing.Point(79, 296);
            this.txtBoxDuzinaSvakePutanje.Multiline = true;
            this.txtBoxDuzinaSvakePutanje.Name = "txtBoxDuzinaSvakePutanje";
            this.txtBoxDuzinaSvakePutanje.ReadOnly = true;
            this.txtBoxDuzinaSvakePutanje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxDuzinaSvakePutanje.Size = new System.Drawing.Size(206, 135);
            this.txtBoxDuzinaSvakePutanje.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(251, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Obrisi";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Najkraca putanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Duzina puta (u km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kordinate klijenata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sve moguce putanje \r\n(Prikazuje samo do 5 gradova)\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Najkraca putanja 2\r\n";
            // 
            // txtBoxPutanja2
            // 
            this.txtBoxPutanja2.Location = new System.Drawing.Point(228, 196);
            this.txtBoxPutanja2.Name = "txtBoxPutanja2";
            this.txtBoxPutanja2.ReadOnly = true;
            this.txtBoxPutanja2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxPutanja2.Size = new System.Drawing.Size(136, 20);
            this.txtBoxPutanja2.TabIndex = 15;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Putanja";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(600, 400);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(370, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 434);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Student: Mihailo Petrovic IN 13/17";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mentor: prof. dr Milovan Milivojevic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 464);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxPutanja2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBoxDuzinaSvakePutanje);
            this.Controls.Add(this.txtBoxKordinate);
            this.Controls.Add(this.txtBoxDistanca);
            this.Controls.Add(this.txtBoxPutanja);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.btnBrojKlijenata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ASSZS Klasicno n! resenje";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxBrojKlijenata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrojKlijenata;
        private System.Windows.Forms.TextBox txtboxXza1;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label lblYza1;
        private System.Windows.Forms.TextBox txtboxYza1;
        private System.Windows.Forms.Label lblXza1;
        private System.Windows.Forms.TextBox txtBoxPutanja;
        private System.Windows.Forms.TextBox txtBoxDistanca;
        private System.Windows.Forms.TextBox txtBoxKordinate;
        private System.Windows.Forms.TextBox txtBoxDuzinaSvakePutanje;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxPutanja2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

