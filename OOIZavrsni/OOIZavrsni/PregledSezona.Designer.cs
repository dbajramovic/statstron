namespace OOIZavrsni
{
    partial class PregledSezona
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sezoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new OOIZavrsni.mydbDataSet();
            this.sezoneTableAdapter = new OOIZavrsni.mydbDataSetTableAdapters.sezoneTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EC = new System.Windows.Forms.Button();
            this.EffSt = new System.Windows.Forms.Button();
            this.b_TSP = new System.Windows.Forms.Button();
            this.idSezoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igracIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozicijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojUtakmicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojUtakmicaStarterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojMinutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sutPokusaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sutPogodjeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatSutSveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatSut3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatSut2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sut1PoenPokusaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatSut1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokNapadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokOdbranaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukradenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izgubljenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licneGreskeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sezoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1345, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSezoneDataGridViewTextBoxColumn,
            this.igracIDDataGridViewTextBoxColumn,
            this.timIDDataGridViewTextBoxColumn,
            this.starostDataGridViewTextBoxColumn,
            this.pozicijaIDDataGridViewTextBoxColumn,
            this.brojUtakmicaDataGridViewTextBoxColumn,
            this.brojUtakmicaStarterDataGridViewTextBoxColumn,
            this.brojMinutaDataGridViewTextBoxColumn,
            this.sutPokusaniDataGridViewTextBoxColumn,
            this.sutPogodjeniDataGridViewTextBoxColumn,
            this.procenatSutSveDataGridViewTextBoxColumn,
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn,
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn,
            this.procenatSut3DataGridViewTextBoxColumn,
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn,
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn,
            this.procenatSut2DataGridViewTextBoxColumn,
            this.sut1PoenPokusaniDataGridViewTextBoxColumn,
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn,
            this.procenatSut1DataGridViewTextBoxColumn,
            this.skokNapadDataGridViewTextBoxColumn,
            this.skokOdbranaDataGridViewTextBoxColumn,
            this.asistDataGridViewTextBoxColumn,
            this.blokDataGridViewTextBoxColumn,
            this.ukradenaDataGridViewTextBoxColumn,
            this.izgubljenaDataGridViewTextBoxColumn,
            this.licneGreskeDataGridViewTextBoxColumn,
            this.poeniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sezoneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1344, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // sezoneBindingSource
            // 
            this.sezoneBindingSource.DataMember = "sezone";
            this.sezoneBindingSource.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sezoneTableAdapter
            // 
            this.sezoneTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.EC);
            this.groupBox1.Controls.Add(this.EffSt);
            this.groupBox1.Controls.Add(this.b_TSP);
            this.groupBox1.Location = new System.Drawing.Point(13, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1344, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Napredni Podaci (ASPBmetrics)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Player Efficiency Rating (PER)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EC
            // 
            this.EC.Location = new System.Drawing.Point(364, 19);
            this.EC.Name = "EC";
            this.EC.Size = new System.Drawing.Size(173, 49);
            this.EC.TabIndex = 2;
            this.EC.Text = "Economy (EC)";
            this.EC.UseVisualStyleBackColor = true;
            this.EC.Click += new System.EventHandler(this.EC_Click);
            // 
            // EffSt
            // 
            this.EffSt.Location = new System.Drawing.Point(185, 19);
            this.EffSt.Name = "EffSt";
            this.EffSt.Size = new System.Drawing.Size(173, 49);
            this.EffSt.TabIndex = 1;
            this.EffSt.Text = "Standard Efficiency (EFF)";
            this.EffSt.UseVisualStyleBackColor = true;
            this.EffSt.Click += new System.EventHandler(this.EffSt_Click);
            // 
            // b_TSP
            // 
            this.b_TSP.Location = new System.Drawing.Point(6, 19);
            this.b_TSP.Name = "b_TSP";
            this.b_TSP.Size = new System.Drawing.Size(173, 49);
            this.b_TSP.TabIndex = 0;
            this.b_TSP.Text = "True Shot Precentage (TS%)";
            this.b_TSP.UseVisualStyleBackColor = true;
            this.b_TSP.Click += new System.EventHandler(this.b_TSP_Click);
            // 
            // idSezoneDataGridViewTextBoxColumn
            // 
            this.idSezoneDataGridViewTextBoxColumn.DataPropertyName = "idSezone";
            this.idSezoneDataGridViewTextBoxColumn.HeaderText = "idSezone";
            this.idSezoneDataGridViewTextBoxColumn.Name = "idSezoneDataGridViewTextBoxColumn";
            // 
            // igracIDDataGridViewTextBoxColumn
            // 
            this.igracIDDataGridViewTextBoxColumn.DataPropertyName = "IgracID";
            this.igracIDDataGridViewTextBoxColumn.HeaderText = "IgracID";
            this.igracIDDataGridViewTextBoxColumn.Name = "igracIDDataGridViewTextBoxColumn";
            // 
            // timIDDataGridViewTextBoxColumn
            // 
            this.timIDDataGridViewTextBoxColumn.DataPropertyName = "TimID";
            this.timIDDataGridViewTextBoxColumn.HeaderText = "TimID";
            this.timIDDataGridViewTextBoxColumn.Name = "timIDDataGridViewTextBoxColumn";
            // 
            // starostDataGridViewTextBoxColumn
            // 
            this.starostDataGridViewTextBoxColumn.DataPropertyName = "Starost";
            this.starostDataGridViewTextBoxColumn.HeaderText = "Starost";
            this.starostDataGridViewTextBoxColumn.Name = "starostDataGridViewTextBoxColumn";
            // 
            // pozicijaIDDataGridViewTextBoxColumn
            // 
            this.pozicijaIDDataGridViewTextBoxColumn.DataPropertyName = "PozicijaID";
            this.pozicijaIDDataGridViewTextBoxColumn.HeaderText = "PozicijaID";
            this.pozicijaIDDataGridViewTextBoxColumn.Name = "pozicijaIDDataGridViewTextBoxColumn";
            // 
            // brojUtakmicaDataGridViewTextBoxColumn
            // 
            this.brojUtakmicaDataGridViewTextBoxColumn.DataPropertyName = "Broj_Utakmica";
            this.brojUtakmicaDataGridViewTextBoxColumn.HeaderText = "Broj_Utakmica";
            this.brojUtakmicaDataGridViewTextBoxColumn.Name = "brojUtakmicaDataGridViewTextBoxColumn";
            // 
            // brojUtakmicaStarterDataGridViewTextBoxColumn
            // 
            this.brojUtakmicaStarterDataGridViewTextBoxColumn.DataPropertyName = "Broj_Utakmica_Starter";
            this.brojUtakmicaStarterDataGridViewTextBoxColumn.HeaderText = "Broj_Utakmica_Starter";
            this.brojUtakmicaStarterDataGridViewTextBoxColumn.Name = "brojUtakmicaStarterDataGridViewTextBoxColumn";
            // 
            // brojMinutaDataGridViewTextBoxColumn
            // 
            this.brojMinutaDataGridViewTextBoxColumn.DataPropertyName = "Broj_Minuta";
            this.brojMinutaDataGridViewTextBoxColumn.HeaderText = "Broj_Minuta";
            this.brojMinutaDataGridViewTextBoxColumn.Name = "brojMinutaDataGridViewTextBoxColumn";
            // 
            // sutPokusaniDataGridViewTextBoxColumn
            // 
            this.sutPokusaniDataGridViewTextBoxColumn.DataPropertyName = "Sut_Pokusani";
            this.sutPokusaniDataGridViewTextBoxColumn.HeaderText = "Sut_Pokusani";
            this.sutPokusaniDataGridViewTextBoxColumn.Name = "sutPokusaniDataGridViewTextBoxColumn";
            // 
            // sutPogodjeniDataGridViewTextBoxColumn
            // 
            this.sutPogodjeniDataGridViewTextBoxColumn.DataPropertyName = "Sut_Pogodjeni";
            this.sutPogodjeniDataGridViewTextBoxColumn.HeaderText = "Sut_Pogodjeni";
            this.sutPogodjeniDataGridViewTextBoxColumn.Name = "sutPogodjeniDataGridViewTextBoxColumn";
            // 
            // procenatSutSveDataGridViewTextBoxColumn
            // 
            this.procenatSutSveDataGridViewTextBoxColumn.DataPropertyName = "Procenat_Sut_Sve";
            this.procenatSutSveDataGridViewTextBoxColumn.HeaderText = "Procenat_Sut_Sve";
            this.procenatSutSveDataGridViewTextBoxColumn.Name = "procenatSutSveDataGridViewTextBoxColumn";
            // 
            // sut3PoenaPokusaniDataGridViewTextBoxColumn
            // 
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn.DataPropertyName = "Sut_3_Poena_Pokusani";
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn.HeaderText = "Sut_3_Poena_Pokusani";
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn.Name = "sut3PoenaPokusaniDataGridViewTextBoxColumn";
            // 
            // sut3PoenaPogodjeniDataGridViewTextBoxColumn
            // 
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn.DataPropertyName = "Sut_3_Poena_Pogodjeni";
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn.HeaderText = "Sut_3_Poena_Pogodjeni";
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn.Name = "sut3PoenaPogodjeniDataGridViewTextBoxColumn";
            // 
            // procenatSut3DataGridViewTextBoxColumn
            // 
            this.procenatSut3DataGridViewTextBoxColumn.DataPropertyName = "Procenat_Sut_3";
            this.procenatSut3DataGridViewTextBoxColumn.HeaderText = "Procenat_Sut_3";
            this.procenatSut3DataGridViewTextBoxColumn.Name = "procenatSut3DataGridViewTextBoxColumn";
            // 
            // sut2PoenaPokusaniDataGridViewTextBoxColumn
            // 
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn.DataPropertyName = "Sut_2_Poena_Pokusani";
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn.HeaderText = "Sut_2_Poena_Pokusani";
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn.Name = "sut2PoenaPokusaniDataGridViewTextBoxColumn";
            // 
            // sut2PoenaPogodjeniDataGridViewTextBoxColumn
            // 
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn.DataPropertyName = "Sut_2_Poena_Pogodjeni";
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn.HeaderText = "Sut_2_Poena_Pogodjeni";
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn.Name = "sut2PoenaPogodjeniDataGridViewTextBoxColumn";
            // 
            // procenatSut2DataGridViewTextBoxColumn
            // 
            this.procenatSut2DataGridViewTextBoxColumn.DataPropertyName = "Procenat_Sut_2";
            this.procenatSut2DataGridViewTextBoxColumn.HeaderText = "Procenat_Sut_2";
            this.procenatSut2DataGridViewTextBoxColumn.Name = "procenatSut2DataGridViewTextBoxColumn";
            // 
            // sut1PoenPokusaniDataGridViewTextBoxColumn
            // 
            this.sut1PoenPokusaniDataGridViewTextBoxColumn.DataPropertyName = "Sut_1_Poen_Pokusani";
            this.sut1PoenPokusaniDataGridViewTextBoxColumn.HeaderText = "Sut_1_Poen_Pokusani";
            this.sut1PoenPokusaniDataGridViewTextBoxColumn.Name = "sut1PoenPokusaniDataGridViewTextBoxColumn";
            // 
            // sut1PoenPogodjeniDataGridViewTextBoxColumn
            // 
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn.DataPropertyName = "Sut_1_Poen_Pogodjeni";
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn.HeaderText = "Sut_1_Poen_Pogodjeni";
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn.Name = "sut1PoenPogodjeniDataGridViewTextBoxColumn";
            // 
            // procenatSut1DataGridViewTextBoxColumn
            // 
            this.procenatSut1DataGridViewTextBoxColumn.DataPropertyName = "Procenat_Sut_1";
            this.procenatSut1DataGridViewTextBoxColumn.HeaderText = "Procenat_Sut_1";
            this.procenatSut1DataGridViewTextBoxColumn.Name = "procenatSut1DataGridViewTextBoxColumn";
            // 
            // skokNapadDataGridViewTextBoxColumn
            // 
            this.skokNapadDataGridViewTextBoxColumn.DataPropertyName = "Skok_Napad";
            this.skokNapadDataGridViewTextBoxColumn.HeaderText = "Skok_Napad";
            this.skokNapadDataGridViewTextBoxColumn.Name = "skokNapadDataGridViewTextBoxColumn";
            // 
            // skokOdbranaDataGridViewTextBoxColumn
            // 
            this.skokOdbranaDataGridViewTextBoxColumn.DataPropertyName = "Skok_Odbrana";
            this.skokOdbranaDataGridViewTextBoxColumn.HeaderText = "Skok_Odbrana";
            this.skokOdbranaDataGridViewTextBoxColumn.Name = "skokOdbranaDataGridViewTextBoxColumn";
            // 
            // asistDataGridViewTextBoxColumn
            // 
            this.asistDataGridViewTextBoxColumn.DataPropertyName = "Asist";
            this.asistDataGridViewTextBoxColumn.HeaderText = "Asist";
            this.asistDataGridViewTextBoxColumn.Name = "asistDataGridViewTextBoxColumn";
            // 
            // blokDataGridViewTextBoxColumn
            // 
            this.blokDataGridViewTextBoxColumn.DataPropertyName = "Blok";
            this.blokDataGridViewTextBoxColumn.HeaderText = "Blok";
            this.blokDataGridViewTextBoxColumn.Name = "blokDataGridViewTextBoxColumn";
            // 
            // ukradenaDataGridViewTextBoxColumn
            // 
            this.ukradenaDataGridViewTextBoxColumn.DataPropertyName = "Ukradena";
            this.ukradenaDataGridViewTextBoxColumn.HeaderText = "Ukradena";
            this.ukradenaDataGridViewTextBoxColumn.Name = "ukradenaDataGridViewTextBoxColumn";
            // 
            // izgubljenaDataGridViewTextBoxColumn
            // 
            this.izgubljenaDataGridViewTextBoxColumn.DataPropertyName = "Izgubljena";
            this.izgubljenaDataGridViewTextBoxColumn.HeaderText = "Izgubljena";
            this.izgubljenaDataGridViewTextBoxColumn.Name = "izgubljenaDataGridViewTextBoxColumn";
            // 
            // licneGreskeDataGridViewTextBoxColumn
            // 
            this.licneGreskeDataGridViewTextBoxColumn.DataPropertyName = "Licne_Greske";
            this.licneGreskeDataGridViewTextBoxColumn.HeaderText = "Licne_Greske";
            this.licneGreskeDataGridViewTextBoxColumn.Name = "licneGreskeDataGridViewTextBoxColumn";
            // 
            // poeniDataGridViewTextBoxColumn
            // 
            this.poeniDataGridViewTextBoxColumn.DataPropertyName = "Poeni";
            this.poeniDataGridViewTextBoxColumn.HeaderText = "Poeni";
            this.poeniDataGridViewTextBoxColumn.Name = "poeniDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(722, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Player Index Rating (PIR)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PregledSezona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "PregledSezona";
            this.Text = "Pregled Sezona";
            this.Load += new System.EventHandler(this.PregledSezona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sezoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource sezoneBindingSource;
        private mydbDataSetTableAdapters.sezoneTableAdapter sezoneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSezoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igracIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozicijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojUtakmicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojUtakmicaStarterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojMinutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sutPokusaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sutPogodjeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatSutSveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sut3PoenaPokusaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sut3PoenaPogodjeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatSut3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sut2PoenaPokusaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sut2PoenaPogodjeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatSut2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sut1PoenPokusaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sut1PoenPogodjeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatSut1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skokNapadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skokOdbranaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukradenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izgubljenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licneGreskeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EffSt;
        private System.Windows.Forms.Button b_TSP;
        private System.Windows.Forms.Button EC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}