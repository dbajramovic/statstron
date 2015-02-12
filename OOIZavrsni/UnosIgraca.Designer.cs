namespace OOIZavrsni
{
    partial class UnosIgraca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_ime = new System.Windows.Forms.TextBox();
            this.t_prezime = new System.Windows.Forms.TextBox();
            this.b_dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // t_ime
            // 
            this.t_ime.Location = new System.Drawing.Point(59, 8);
            this.t_ime.Name = "t_ime";
            this.t_ime.Size = new System.Drawing.Size(158, 20);
            this.t_ime.TabIndex = 3;
            // 
            // t_prezime
            // 
            this.t_prezime.Location = new System.Drawing.Point(59, 34);
            this.t_prezime.Name = "t_prezime";
            this.t_prezime.Size = new System.Drawing.Size(158, 20);
            this.t_prezime.TabIndex = 4;
            // 
            // b_dodaj
            // 
            this.b_dodaj.Location = new System.Drawing.Point(117, 60);
            this.b_dodaj.Name = "b_dodaj";
            this.b_dodaj.Size = new System.Drawing.Size(100, 23);
            this.b_dodaj.TabIndex = 5;
            this.b_dodaj.Text = "Dodaj";
            this.b_dodaj.UseVisualStyleBackColor = true;
            this.b_dodaj.Click += new System.EventHandler(this.b_dodaj_Click);
            // 
            // UnosIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 89);
            this.Controls.Add(this.b_dodaj);
            this.Controls.Add(this.t_prezime);
            this.Controls.Add(this.t_ime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnosIgraca";
            this.Text = "Unos Igraca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_ime;
        private System.Windows.Forms.TextBox t_prezime;
        private System.Windows.Forms.Button b_dodaj;
    }
}