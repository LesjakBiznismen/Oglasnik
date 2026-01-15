namespace Oglasnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.AvtoDataGrid = new System.Windows.Forms.DataGridView();
            this.RadioAvto = new System.Windows.Forms.RadioButton();
            this.RadioTovornjak = new System.Windows.Forms.RadioButton();
            this.RadioTraktor = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.RadioMotor = new System.Windows.Forms.RadioButton();
            this.TBznamka = new System.Windows.Forms.TextBox();
            this.TBmodel = new System.Windows.Forms.TextBox();
            this.TBletnik = new System.Windows.Forms.TextBox();
            this.TBcena = new System.Windows.Forms.TextBox();
            this.TBbarva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DodajOglas = new System.Windows.Forms.Button();
            this.TovornjakDataGrid = new System.Windows.Forms.DataGridView();
            this.TraktorDataGrid = new System.Windows.Forms.DataGridView();
            this.KombiDataGrid = new System.Windows.Forms.DataGridView();
            this.MotorDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBMoč = new System.Windows.Forms.TextBox();
            this.TBŠteviloVrat = new System.Windows.Forms.TextBox();
            this.CBMenjalnik = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CBTipGoriva = new System.Windows.Forms.ComboBox();
            this.KupiVozilo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.StanjeNaDenarnici = new System.Windows.Forms.Label();
            this.TBoblika = new System.Windows.Forms.TextBox();
            this.Oblika = new System.Windows.Forms.Label();
            this.Čipiran = new System.Windows.Forms.Label();
            this.CBČipiran = new System.Windows.Forms.ComboBox();
            this.Priklop = new System.Windows.Forms.Label();
            this.Nosilnost = new System.Windows.Forms.Label();
            this.TBpriklop = new System.Windows.Forms.TextBox();
            this.TBnosilnost = new System.Windows.Forms.TextBox();
            this.TBprostornina = new System.Windows.Forms.TextBox();
            this.ProstorninaCCM = new System.Windows.Forms.Label();
            this.TBvisina = new System.Windows.Forms.TextBox();
            this.TBprtljaga = new System.Windows.Forms.TextBox();
            this.Višina = new System.Windows.Forms.Label();
            this.ProstorninaPrtljage = new System.Windows.Forms.Label();
            this.ImaŽlico = new System.Windows.Forms.ComboBox();
            this.Žlica = new System.Windows.Forms.Label();
            this.ŠirinaPriklopa = new System.Windows.Forms.Label();
            this.TBŠirinaPriklopa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvtoDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TovornjakDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraktorDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KombiDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotorDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(241, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "OGLASI MOTORNIH VOZIL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AvtoDataGrid
            // 
            this.AvtoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvtoDataGrid.Location = new System.Drawing.Point(150, 242);
            this.AvtoDataGrid.Name = "AvtoDataGrid";
            this.AvtoDataGrid.Size = new System.Drawing.Size(211, 128);
            this.AvtoDataGrid.TabIndex = 1;
            // 
            // RadioAvto
            // 
            this.RadioAvto.AutoSize = true;
            this.RadioAvto.Location = new System.Drawing.Point(28, 173);
            this.RadioAvto.Name = "RadioAvto";
            this.RadioAvto.Size = new System.Drawing.Size(73, 17);
            this.RadioAvto.TabIndex = 2;
            this.RadioAvto.TabStop = true;
            this.RadioAvto.Text = "Avtomobili";
            this.RadioAvto.UseVisualStyleBackColor = true;
            this.RadioAvto.CheckedChanged += new System.EventHandler(this.RadioAvto_CheckedChanged);
            // 
            // RadioTovornjak
            // 
            this.RadioTovornjak.AutoSize = true;
            this.RadioTovornjak.Location = new System.Drawing.Point(28, 196);
            this.RadioTovornjak.Name = "RadioTovornjak";
            this.RadioTovornjak.Size = new System.Drawing.Size(75, 17);
            this.RadioTovornjak.TabIndex = 3;
            this.RadioTovornjak.TabStop = true;
            this.RadioTovornjak.Text = "Tovornjaki";
            this.RadioTovornjak.UseVisualStyleBackColor = true;
            this.RadioTovornjak.CheckedChanged += new System.EventHandler(this.RadioTovornjak_CheckedChanged);
            // 
            // RadioTraktor
            // 
            this.RadioTraktor.AutoSize = true;
            this.RadioTraktor.Location = new System.Drawing.Point(28, 219);
            this.RadioTraktor.Name = "RadioTraktor";
            this.RadioTraktor.Size = new System.Drawing.Size(63, 17);
            this.RadioTraktor.TabIndex = 4;
            this.RadioTraktor.TabStop = true;
            this.RadioTraktor.Text = "Traktorji";
            this.RadioTraktor.UseVisualStyleBackColor = true;
            this.RadioTraktor.CheckedChanged += new System.EventHandler(this.RadioTraktor_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(28, 242);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Kombiji";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // RadioMotor
            // 
            this.RadioMotor.AutoSize = true;
            this.RadioMotor.Location = new System.Drawing.Point(28, 265);
            this.RadioMotor.Name = "RadioMotor";
            this.RadioMotor.Size = new System.Drawing.Size(56, 17);
            this.RadioMotor.TabIndex = 6;
            this.RadioMotor.TabStop = true;
            this.RadioMotor.Text = "Motorji";
            this.RadioMotor.UseVisualStyleBackColor = true;
            this.RadioMotor.CheckedChanged += new System.EventHandler(this.RadioMotor_CheckedChanged);
            // 
            // TBznamka
            // 
            this.TBznamka.Location = new System.Drawing.Point(157, 99);
            this.TBznamka.Name = "TBznamka";
            this.TBznamka.Size = new System.Drawing.Size(100, 20);
            this.TBznamka.TabIndex = 7;
            // 
            // TBmodel
            // 
            this.TBmodel.Location = new System.Drawing.Point(273, 99);
            this.TBmodel.Name = "TBmodel";
            this.TBmodel.Size = new System.Drawing.Size(100, 20);
            this.TBmodel.TabIndex = 8;
            // 
            // TBletnik
            // 
            this.TBletnik.Location = new System.Drawing.Point(390, 99);
            this.TBletnik.Name = "TBletnik";
            this.TBletnik.Size = new System.Drawing.Size(100, 20);
            this.TBletnik.TabIndex = 9;
            // 
            // TBcena
            // 
            this.TBcena.Location = new System.Drawing.Point(509, 99);
            this.TBcena.Name = "TBcena";
            this.TBcena.Size = new System.Drawing.Size(100, 20);
            this.TBcena.TabIndex = 10;
            // 
            // TBbarva
            // 
            this.TBbarva.Location = new System.Drawing.Point(625, 99);
            this.TBbarva.Name = "TBbarva";
            this.TBbarva.Size = new System.Drawing.Size(100, 20);
            this.TBbarva.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Znamka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Letnik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Barva";
            // 
            // DodajOglas
            // 
            this.DodajOglas.Location = new System.Drawing.Point(59, 98);
            this.DodajOglas.Name = "DodajOglas";
            this.DodajOglas.Size = new System.Drawing.Size(75, 23);
            this.DodajOglas.TabIndex = 17;
            this.DodajOglas.Text = "Dodaj oglas";
            this.DodajOglas.UseVisualStyleBackColor = true;
            this.DodajOglas.Click += new System.EventHandler(this.DodajOglas_Click);
            // 
            // TovornjakDataGrid
            // 
            this.TovornjakDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TovornjakDataGrid.Location = new System.Drawing.Point(390, 242);
            this.TovornjakDataGrid.Name = "TovornjakDataGrid";
            this.TovornjakDataGrid.Size = new System.Drawing.Size(217, 128);
            this.TovornjakDataGrid.TabIndex = 20;
            // 
            // TraktorDataGrid
            // 
            this.TraktorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TraktorDataGrid.Location = new System.Drawing.Point(629, 242);
            this.TraktorDataGrid.Name = "TraktorDataGrid";
            this.TraktorDataGrid.Size = new System.Drawing.Size(217, 128);
            this.TraktorDataGrid.TabIndex = 21;
            // 
            // KombiDataGrid
            // 
            this.KombiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KombiDataGrid.Location = new System.Drawing.Point(237, 391);
            this.KombiDataGrid.Name = "KombiDataGrid";
            this.KombiDataGrid.Size = new System.Drawing.Size(217, 128);
            this.KombiDataGrid.TabIndex = 22;
            // 
            // MotorDataGrid
            // 
            this.MotorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MotorDataGrid.Location = new System.Drawing.Point(493, 391);
            this.MotorDataGrid.Name = "MotorDataGrid";
            this.MotorDataGrid.Size = new System.Drawing.Size(217, 128);
            this.MotorDataGrid.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Moč (kW)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Menjalnik";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Število Vrat";
            // 
            // TBMoč
            // 
            this.TBMoč.Location = new System.Drawing.Point(157, 170);
            this.TBMoč.Name = "TBMoč";
            this.TBMoč.Size = new System.Drawing.Size(100, 20);
            this.TBMoč.TabIndex = 27;
            // 
            // TBŠteviloVrat
            // 
            this.TBŠteviloVrat.Location = new System.Drawing.Point(507, 172);
            this.TBŠteviloVrat.Name = "TBŠteviloVrat";
            this.TBŠteviloVrat.Size = new System.Drawing.Size(100, 20);
            this.TBŠteviloVrat.TabIndex = 28;
            // 
            // CBMenjalnik
            // 
            this.CBMenjalnik.FormattingEnabled = true;
            this.CBMenjalnik.Items.AddRange(new object[] {
            "avtomatski",
            "ročni"});
            this.CBMenjalnik.Location = new System.Drawing.Point(279, 171);
            this.CBMenjalnik.Name = "CBMenjalnik";
            this.CBMenjalnik.Size = new System.Drawing.Size(87, 21);
            this.CBMenjalnik.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Tip Goriva";
            // 
            // CBTipGoriva
            // 
            this.CBTipGoriva.FormattingEnabled = true;
            this.CBTipGoriva.Items.AddRange(new object[] {
            "dizel",
            "bencin"});
            this.CBTipGoriva.Location = new System.Drawing.Point(394, 172);
            this.CBTipGoriva.Name = "CBTipGoriva";
            this.CBTipGoriva.Size = new System.Drawing.Size(87, 21);
            this.CBTipGoriva.TabIndex = 31;
            // 
            // KupiVozilo
            // 
            this.KupiVozilo.Location = new System.Drawing.Point(493, 632);
            this.KupiVozilo.Name = "KupiVozilo";
            this.KupiVozilo.Size = new System.Drawing.Size(135, 48);
            this.KupiVozilo.TabIndex = 32;
            this.KupiVozilo.Text = "Kupi vozilo";
            this.KupiVozilo.UseVisualStyleBackColor = true;
            this.KupiVozilo.Click += new System.EventHandler(this.KupiVozilo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 650);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Stanje:";
            // 
            // StanjeNaDenarnici
            // 
            this.StanjeNaDenarnici.AutoSize = true;
            this.StanjeNaDenarnici.Location = new System.Drawing.Point(317, 651);
            this.StanjeNaDenarnici.Name = "StanjeNaDenarnici";
            this.StanjeNaDenarnici.Size = new System.Drawing.Size(41, 13);
            this.StanjeNaDenarnici.TabIndex = 34;
            this.StanjeNaDenarnici.Text = "label13";
            // 
            // TBoblika
            // 
            this.TBoblika.Location = new System.Drawing.Point(629, 172);
            this.TBoblika.Name = "TBoblika";
            this.TBoblika.Size = new System.Drawing.Size(100, 20);
            this.TBoblika.TabIndex = 35;
            // 
            // Oblika
            // 
            this.Oblika.AutoSize = true;
            this.Oblika.Location = new System.Drawing.Point(656, 147);
            this.Oblika.Name = "Oblika";
            this.Oblika.Size = new System.Drawing.Size(37, 13);
            this.Oblika.TabIndex = 36;
            this.Oblika.Text = "Oblika";
            this.Oblika.Click += new System.EventHandler(this.label13_Click);
            // 
            // Čipiran
            // 
            this.Čipiran.AutoSize = true;
            this.Čipiran.Location = new System.Drawing.Point(773, 148);
            this.Čipiran.Name = "Čipiran";
            this.Čipiran.Size = new System.Drawing.Size(39, 13);
            this.Čipiran.TabIndex = 37;
            this.Čipiran.Text = "Čipiran";
            // 
            // CBČipiran
            // 
            this.CBČipiran.FormattingEnabled = true;
            this.CBČipiran.Items.AddRange(new object[] {
            "true",
            "false"});
            this.CBČipiran.Location = new System.Drawing.Point(746, 172);
            this.CBČipiran.Name = "CBČipiran";
            this.CBČipiran.Size = new System.Drawing.Size(100, 21);
            this.CBČipiran.TabIndex = 38;
            this.CBČipiran.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Priklop
            // 
            this.Priklop.AutoSize = true;
            this.Priklop.Location = new System.Drawing.Point(200, 580);
            this.Priklop.Name = "Priklop";
            this.Priklop.Size = new System.Drawing.Size(39, 13);
            this.Priklop.TabIndex = 40;
            this.Priklop.Text = "Priklop";
            // 
            // Nosilnost
            // 
            this.Nosilnost.AutoSize = true;
            this.Nosilnost.Location = new System.Drawing.Point(83, 579);
            this.Nosilnost.Name = "Nosilnost";
            this.Nosilnost.Size = new System.Drawing.Size(50, 13);
            this.Nosilnost.TabIndex = 39;
            this.Nosilnost.Text = "Nosilnost";
            // 
            // TBpriklop
            // 
            this.TBpriklop.Location = new System.Drawing.Point(175, 602);
            this.TBpriklop.Name = "TBpriklop";
            this.TBpriklop.Size = new System.Drawing.Size(100, 20);
            this.TBpriklop.TabIndex = 42;
            // 
            // TBnosilnost
            // 
            this.TBnosilnost.Location = new System.Drawing.Point(53, 602);
            this.TBnosilnost.Name = "TBnosilnost";
            this.TBnosilnost.Size = new System.Drawing.Size(100, 20);
            this.TBnosilnost.TabIndex = 41;
            // 
            // TBprostornina
            // 
            this.TBprostornina.Location = new System.Drawing.Point(307, 602);
            this.TBprostornina.Name = "TBprostornina";
            this.TBprostornina.Size = new System.Drawing.Size(100, 20);
            this.TBprostornina.TabIndex = 44;
            // 
            // ProstorninaCCM
            // 
            this.ProstorninaCCM.AutoSize = true;
            this.ProstorninaCCM.Location = new System.Drawing.Point(317, 580);
            this.ProstorninaCCM.Name = "ProstorninaCCM";
            this.ProstorninaCCM.Size = new System.Drawing.Size(89, 13);
            this.ProstorninaCCM.TabIndex = 43;
            this.ProstorninaCCM.Text = "Prostornina (ccm)";
            // 
            // TBvisina
            // 
            this.TBvisina.Location = new System.Drawing.Point(610, 580);
            this.TBvisina.Name = "TBvisina";
            this.TBvisina.Size = new System.Drawing.Size(100, 20);
            this.TBvisina.TabIndex = 48;
            // 
            // TBprtljaga
            // 
            this.TBprtljaga.Location = new System.Drawing.Point(488, 580);
            this.TBprtljaga.Name = "TBprtljaga";
            this.TBprtljaga.Size = new System.Drawing.Size(100, 20);
            this.TBprtljaga.TabIndex = 47;
            // 
            // Višina
            // 
            this.Višina.AutoSize = true;
            this.Višina.Location = new System.Drawing.Point(635, 558);
            this.Višina.Name = "Višina";
            this.Višina.Size = new System.Drawing.Size(35, 13);
            this.Višina.TabIndex = 46;
            this.Višina.Text = "Višina";
            // 
            // ProstorninaPrtljage
            // 
            this.ProstorninaPrtljage.AutoSize = true;
            this.ProstorninaPrtljage.Location = new System.Drawing.Point(491, 558);
            this.ProstorninaPrtljage.Name = "ProstorninaPrtljage";
            this.ProstorninaPrtljage.Size = new System.Drawing.Size(95, 13);
            this.ProstorninaPrtljage.TabIndex = 45;
            this.ProstorninaPrtljage.Text = "ProstorninaPrtljage";
            // 
            // ImaŽlico
            // 
            this.ImaŽlico.FormattingEnabled = true;
            this.ImaŽlico.Items.AddRange(new object[] {
            "true",
            "false"});
            this.ImaŽlico.Location = new System.Drawing.Point(776, 659);
            this.ImaŽlico.Name = "ImaŽlico";
            this.ImaŽlico.Size = new System.Drawing.Size(100, 21);
            this.ImaŽlico.TabIndex = 52;
            // 
            // Žlica
            // 
            this.Žlica.AutoSize = true;
            this.Žlica.Location = new System.Drawing.Point(798, 635);
            this.Žlica.Name = "Žlica";
            this.Žlica.Size = new System.Drawing.Size(50, 13);
            this.Žlica.TabIndex = 51;
            this.Žlica.Text = "Ima Žlico";
            // 
            // ŠirinaPriklopa
            // 
            this.ŠirinaPriklopa.AutoSize = true;
            this.ŠirinaPriklopa.Location = new System.Drawing.Point(672, 635);
            this.ŠirinaPriklopa.Name = "ŠirinaPriklopa";
            this.ŠirinaPriklopa.Size = new System.Drawing.Size(74, 13);
            this.ŠirinaPriklopa.TabIndex = 50;
            this.ŠirinaPriklopa.Text = "Širina Priklopa";
            // 
            // TBŠirinaPriklopa
            // 
            this.TBŠirinaPriklopa.Location = new System.Drawing.Point(659, 659);
            this.TBŠirinaPriklopa.Name = "TBŠirinaPriklopa";
            this.TBŠirinaPriklopa.Size = new System.Drawing.Size(100, 20);
            this.TBŠirinaPriklopa.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 754);
            this.Controls.Add(this.ImaŽlico);
            this.Controls.Add(this.Žlica);
            this.Controls.Add(this.ŠirinaPriklopa);
            this.Controls.Add(this.TBŠirinaPriklopa);
            this.Controls.Add(this.TBvisina);
            this.Controls.Add(this.TBprtljaga);
            this.Controls.Add(this.Višina);
            this.Controls.Add(this.ProstorninaPrtljage);
            this.Controls.Add(this.TBprostornina);
            this.Controls.Add(this.ProstorninaCCM);
            this.Controls.Add(this.TBpriklop);
            this.Controls.Add(this.TBnosilnost);
            this.Controls.Add(this.Priklop);
            this.Controls.Add(this.Nosilnost);
            this.Controls.Add(this.CBČipiran);
            this.Controls.Add(this.Čipiran);
            this.Controls.Add(this.Oblika);
            this.Controls.Add(this.TBoblika);
            this.Controls.Add(this.StanjeNaDenarnici);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.KupiVozilo);
            this.Controls.Add(this.CBTipGoriva);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CBMenjalnik);
            this.Controls.Add(this.TBŠteviloVrat);
            this.Controls.Add(this.TBMoč);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MotorDataGrid);
            this.Controls.Add(this.KombiDataGrid);
            this.Controls.Add(this.TraktorDataGrid);
            this.Controls.Add(this.TovornjakDataGrid);
            this.Controls.Add(this.DodajOglas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBbarva);
            this.Controls.Add(this.TBcena);
            this.Controls.Add(this.TBletnik);
            this.Controls.Add(this.TBmodel);
            this.Controls.Add(this.TBznamka);
            this.Controls.Add(this.RadioMotor);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.RadioTraktor);
            this.Controls.Add(this.RadioTovornjak);
            this.Controls.Add(this.RadioAvto);
            this.Controls.Add(this.AvtoDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AvtoDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TovornjakDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraktorDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KombiDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotorDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AvtoDataGrid;
        private System.Windows.Forms.RadioButton RadioAvto;
        private System.Windows.Forms.RadioButton RadioTovornjak;
        private System.Windows.Forms.RadioButton RadioTraktor;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton RadioMotor;
        private System.Windows.Forms.TextBox TBznamka;
        private System.Windows.Forms.TextBox TBmodel;
        private System.Windows.Forms.TextBox TBletnik;
        private System.Windows.Forms.TextBox TBcena;
        private System.Windows.Forms.TextBox TBbarva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DodajOglas;
        private System.Windows.Forms.DataGridView TovornjakDataGrid;
        private System.Windows.Forms.DataGridView TraktorDataGrid;
        private System.Windows.Forms.DataGridView KombiDataGrid;
        private System.Windows.Forms.DataGridView MotorDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBMoč;
        private System.Windows.Forms.TextBox TBŠteviloVrat;
        private System.Windows.Forms.ComboBox CBMenjalnik;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CBTipGoriva;
        private System.Windows.Forms.Button KupiVozilo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label StanjeNaDenarnici;
        private System.Windows.Forms.TextBox TBoblika;
        private System.Windows.Forms.Label Oblika;
        private System.Windows.Forms.Label Čipiran;
        private System.Windows.Forms.ComboBox CBČipiran;
        private System.Windows.Forms.Label Priklop;
        private System.Windows.Forms.Label Nosilnost;
        private System.Windows.Forms.TextBox TBpriklop;
        private System.Windows.Forms.TextBox TBnosilnost;
        private System.Windows.Forms.TextBox TBprostornina;
        private System.Windows.Forms.Label ProstorninaCCM;
        private System.Windows.Forms.TextBox TBvisina;
        private System.Windows.Forms.TextBox TBprtljaga;
        private System.Windows.Forms.Label Višina;
        private System.Windows.Forms.Label ProstorninaPrtljage;
        private System.Windows.Forms.ComboBox ImaŽlico;
        private System.Windows.Forms.Label Žlica;
        private System.Windows.Forms.Label ŠirinaPriklopa;
        private System.Windows.Forms.TextBox TBŠirinaPriklopa;
    }
}

