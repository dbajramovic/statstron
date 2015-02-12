namespace OOIZavrsni
{
    partial class Spoji
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.l_igrac_ime = new System.Windows.Forms.Label();
            this.l_igrac_prezime = new System.Windows.Forms.Label();
            this.l_igrac_ekipa = new System.Windows.Forms.Label();
            this.l_ekipa_ime = new System.Windows.Forms.Label();
            this.l_ekipa_grad = new System.Windows.Forms.Label();
            this.l_broj_igraca = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 277);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(459, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(257, 277);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj u Ekipu!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_igrac_ekipa);
            this.groupBox1.Controls.Add(this.l_igrac_prezime);
            this.groupBox1.Controls.Add(this.l_igrac_ime);
            this.groupBox1.Location = new System.Drawing.Point(274, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Igrač";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.l_broj_igraca);
            this.groupBox2.Controls.Add(this.l_ekipa_grad);
            this.groupBox2.Controls.Add(this.l_ekipa_ime);
            this.groupBox2.Location = new System.Drawing.Point(274, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 118);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekipa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // l_igrac_ime
            // 
            this.l_igrac_ime.AutoSize = true;
            this.l_igrac_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_igrac_ime.Location = new System.Drawing.Point(37, 16);
            this.l_igrac_ime.Name = "l_igrac_ime";
            this.l_igrac_ime.Size = new System.Drawing.Size(57, 20);
            this.l_igrac_ime.TabIndex = 0;
            this.l_igrac_ime.Text = "label1";
            // 
            // l_igrac_prezime
            // 
            this.l_igrac_prezime.AutoSize = true;
            this.l_igrac_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_igrac_prezime.Location = new System.Drawing.Point(37, 53);
            this.l_igrac_prezime.Name = "l_igrac_prezime";
            this.l_igrac_prezime.Size = new System.Drawing.Size(57, 20);
            this.l_igrac_prezime.TabIndex = 1;
            this.l_igrac_prezime.Text = "label2";
            // 
            // l_igrac_ekipa
            // 
            this.l_igrac_ekipa.AutoSize = true;
            this.l_igrac_ekipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_igrac_ekipa.Location = new System.Drawing.Point(37, 84);
            this.l_igrac_ekipa.Name = "l_igrac_ekipa";
            this.l_igrac_ekipa.Size = new System.Drawing.Size(57, 20);
            this.l_igrac_ekipa.TabIndex = 2;
            this.l_igrac_ekipa.Text = "label3";
            // 
            // l_ekipa_ime
            // 
            this.l_ekipa_ime.AutoSize = true;
            this.l_ekipa_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_ekipa_ime.Location = new System.Drawing.Point(37, 47);
            this.l_ekipa_ime.Name = "l_ekipa_ime";
            this.l_ekipa_ime.Size = new System.Drawing.Size(57, 20);
            this.l_ekipa_ime.TabIndex = 0;
            this.l_ekipa_ime.Text = "label1";
            // 
            // l_ekipa_grad
            // 
            this.l_ekipa_grad.AutoSize = true;
            this.l_ekipa_grad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_ekipa_grad.Location = new System.Drawing.Point(37, 16);
            this.l_ekipa_grad.Name = "l_ekipa_grad";
            this.l_ekipa_grad.Size = new System.Drawing.Size(57, 20);
            this.l_ekipa_grad.TabIndex = 1;
            this.l_ekipa_grad.Text = "label1";
            // 
            // l_broj_igraca
            // 
            this.l_broj_igraca.AutoSize = true;
            this.l_broj_igraca.Location = new System.Drawing.Point(38, 85);
            this.l_broj_igraca.Name = "l_broj_igraca";
            this.l_broj_igraca.Size = new System.Drawing.Size(108, 13);
            this.l_broj_igraca.TabIndex = 2;
            this.l_broj_igraca.Text = "NIJE JOS UBACENO";
            // 
            // Spoji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Spoji";
            this.Text = "Spoji";
            this.Load += new System.EventHandler(this.Spoji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label l_igrac_ekipa;
        private System.Windows.Forms.Label l_igrac_prezime;
        private System.Windows.Forms.Label l_igrac_ime;
        private System.Windows.Forms.Label l_broj_igraca;
        private System.Windows.Forms.Label l_ekipa_grad;
        private System.Windows.Forms.Label l_ekipa_ime;
    }
}