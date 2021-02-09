namespace Obliczanie_spadków_napięć_w_sieciach_dystrybucyjnych
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StwKbl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lRL = new System.Windows.Forms.Label();
            this.lXL = new System.Windows.Forms.Label();
            this.numR0 = new System.Windows.Forms.NumericUpDown();
            this.numX0 = new System.Windows.Forms.NumericUpDown();
            this.numL = new System.Windows.Forms.NumericUpDown();
            this.numI = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numFi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lU = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numR0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // StwKbl
            // 
            this.StwKbl.Location = new System.Drawing.Point(13, 13);
            this.StwKbl.Name = "StwKbl";
            this.StwKbl.Size = new System.Drawing.Size(762, 23);
            this.StwKbl.TabIndex = 0;
            this.StwKbl.Text = "Start";
            this.StwKbl.UseVisualStyleBackColor = true;
            this.StwKbl.Click += new System.EventHandler(this.StwKbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R0 [Ω]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X0 [Ω]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Długość [km]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RL =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "XL =";
            // 
            // lRL
            // 
            this.lRL.AutoSize = true;
            this.lRL.Location = new System.Drawing.Point(94, 70);
            this.lRL.Name = "lRL";
            this.lRL.Size = new System.Drawing.Size(0, 13);
            this.lRL.TabIndex = 4;
            // 
            // lXL
            // 
            this.lXL.AutoSize = true;
            this.lXL.Location = new System.Drawing.Point(345, 70);
            this.lXL.Name = "lXL";
            this.lXL.Size = new System.Drawing.Size(0, 13);
            this.lXL.TabIndex = 4;
            // 
            // numR0
            // 
            this.numR0.DecimalPlaces = 4;
            this.numR0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numR0.Location = new System.Drawing.Point(13, 43);
            this.numR0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numR0.Name = "numR0";
            this.numR0.Size = new System.Drawing.Size(250, 20);
            this.numR0.TabIndex = 5;
            this.numR0.Value = new decimal(new int[] {
            253,
            0,
            0,
            196608});
            // 
            // numX0
            // 
            this.numX0.DecimalPlaces = 4;
            this.numX0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numX0.Location = new System.Drawing.Point(269, 43);
            this.numX0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numX0.Name = "numX0";
            this.numX0.Size = new System.Drawing.Size(250, 20);
            this.numX0.TabIndex = 5;
            // 
            // numL
            // 
            this.numL.DecimalPlaces = 4;
            this.numL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numL.Location = new System.Drawing.Point(525, 43);
            this.numL.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numL.Name = "numL";
            this.numL.Size = new System.Drawing.Size(250, 20);
            this.numL.TabIndex = 5;
            this.numL.Value = new decimal(new int[] {
            255,
            0,
            0,
            196608});
            // 
            // numI
            // 
            this.numI.DecimalPlaces = 3;
            this.numI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numI.Location = new System.Drawing.Point(269, 116);
            this.numI.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numI.Name = "numI";
            this.numI.Size = new System.Drawing.Size(250, 20);
            this.numI.TabIndex = 5;
            this.numI.Value = new decimal(new int[] {
            292,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 39);
            this.label6.TabIndex = 4;
            this.label6.Text = "Parametry Linii";
            // 
            // numFi
            // 
            this.numFi.DecimalPlaces = 2;
            this.numFi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numFi.Location = new System.Drawing.Point(525, 116);
            this.numFi.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFi.Name = "numFi";
            this.numFi.Size = new System.Drawing.Size(250, 20);
            this.numFi.TabIndex = 5;
            this.numFi.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Prąd [A]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "cos φ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "ΔU =";
            // 
            // lU
            // 
            this.lU.AutoSize = true;
            this.lU.Location = new System.Drawing.Point(54, 136);
            this.lU.Name = "lU";
            this.lU.Size = new System.Drawing.Size(0, 13);
            this.lU.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(12, 152);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(758, 300);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 459);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lU);
            this.Controls.Add(this.numL);
            this.Controls.Add(this.numX0);
            this.Controls.Add(this.numFi);
            this.Controls.Add(this.numI);
            this.Controls.Add(this.numR0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lXL);
            this.Controls.Add(this.lRL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StwKbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numR0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StwKbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lRL;
        private System.Windows.Forms.Label lXL;
        private System.Windows.Forms.NumericUpDown numR0;
        private System.Windows.Forms.NumericUpDown numX0;
        private System.Windows.Forms.NumericUpDown numL;
        private System.Windows.Forms.NumericUpDown numI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numFi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

