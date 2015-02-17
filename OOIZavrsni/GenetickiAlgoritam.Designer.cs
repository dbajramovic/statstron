namespace OOIZavrsni
{
    partial class GenetickiAlgoritam
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
            this.num_broj_jedinki = new System.Windows.Forms.NumericUpDown();
            this.num_broj_iteracija = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_nivo_elitizma = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Kreni = new System.Windows.Forms.Button();
            this.flp_top = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_broj_jedinki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_broj_iteracija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivo_elitizma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // num_broj_jedinki
            // 
            this.num_broj_jedinki.Location = new System.Drawing.Point(86, 12);
            this.num_broj_jedinki.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_broj_jedinki.Name = "num_broj_jedinki";
            this.num_broj_jedinki.Size = new System.Drawing.Size(120, 20);
            this.num_broj_jedinki.TabIndex = 0;
            // 
            // num_broj_iteracija
            // 
            this.num_broj_iteracija.Location = new System.Drawing.Point(86, 38);
            this.num_broj_iteracija.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.num_broj_iteracija.Name = "num_broj_iteracija";
            this.num_broj_iteracija.Size = new System.Drawing.Size(120, 20);
            this.num_broj_iteracija.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj Jedinki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj Iteracija:";
            // 
            // num_nivo_elitizma
            // 
            this.num_nivo_elitizma.Location = new System.Drawing.Point(86, 64);
            this.num_nivo_elitizma.Name = "num_nivo_elitizma";
            this.num_nivo_elitizma.Size = new System.Drawing.Size(120, 20);
            this.num_nivo_elitizma.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nivo Elitizma:";
            // 
            // btn_Kreni
            // 
            this.btn_Kreni.Location = new System.Drawing.Point(7, 118);
            this.btn_Kreni.Name = "btn_Kreni";
            this.btn_Kreni.Size = new System.Drawing.Size(199, 78);
            this.btn_Kreni.TabIndex = 8;
            this.btn_Kreni.Text = "Kreni!";
            this.btn_Kreni.UseVisualStyleBackColor = true;
            this.btn_Kreni.Click += new System.EventHandler(this.btn_Kreni_Click);
            // 
            // flp_top
            // 
            this.flp_top.Location = new System.Drawing.Point(7, 218);
            this.flp_top.Name = "flp_top";
            this.flp_top.Size = new System.Drawing.Size(200, 84);
            this.flp_top.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 313);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(668, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(213, 14);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "BestFitness";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(462, 288);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Najbolji hromozom (tim):";
            // 
            // GenetickiAlgoritam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.flp_top);
            this.Controls.Add(this.btn_Kreni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_nivo_elitizma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_broj_iteracija);
            this.Controls.Add(this.num_broj_jedinki);
            this.Name = "GenetickiAlgoritam";
            this.Text = "Genetički Algoritam";
            this.Load += new System.EventHandler(this.GenetickiAlgoritam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_broj_jedinki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_broj_iteracija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivo_elitizma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_broj_jedinki;
        private System.Windows.Forms.NumericUpDown num_broj_iteracija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_nivo_elitizma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Kreni;
        private System.Windows.Forms.FlowLayoutPanel flp_top;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
    }
}