namespace OOIZavrsni
{
    partial class HromozomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.l_broj_hromozoma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_fitness = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HROMOZOM #";
            // 
            // l_broj_hromozoma
            // 
            this.l_broj_hromozoma.AutoSize = true;
            this.l_broj_hromozoma.Location = new System.Drawing.Point(92, 15);
            this.l_broj_hromozoma.Name = "l_broj_hromozoma";
            this.l_broj_hromozoma.Size = new System.Drawing.Size(35, 13);
            this.l_broj_hromozoma.TabIndex = 1;
            this.l_broj_hromozoma.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FITNESS";
            // 
            // l_fitness
            // 
            this.l_fitness.AutoSize = true;
            this.l_fitness.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.l_fitness.Location = new System.Drawing.Point(77, 43);
            this.l_fitness.Name = "l_fitness";
            this.l_fitness.Size = new System.Drawing.Size(35, 13);
            this.l_fitness.TabIndex = 3;
            this.l_fitness.Text = "label3";
            // 
            // HromozomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l_fitness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_broj_hromozoma);
            this.Controls.Add(this.label1);
            this.Name = "HromozomControl";
            this.Size = new System.Drawing.Size(242, 72);
            this.Load += new System.EventHandler(this.HromozomControl_Load);
            this.DoubleClick += new System.EventHandler(this.HromozomControl_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_broj_hromozoma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_fitness;
    }
}
