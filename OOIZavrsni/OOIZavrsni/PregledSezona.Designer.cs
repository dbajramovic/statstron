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
            this.mydbDataSet = new OOIZavrsni.mydbDataSet();
            this.sezoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sezoneTableAdapter = new OOIZavrsni.mydbDataSetTableAdapters.sezoneTableAdapter();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_TSP = new System.Windows.Forms.Button();
            this.EffSt = new System.Windows.Forms.Button();
            this.EC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sezoneBindingSource)).BeginInit();
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
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sezoneBindingSource
            // 
            this.sezoneBindingSource.DataMember = "sezone";
            this.sezoneBindingSource.DataSource = this.mydbDataSet;
            // 
            // sezoneTableAdapter
            // 
            this.sezoneTableAdapter.ClearBeforeFill = true;
            // 
            // idSezoneDataGridViewTextBoxColumn
            // 
            this.idSezoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idSezoneDataGridViewTextBoxColumn.DataPropertyName = "DajSezonskiPodaci_ID";
            this.idSezoneDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idSezoneDataGridViewTextBoxColumn.Name = "idSezoneDataGridViewTextBoxColumn";
            this.idSezoneDataGridViewTextBoxColumn.Width = 43;
            // 
            // igracIDDataGridViewTextBoxColumn
            // 
            this.igracIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.igracIDDataGridViewTextBoxColumn.DataPropertyName = "DajIgracID";
            this.igracIDDataGridViewTextBoxColumn.HeaderText = "IgracID";
            this.igracIDDataGridViewTextBoxColumn.Name = "igracIDDataGridViewTextBoxColumn";
            this.igracIDDataGridViewTextBoxColumn.Visible = false;
            this.igracIDDataGridViewTextBoxColumn.Width = 67;
            // 
            // timIDDataGridViewTextBoxColumn
            // 
            this.timIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.timIDDataGridViewTextBoxColumn.DataPropertyName = "DajTimID";
            this.timIDDataGridViewTextBoxColumn.HeaderText = "TimID";
            this.timIDDataGridViewTextBoxColumn.Name = "timIDDataGridViewTextBoxColumn";
            this.timIDDataGridViewTextBoxColumn.Visible = false;
            this.timIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // starostDataGridViewTextBoxColumn
            // 
            this.starostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.starostDataGridViewTextBoxColumn.DataPropertyName = "DajStarost";
            this.starostDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.starostDataGridViewTextBoxColumn.Name = "starostDataGridViewTextBoxColumn";
            this.starostDataGridViewTextBoxColumn.Width = 54;
            // 
            // pozicijaIDDataGridViewTextBoxColumn
            // 
            this.pozicijaIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pozicijaIDDataGridViewTextBoxColumn.DataPropertyName = "DajPoz";
            this.pozicijaIDDataGridViewTextBoxColumn.HeaderText = "POZ";
            this.pozicijaIDDataGridViewTextBoxColumn.Name = "pozicijaIDDataGridViewTextBoxColumn";
            this.pozicijaIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // brojUtakmicaDataGridViewTextBoxColumn
            // 
            this.brojUtakmicaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.brojUtakmicaDataGridViewTextBoxColumn.DataPropertyName = "DajBroj_Utakmica";
            this.brojUtakmicaDataGridViewTextBoxColumn.HeaderText = "GP";
            this.brojUtakmicaDataGridViewTextBoxColumn.Name = "brojUtakmicaDataGridViewTextBoxColumn";
            this.brojUtakmicaDataGridViewTextBoxColumn.Width = 47;
            // 
            // brojUtakmicaStarterDataGridViewTextBoxColumn
            // 
            this.brojUtakmicaStarterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.brojUtakmicaStarterDataGridViewTextBoxColumn.DataPropertyName = "DajBroj_Utakmica_Starter";
            this.brojUtakmicaStarterDataGridViewTextBoxColumn.HeaderText = "GS";
            this.brojUtakmicaStarterDataGridViewTextBoxColumn.Name = "brojUtakmicaStarterDataGridViewTextBoxColumn";
            this.brojUtakmicaStarterDataGridViewTextBoxColumn.Width = 47;
            // 
            // brojMinutaDataGridViewTextBoxColumn
            // 
            this.brojMinutaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.brojMinutaDataGridViewTextBoxColumn.DataPropertyName = "DajBroj_Minuta";
            this.brojMinutaDataGridViewTextBoxColumn.HeaderText = "MIN";
            this.brojMinutaDataGridViewTextBoxColumn.Name = "brojMinutaDataGridViewTextBoxColumn";
            this.brojMinutaDataGridViewTextBoxColumn.Width = 52;
            // 
            // sutPokusaniDataGridViewTextBoxColumn
            // 
            this.sutPokusaniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sutPokusaniDataGridViewTextBoxColumn.DataPropertyName = "DajSut_Pokusani";
            this.sutPokusaniDataGridViewTextBoxColumn.HeaderText = "FGA";
            this.sutPokusaniDataGridViewTextBoxColumn.Name = "sutPokusaniDataGridViewTextBoxColumn";
            this.sutPokusaniDataGridViewTextBoxColumn.Width = 53;
            // 
            // sutPogodjeniDataGridViewTextBoxColumn
            // 
            this.sutPogodjeniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sutPogodjeniDataGridViewTextBoxColumn.DataPropertyName = "DajSut_Pogodjeni";
            this.sutPogodjeniDataGridViewTextBoxColumn.HeaderText = "FGM";
            this.sutPogodjeniDataGridViewTextBoxColumn.Name = "sutPogodjeniDataGridViewTextBoxColumn";
            this.sutPogodjeniDataGridViewTextBoxColumn.Width = 55;
            // 
            // procenatSutSveDataGridViewTextBoxColumn
            // 
            this.procenatSutSveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.procenatSutSveDataGridViewTextBoxColumn.DataPropertyName = "DajProcenat_Sut_Sve";
            this.procenatSutSveDataGridViewTextBoxColumn.HeaderText = "FG%";
            this.procenatSutSveDataGridViewTextBoxColumn.Name = "procenatSutSveDataGridViewTextBoxColumn";
            this.procenatSutSveDataGridViewTextBoxColumn.Width = 54;
            // 
            // sut3PoenaPokusaniDataGridViewTextBoxColumn
            // 
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn.DataPropertyName = "DajSut_3_Poena_Pokusani";
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn.HeaderText = "3FGA";
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn.Name = "sut3PoenaPokusaniDataGridViewTextBoxColumn";
            this.sut3PoenaPokusaniDataGridViewTextBoxColumn.Width = 59;
            // 
            // sut3PoenaPogodjeniDataGridViewTextBoxColumn
            // 
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn.DataPropertyName = "DajSut_3_Poena_Pogodjeni";
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn.HeaderText = "3FGM";
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn.Name = "sut3PoenaPogodjeniDataGridViewTextBoxColumn";
            this.sut3PoenaPogodjeniDataGridViewTextBoxColumn.Width = 61;
            // 
            // procenatSut3DataGridViewTextBoxColumn
            // 
            this.procenatSut3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.procenatSut3DataGridViewTextBoxColumn.DataPropertyName = "DajProcenat_Sut_3";
            this.procenatSut3DataGridViewTextBoxColumn.HeaderText = "3FG%";
            this.procenatSut3DataGridViewTextBoxColumn.Name = "procenatSut3DataGridViewTextBoxColumn";
            this.procenatSut3DataGridViewTextBoxColumn.Width = 60;
            // 
            // sut2PoenaPokusaniDataGridViewTextBoxColumn
            // 
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn.DataPropertyName = "DajSut_2_Poena_Pokusani";
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn.HeaderText = "2FGA";
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn.Name = "sut2PoenaPokusaniDataGridViewTextBoxColumn";
            this.sut2PoenaPokusaniDataGridViewTextBoxColumn.Width = 59;
            // 
            // sut2PoenaPogodjeniDataGridViewTextBoxColumn
            // 
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn.DataPropertyName = "DajSut_2_Poena_Pogodjeni";
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn.HeaderText = "2FGM";
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn.Name = "sut2PoenaPogodjeniDataGridViewTextBoxColumn";
            this.sut2PoenaPogodjeniDataGridViewTextBoxColumn.Width = 61;
            // 
            // procenatSut2DataGridViewTextBoxColumn
            // 
            this.procenatSut2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.procenatSut2DataGridViewTextBoxColumn.DataPropertyName = "DajProcenat_Sut_2";
            this.procenatSut2DataGridViewTextBoxColumn.HeaderText = "2FG%";
            this.procenatSut2DataGridViewTextBoxColumn.Name = "procenatSut2DataGridViewTextBoxColumn";
            this.procenatSut2DataGridViewTextBoxColumn.Width = 60;
            // 
            // sut1PoenPokusaniDataGridViewTextBoxColumn
            // 
            this.sut1PoenPokusaniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sut1PoenPokusaniDataGridViewTextBoxColumn.DataPropertyName = "DajSut_1_Poen_Pokusani";
            this.sut1PoenPokusaniDataGridViewTextBoxColumn.HeaderText = "1FGA";
            this.sut1PoenPokusaniDataGridViewTextBoxColumn.Name = "sut1PoenPokusaniDataGridViewTextBoxColumn";
            this.sut1PoenPokusaniDataGridViewTextBoxColumn.Width = 59;
            // 
            // sut1PoenPogodjeniDataGridViewTextBoxColumn
            // 
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn.DataPropertyName = "DajSut_1_Poen_Pogodjeni";
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn.HeaderText = "1FGM";
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn.Name = "sut1PoenPogodjeniDataGridViewTextBoxColumn";
            this.sut1PoenPogodjeniDataGridViewTextBoxColumn.Width = 61;
            // 
            // procenatSut1DataGridViewTextBoxColumn
            // 
            this.procenatSut1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.procenatSut1DataGridViewTextBoxColumn.DataPropertyName = "DajProcenat_Sut_1";
            this.procenatSut1DataGridViewTextBoxColumn.HeaderText = "1FG%";
            this.procenatSut1DataGridViewTextBoxColumn.Name = "procenatSut1DataGridViewTextBoxColumn";
            this.procenatSut1DataGridViewTextBoxColumn.Width = 60;
            // 
            // skokNapadDataGridViewTextBoxColumn
            // 
            this.skokNapadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.skokNapadDataGridViewTextBoxColumn.DataPropertyName = "DajSkok_Napad";
            this.skokNapadDataGridViewTextBoxColumn.HeaderText = "ORB";
            this.skokNapadDataGridViewTextBoxColumn.Name = "skokNapadDataGridViewTextBoxColumn";
            this.skokNapadDataGridViewTextBoxColumn.Width = 55;
            // 
            // skokOdbranaDataGridViewTextBoxColumn
            // 
            this.skokOdbranaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.skokOdbranaDataGridViewTextBoxColumn.DataPropertyName = "DajSkok_Odbrana";
            this.skokOdbranaDataGridViewTextBoxColumn.HeaderText = "DRB";
            this.skokOdbranaDataGridViewTextBoxColumn.Name = "skokOdbranaDataGridViewTextBoxColumn";
            this.skokOdbranaDataGridViewTextBoxColumn.Width = 55;
            // 
            // asistDataGridViewTextBoxColumn
            // 
            this.asistDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.asistDataGridViewTextBoxColumn.DataPropertyName = "DajAsist";
            this.asistDataGridViewTextBoxColumn.HeaderText = "AST";
            this.asistDataGridViewTextBoxColumn.Name = "asistDataGridViewTextBoxColumn";
            this.asistDataGridViewTextBoxColumn.Width = 53;
            // 
            // blokDataGridViewTextBoxColumn
            // 
            this.blokDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.blokDataGridViewTextBoxColumn.DataPropertyName = "DajBlok";
            this.blokDataGridViewTextBoxColumn.HeaderText = "BLK";
            this.blokDataGridViewTextBoxColumn.Name = "blokDataGridViewTextBoxColumn";
            this.blokDataGridViewTextBoxColumn.Width = 52;
            // 
            // ukradenaDataGridViewTextBoxColumn
            // 
            this.ukradenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ukradenaDataGridViewTextBoxColumn.DataPropertyName = "DajUkradena";
            this.ukradenaDataGridViewTextBoxColumn.HeaderText = "STL";
            this.ukradenaDataGridViewTextBoxColumn.Name = "ukradenaDataGridViewTextBoxColumn";
            this.ukradenaDataGridViewTextBoxColumn.Width = 52;
            // 
            // izgubljenaDataGridViewTextBoxColumn
            // 
            this.izgubljenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.izgubljenaDataGridViewTextBoxColumn.DataPropertyName = "DajIzgubljena";
            this.izgubljenaDataGridViewTextBoxColumn.HeaderText = "TO";
            this.izgubljenaDataGridViewTextBoxColumn.Name = "izgubljenaDataGridViewTextBoxColumn";
            this.izgubljenaDataGridViewTextBoxColumn.Width = 47;
            // 
            // licneGreskeDataGridViewTextBoxColumn
            // 
            this.licneGreskeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.licneGreskeDataGridViewTextBoxColumn.DataPropertyName = "DajLicne_Greske";
            this.licneGreskeDataGridViewTextBoxColumn.HeaderText = "FLS";
            this.licneGreskeDataGridViewTextBoxColumn.Name = "licneGreskeDataGridViewTextBoxColumn";
            this.licneGreskeDataGridViewTextBoxColumn.Width = 51;
            // 
            // poeniDataGridViewTextBoxColumn
            // 
            this.poeniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.poeniDataGridViewTextBoxColumn.DataPropertyName = "DajPoeni";
            this.poeniDataGridViewTextBoxColumn.HeaderText = "PTS";
            this.poeniDataGridViewTextBoxColumn.Name = "poeniDataGridViewTextBoxColumn";
            this.poeniDataGridViewTextBoxColumn.Width = 53;
            // 
            // groupBox1
            // 
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
            // PregledSezona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "PregledSezona";
            this.Text = "Pregled Sezona";
            this.Load += new System.EventHandler(this.PregledSezona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sezoneBindingSource)).EndInit();
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
    }
}