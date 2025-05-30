namespace personeltakip
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabAnasayfa = new TabPage();
            dataGridViewDepartmanlar = new DataGridView();
            labelTarihSaat = new Label();
            lblPersonelSayisi = new Label();
            lblDepartmanSayisi = new Label();
            button1 = new Button();
            label1 = new Label();
            tabPersislem = new TabPage();
            prsBastrh = new DateTimePicker();
            btnGuncelle = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            guncelMaas = new TextBox();
            guncelMesai = new TextBox();
            guncelSigno = new TextBox();
            guncelTel = new TextBox();
            guncelYas = new TextBox();
            guncelDep = new ComboBox();
            persSil = new Button();
            prsEkle = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            comPrsDep = new ComboBox();
            prsSigno = new TextBox();
            prsTel = new TextBox();
            prsYas = new TextBox();
            prsAd = new TextBox();
            listBox1 = new ListBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabMesai = new TabPage();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label19 = new Label();
            tabDep = new TabPage();
            txtDepMaas = new TextBox();
            label23 = new Label();
            label22 = new Label();
            btnFiltrele = new Button();
            listBox2 = new ListBox();
            comboDepFiltre = new ComboBox();
            label21 = new Label();
            btnDepSil = new Button();
            label20 = new Label();
            listBoxDepartmanlar = new ListBox();
            txtYeniDepartman = new TextBox();
            btnDepEkle = new Button();
            label5 = new Label();
            tabKatilim = new TabPage();
            label12 = new Label();
            listBoxTarihSonuc = new ListBox();
            btnTarihKontrol = new Button();
            dtTarihSec = new DateTimePicker();
            timerSaat = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabAnasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartmanlar).BeginInit();
            tabPersislem.SuspendLayout();
            tabMesai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabDep.SuspendLayout();
            tabKatilim.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAnasayfa);
            tabControl1.Controls.Add(tabPersislem);
            tabControl1.Controls.Add(tabMesai);
            tabControl1.Controls.Add(tabDep);
            tabControl1.Controls.Add(tabKatilim);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1257, 574);
            tabControl1.TabIndex = 0;
            // 
            // tabAnasayfa
            // 
            tabAnasayfa.BackColor = Color.Bisque;
            tabAnasayfa.Controls.Add(dataGridViewDepartmanlar);
            tabAnasayfa.Controls.Add(labelTarihSaat);
            tabAnasayfa.Controls.Add(lblPersonelSayisi);
            tabAnasayfa.Controls.Add(lblDepartmanSayisi);
            tabAnasayfa.Controls.Add(button1);
            tabAnasayfa.Controls.Add(label1);
            tabAnasayfa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabAnasayfa.Location = new Point(4, 34);
            tabAnasayfa.Name = "tabAnasayfa";
            tabAnasayfa.Padding = new Padding(3);
            tabAnasayfa.Size = new Size(1249, 536);
            tabAnasayfa.TabIndex = 0;
            tabAnasayfa.Text = "ANASAYFA";
            // 
            // dataGridViewDepartmanlar
            // 
            dataGridViewDepartmanlar.AllowUserToAddRows = false;
            dataGridViewDepartmanlar.AllowUserToDeleteRows = false;
            dataGridViewDepartmanlar.BackgroundColor = Color.Bisque;
            dataGridViewDepartmanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartmanlar.Location = new Point(415, 149);
            dataGridViewDepartmanlar.Name = "dataGridViewDepartmanlar";
            dataGridViewDepartmanlar.ReadOnly = true;
            dataGridViewDepartmanlar.RowHeadersWidth = 62;
            dataGridViewDepartmanlar.Size = new Size(410, 232);
            dataGridViewDepartmanlar.TabIndex = 1;
            // 
            // labelTarihSaat
            // 
            labelTarihSaat.AutoSize = true;
            labelTarihSaat.Location = new Point(19, 20);
            labelTarihSaat.Name = "labelTarihSaat";
            labelTarihSaat.Size = new Size(0, 25);
            labelTarihSaat.TabIndex = 4;
            labelTarihSaat.Click += labelTarihSaat_Click;
            // 
            // lblPersonelSayisi
            // 
            lblPersonelSayisi.AutoSize = true;
            lblPersonelSayisi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPersonelSayisi.Location = new Point(498, 77);
            lblPersonelSayisi.Name = "lblPersonelSayisi";
            lblPersonelSayisi.Size = new Size(182, 30);
            lblPersonelSayisi.TabIndex = 3;
            lblPersonelSayisi.Text = "Personel Sayısı: 0";
            // 
            // lblDepartmanSayisi
            // 
            lblDepartmanSayisi.AutoSize = true;
            lblDepartmanSayisi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDepartmanSayisi.Location = new Point(267, 77);
            lblDepartmanSayisi.Name = "lblDepartmanSayisi";
            lblDepartmanSayisi.Size = new Size(209, 30);
            lblDepartmanSayisi.TabIndex = 2;
            lblDepartmanSayisi.Text = "Departman Sayısı: 0";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(592, 444);
            button1.Name = "button1";
            button1.Size = new Size(148, 58);
            button1.TabIndex = 1;
            button1.Text = "ÇIKIŞ YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(576, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 0;
            label1.Text = "ANASAYFA";
            // 
            // tabPersislem
            // 
            tabPersislem.BackColor = Color.Bisque;
            tabPersislem.Controls.Add(prsBastrh);
            tabPersislem.Controls.Add(btnGuncelle);
            tabPersislem.Controls.Add(label13);
            tabPersislem.Controls.Add(label14);
            tabPersislem.Controls.Add(label15);
            tabPersislem.Controls.Add(label16);
            tabPersislem.Controls.Add(label17);
            tabPersislem.Controls.Add(label18);
            tabPersislem.Controls.Add(guncelMaas);
            tabPersislem.Controls.Add(guncelMesai);
            tabPersislem.Controls.Add(guncelSigno);
            tabPersislem.Controls.Add(guncelTel);
            tabPersislem.Controls.Add(guncelYas);
            tabPersislem.Controls.Add(guncelDep);
            tabPersislem.Controls.Add(persSil);
            tabPersislem.Controls.Add(prsEkle);
            tabPersislem.Controls.Add(label11);
            tabPersislem.Controls.Add(label10);
            tabPersislem.Controls.Add(label9);
            tabPersislem.Controls.Add(label8);
            tabPersislem.Controls.Add(label7);
            tabPersislem.Controls.Add(label6);
            tabPersislem.Controls.Add(comPrsDep);
            tabPersislem.Controls.Add(prsSigno);
            tabPersislem.Controls.Add(prsTel);
            tabPersislem.Controls.Add(prsYas);
            tabPersislem.Controls.Add(prsAd);
            tabPersislem.Controls.Add(listBox1);
            tabPersislem.Controls.Add(label4);
            tabPersislem.Controls.Add(label3);
            tabPersislem.Controls.Add(label2);
            tabPersislem.Location = new Point(4, 34);
            tabPersislem.Name = "tabPersislem";
            tabPersislem.Padding = new Padding(3);
            tabPersislem.Size = new Size(1249, 536);
            tabPersislem.TabIndex = 1;
            tabPersislem.Text = "PERSONEL İŞLEMLERİ";
            // 
            // prsBastrh
            // 
            prsBastrh.Format = DateTimePickerFormat.Custom;
            prsBastrh.Location = new Point(968, 311);
            prsBastrh.Name = "prsBastrh";
            prsBastrh.Size = new Size(248, 31);
            prsBastrh.TabIndex = 41;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Teal;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(455, 332);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(158, 67);
            btnGuncelle.TabIndex = 40;
            btnGuncelle.Text = "⟳ PERSONELİ GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(349, 243);
            label13.Name = "label13";
            label13.Size = new Size(78, 28);
            label13.TabIndex = 39;
            label13.Text = "MAAŞ :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(316, 279);
            label14.Name = "label14";
            label14.Size = new Size(109, 28);
            label14.TabIndex = 38;
            label14.Text = "EK MESAİ :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(287, 208);
            label15.Name = "label15";
            label15.Size = new Size(140, 28);
            label15.TabIndex = 37;
            label15.Text = "SİGORTA NO :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(337, 159);
            label16.Name = "label16";
            label16.Size = new Size(90, 28);
            label16.TabIndex = 36;
            label16.Text = "TEL NO :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(370, 114);
            label17.Name = "label17";
            label17.Size = new Size(57, 28);
            label17.TabIndex = 35;
            label17.Text = "YAŞ :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(287, 64);
            label18.Name = "label18";
            label18.Size = new Size(140, 28);
            label18.TabIndex = 34;
            label18.Text = "DEPARTMAN :";
            // 
            // guncelMaas
            // 
            guncelMaas.Location = new Point(431, 242);
            guncelMaas.Name = "guncelMaas";
            guncelMaas.Size = new Size(182, 31);
            guncelMaas.TabIndex = 32;
            // 
            // guncelMesai
            // 
            guncelMesai.Location = new Point(431, 279);
            guncelMesai.Name = "guncelMesai";
            guncelMesai.Size = new Size(182, 31);
            guncelMesai.TabIndex = 31;
            // 
            // guncelSigno
            // 
            guncelSigno.Location = new Point(433, 205);
            guncelSigno.Name = "guncelSigno";
            guncelSigno.Size = new Size(182, 31);
            guncelSigno.TabIndex = 30;
            // 
            // guncelTel
            // 
            guncelTel.Location = new Point(433, 162);
            guncelTel.Name = "guncelTel";
            guncelTel.Size = new Size(182, 31);
            guncelTel.TabIndex = 29;
            // 
            // guncelYas
            // 
            guncelYas.Location = new Point(431, 118);
            guncelYas.Name = "guncelYas";
            guncelYas.Size = new Size(182, 31);
            guncelYas.TabIndex = 28;
            // 
            // guncelDep
            // 
            guncelDep.FormattingEnabled = true;
            guncelDep.Items.AddRange(new object[] { "Backend Development", "Frontend Development", "Full-stack Development", "İnsan kaynakları", "Project Manager", "Müşteri Temsilcisi" });
            guncelDep.Location = new Point(431, 72);
            guncelDep.Name = "guncelDep";
            guncelDep.Size = new Size(182, 33);
            guncelDep.TabIndex = 27;
            // 
            // persSil
            // 
            persSil.BackColor = Color.Red;
            persSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            persSil.ForeColor = Color.Transparent;
            persSil.Location = new Point(40, 454);
            persSil.Name = "persSil";
            persSil.Size = new Size(181, 45);
            persSil.TabIndex = 20;
            persSil.Text = "− PERSONELİ SİL";
            persSil.UseVisualStyleBackColor = false;
            persSil.Click += persSil_Click;
            // 
            // prsEkle
            // 
            prsEkle.BackColor = Color.FromArgb(0, 192, 0);
            prsEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prsEkle.ForeColor = Color.White;
            prsEkle.Location = new Point(982, 372);
            prsEkle.Name = "prsEkle";
            prsEkle.Size = new Size(195, 64);
            prsEkle.TabIndex = 19;
            prsEkle.Text = "➕ PERSONELİ EKLE";
            prsEkle.UseVisualStyleBackColor = false;
            prsEkle.Click += prsEkle_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(773, 313);
            label11.Name = "label11";
            label11.Size = new Size(182, 28);
            label11.TabIndex = 16;
            label11.Text = "BAŞLAMA TARİHİ :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(815, 270);
            label10.Name = "label10";
            label10.Size = new Size(140, 28);
            label10.TabIndex = 15;
            label10.Text = "SİGORTA NO :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(865, 221);
            label9.Name = "label9";
            label9.Size = new Size(90, 28);
            label9.TabIndex = 14;
            label9.Text = "TEL NO :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(898, 176);
            label8.Name = "label8";
            label8.Size = new Size(57, 28);
            label8.TabIndex = 13;
            label8.Text = "YAŞ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(815, 126);
            label7.Name = "label7";
            label7.Size = new Size(140, 28);
            label7.TabIndex = 12;
            label7.Text = "DEPARTMAN :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(822, 80);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 11;
            label6.Text = "AD - SOYAD :";
            // 
            // comPrsDep
            // 
            comPrsDep.FormattingEnabled = true;
            comPrsDep.Items.AddRange(new object[] { "Backend Development", "Frontend Development", "Full-stack Development", "İnsan kaynakları", "Project Manager", "Müşteri Temsilcisi" });
            comPrsDep.Location = new Point(968, 126);
            comPrsDep.Name = "comPrsDep";
            comPrsDep.Size = new Size(182, 33);
            comPrsDep.TabIndex = 10;
            // 
            // prsSigno
            // 
            prsSigno.Location = new Point(968, 267);
            prsSigno.Name = "prsSigno";
            prsSigno.Size = new Size(182, 31);
            prsSigno.TabIndex = 8;
            prsSigno.TextChanged += prsSigno_TextChanged;
            // 
            // prsTel
            // 
            prsTel.Location = new Point(968, 221);
            prsTel.Name = "prsTel";
            prsTel.Size = new Size(182, 31);
            prsTel.TabIndex = 7;
            prsTel.TextChanged += prsTel_TextChanged;
            // 
            // prsYas
            // 
            prsYas.Location = new Point(968, 176);
            prsYas.Name = "prsYas";
            prsYas.Size = new Size(182, 31);
            prsYas.TabIndex = 6;
            prsYas.TextChanged += prsYas_TextChanged;
            // 
            // prsAd
            // 
            prsAd.Location = new Point(968, 80);
            prsAd.Name = "prsAd";
            prsAd.Size = new Size(182, 31);
            prsAd.TabIndex = 5;
            prsAd.TextChanged += prsAd_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(27, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 379);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(982, 31);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 2;
            label4.Text = "PERSONEL EKLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(419, 31);
            label3.Name = "label3";
            label3.Size = new Size(208, 28);
            label3.TabIndex = 1;
            label3.Text = "PERSONEL GÜNCELLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 16);
            label2.Name = "label2";
            label2.Size = new Size(178, 28);
            label2.TabIndex = 0;
            label2.Text = "PERSONEL LİSTESİ";
            // 
            // tabMesai
            // 
            tabMesai.BackColor = Color.Bisque;
            tabMesai.Controls.Add(button2);
            tabMesai.Controls.Add(dataGridView1);
            tabMesai.Controls.Add(label19);
            tabMesai.Font = new Font("Segoe UI", 10F);
            tabMesai.Location = new Point(4, 34);
            tabMesai.Name = "tabMesai";
            tabMesai.Size = new Size(1249, 536);
            tabMesai.TabIndex = 2;
            tabMesai.Text = "MESAİ TAKİBİ";
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(456, 478);
            button2.Name = "button2";
            button2.Size = new Size(410, 46);
            button2.TabIndex = 2;
            button2.Text = "GÜNLÜK KATILIM DURUMUNU GÖR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1222, 397);
            dataGridView1.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label19.Location = new Point(548, 24);
            label19.Name = "label19";
            label19.Size = new Size(162, 32);
            label19.TabIndex = 0;
            label19.Text = "MESAİ TAKİBİ";
            // 
            // tabDep
            // 
            tabDep.BackColor = Color.Bisque;
            tabDep.Controls.Add(txtDepMaas);
            tabDep.Controls.Add(label23);
            tabDep.Controls.Add(label22);
            tabDep.Controls.Add(btnFiltrele);
            tabDep.Controls.Add(listBox2);
            tabDep.Controls.Add(comboDepFiltre);
            tabDep.Controls.Add(label21);
            tabDep.Controls.Add(btnDepSil);
            tabDep.Controls.Add(label20);
            tabDep.Controls.Add(listBoxDepartmanlar);
            tabDep.Controls.Add(txtYeniDepartman);
            tabDep.Controls.Add(btnDepEkle);
            tabDep.Controls.Add(label5);
            tabDep.Location = new Point(4, 34);
            tabDep.Name = "tabDep";
            tabDep.Padding = new Padding(3);
            tabDep.Size = new Size(1249, 536);
            tabDep.TabIndex = 3;
            tabDep.Text = "DEPARTMAN İŞLEMLERİ";
            // 
            // txtDepMaas
            // 
            txtDepMaas.Location = new Point(511, 200);
            txtDepMaas.Name = "txtDepMaas";
            txtDepMaas.Size = new Size(271, 31);
            txtDepMaas.TabIndex = 12;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(417, 206);
            label23.Name = "label23";
            label23.Size = new Size(71, 25);
            label23.TabIndex = 11;
            label23.Text = "MAAŞ :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(364, 136);
            label22.Name = "label22";
            label22.Size = new Size(124, 25);
            label22.TabIndex = 10;
            label22.Text = "DEPARTMAN :";
            // 
            // btnFiltrele
            // 
            btnFiltrele.BackColor = Color.FromArgb(0, 192, 0);
            btnFiltrele.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrele.ForeColor = Color.White;
            btnFiltrele.Location = new Point(994, 389);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(121, 44);
            btnFiltrele.TabIndex = 9;
            btnFiltrele.Text = "GÖR";
            btnFiltrele.UseVisualStyleBackColor = false;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(920, 174);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(252, 179);
            listBox2.TabIndex = 8;
            // 
            // comboDepFiltre
            // 
            comboDepFiltre.FormattingEnabled = true;
            comboDepFiltre.Location = new Point(920, 89);
            comboDepFiltre.Name = "comboDepFiltre";
            comboDepFiltre.Size = new Size(252, 33);
            comboDepFiltre.TabIndex = 7;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(884, 30);
            label21.Name = "label21";
            label21.Size = new Size(316, 30);
            label21.TabIndex = 6;
            label21.Text = "DEPARTMAN BİLGİLERİNİ GÖR";
            // 
            // btnDepSil
            // 
            btnDepSil.BackColor = Color.Red;
            btnDepSil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepSil.ForeColor = Color.White;
            btnDepSil.Location = new Point(111, 429);
            btnDepSil.Name = "btnDepSil";
            btnDepSil.Size = new Size(206, 42);
            btnDepSil.TabIndex = 5;
            btnDepSil.Text = " − DEPARTMANI SİL";
            btnDepSil.UseVisualStyleBackColor = false;
            btnDepSil.Click += btnDepSil_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(74, 30);
            label20.Name = "label20";
            label20.Size = new Size(273, 30);
            label20.TabIndex = 4;
            label20.Text = "GÜNCEL DEPARTMANLAR";
            // 
            // listBoxDepartmanlar
            // 
            listBoxDepartmanlar.FormattingEnabled = true;
            listBoxDepartmanlar.ItemHeight = 25;
            listBoxDepartmanlar.Location = new Point(111, 77);
            listBoxDepartmanlar.Name = "listBoxDepartmanlar";
            listBoxDepartmanlar.Size = new Size(180, 329);
            listBoxDepartmanlar.TabIndex = 3;
            // 
            // txtYeniDepartman
            // 
            txtYeniDepartman.Location = new Point(511, 133);
            txtYeniDepartman.Name = "txtYeniDepartman";
            txtYeniDepartman.Size = new Size(271, 31);
            txtYeniDepartman.TabIndex = 2;
            // 
            // btnDepEkle
            // 
            btnDepEkle.BackColor = Color.FromArgb(0, 192, 0);
            btnDepEkle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepEkle.ForeColor = Color.White;
            btnDepEkle.Location = new Point(532, 267);
            btnDepEkle.Name = "btnDepEkle";
            btnDepEkle.Size = new Size(236, 39);
            btnDepEkle.TabIndex = 1;
            btnDepEkle.Text = "➕ DEPARTMANI EKLE";
            btnDepEkle.UseVisualStyleBackColor = false;
            btnDepEkle.Click += btnDepEkle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(511, 30);
            label5.Name = "label5";
            label5.Size = new Size(195, 30);
            label5.TabIndex = 0;
            label5.Text = "DEPARTMAN EKLE";
            // 
            // tabKatilim
            // 
            tabKatilim.BackColor = Color.Bisque;
            tabKatilim.Controls.Add(label12);
            tabKatilim.Controls.Add(listBoxTarihSonuc);
            tabKatilim.Controls.Add(btnTarihKontrol);
            tabKatilim.Controls.Add(dtTarihSec);
            tabKatilim.Location = new Point(4, 34);
            tabKatilim.Name = "tabKatilim";
            tabKatilim.Padding = new Padding(3);
            tabKatilim.Size = new Size(1249, 536);
            tabKatilim.TabIndex = 4;
            tabKatilim.Text = "KATILIM DURUMU";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(502, 53);
            label12.Name = "label12";
            label12.Size = new Size(117, 30);
            label12.TabIndex = 3;
            label12.Text = "TARİH SEÇ";
            // 
            // listBoxTarihSonuc
            // 
            listBoxTarihSonuc.FormattingEnabled = true;
            listBoxTarihSonuc.ItemHeight = 25;
            listBoxTarihSonuc.Location = new Point(99, 99);
            listBoxTarihSonuc.Name = "listBoxTarihSonuc";
            listBoxTarihSonuc.Size = new Size(235, 354);
            listBoxTarihSonuc.TabIndex = 2;
            // 
            // btnTarihKontrol
            // 
            btnTarihKontrol.BackColor = Color.FromArgb(0, 192, 0);
            btnTarihKontrol.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarihKontrol.ForeColor = Color.White;
            btnTarihKontrol.Location = new Point(477, 146);
            btnTarihKontrol.Name = "btnTarihKontrol";
            btnTarihKontrol.Size = new Size(174, 51);
            btnTarihKontrol.TabIndex = 1;
            btnTarihKontrol.Text = "KATILIMI GÖR";
            btnTarihKontrol.UseVisualStyleBackColor = false;
            btnTarihKontrol.Click += btnTarihKontrol_Click;
            // 
            // dtTarihSec
            // 
            dtTarihSec.Location = new Point(420, 99);
            dtTarihSec.Name = "dtTarihSec";
            dtTarihSec.Size = new Size(279, 31);
            dtTarihSec.TabIndex = 0;
            // 
            // timerSaat
            // 
            timerSaat.Enabled = true;
            timerSaat.Interval = 1000;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 570);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabAnasayfa.ResumeLayout(false);
            tabAnasayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartmanlar).EndInit();
            tabPersislem.ResumeLayout(false);
            tabPersislem.PerformLayout();
            tabMesai.ResumeLayout(false);
            tabMesai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabDep.ResumeLayout(false);
            tabDep.PerformLayout();
            tabKatilim.ResumeLayout(false);
            tabKatilim.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPersislem;
        private TabPage tabMesai;
        private ListBox listBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox prsSigno;
        private TextBox prsTel;
        private TextBox prsYas;
        private TextBox prsAd;
        private Label label6;
        private ComboBox comPrsDep;
        private Button prsEkle;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button persSil;
        private TextBox guncelMaas;
        private TextBox guncelMesai;
        private TextBox guncelSigno;
        private TextBox guncelTel;
        private TextBox guncelYas;
        private ComboBox guncelDep;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button btnGuncelle;
        private TabPage tabDep;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label19;
        private Button btnDepSil;
        private Label label20;
        private ListBox listBoxDepartmanlar;
        private TextBox txtYeniDepartman;
        private Button btnDepEkle;
        private Label label5;
        private Button btnFiltrele;
        private ListBox listBox2;
        private ComboBox comboDepFiltre;
        private Label label21;
        private Label label23;
        private Label label22;
        private TextBox txtDepMaas;
        private TabPage tabKatilim;
        private ListBox listBoxTarihSonuc;
        private Button btnTarihKontrol;
        private DateTimePicker dtTarihSec;
        private Label label12;
        private TabPage tabAnasayfa;
        private Label lblPersonelSayisi;
        private Label lblDepartmanSayisi;
        private Button button1;
        private Label label1;
        private DateTimePicker prsBastrh;
        private Label labelTarihSaat;
        private System.Windows.Forms.Timer timerSaat;
        private DataGridView dataGridViewDepartmanlar;
    }
}