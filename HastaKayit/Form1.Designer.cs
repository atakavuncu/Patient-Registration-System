namespace HastaKayit
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonHastaneTanimla = new System.Windows.Forms.Button();
            this.buttonHastaTanimla = new System.Windows.Forms.Button();
            this.buttonDoktorTanimla = new System.Windows.Forms.Button();
            this.buttonRandevuOlusturma = new System.Windows.Forms.Button();
            this.buttonTeshisKayit = new System.Windows.Forms.Button();
            this.buttonTestTahlil = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHastaneTanimlama = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bolumler = new System.Windows.Forms.ListBox();
            this.buttonBolumEkle = new System.Windows.Forms.Button();
            this.textBoxHastaneBolum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxHastaneTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownHastaneDoktorSayisi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxHastaneSehir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKayitliHastaneler = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHastaneAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageHastaTanimlama = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonKadin = new System.Windows.Forms.RadioButton();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.textBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxKayitliHastalar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxMeslek = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxHastaAdi = new System.Windows.Forms.TextBox();
            this.textBoxHastaSoyadi = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxTamAdi = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPageDoktorTanimlama = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.uzmanlikAlanlari = new System.Windows.Forms.CheckedListBox();
            this.dateTimePickerDoktorDogum = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxDoktor = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKayitliDoktorlar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDoktorAdi = new System.Windows.Forms.TextBox();
            this.textBoxDoktorSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxDoktorTamAdi = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPageRandevuOlusturma = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dateTimePickerRandevuSaat = new System.Windows.Forms.DateTimePicker();
            this.label38 = new System.Windows.Forms.Label();
            this.dateTimePickerRandevuTarih = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxRandevuDoktorAdi = new System.Windows.Forms.TextBox();
            this.textBoxRandevuHastaneAdi = new System.Windows.Forms.TextBox();
            this.textBoxRandevuBolumAdi = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBoxKayitliRandevular = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBoxRandevuHastaAdi = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tabPageTeshisKayit = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBoxKayitliTeshisler = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTeshis = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.dateTimePickerTeshisTarih = new System.Windows.Forms.DateTimePicker();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxTeshisDoktorAdi = new System.Windows.Forms.TextBox();
            this.textBoxTeshisHastaneAdi = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxTeshisHastaAdi = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tabPageTestTahlil = new System.Windows.Forms.TabPage();
            this.labelSeciliDosya = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textBoxKayitliTestler = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.textBoxTestAdi = new System.Windows.Forms.TextBox();
            this.textBoxTestHastaneAdi = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.textBoxTestHastaAdi = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSekmeleriKapat = new System.Windows.Forms.Button();
            this.buttonSifirla = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageHastaneTanimlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHastaneDoktorSayisi)).BeginInit();
            this.tabPageHastaTanimlama.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.tabPageDoktorTanimlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoktor)).BeginInit();
            this.tabPageRandevuOlusturma.SuspendLayout();
            this.tabPageTeshisKayit.SuspendLayout();
            this.tabPageTestTahlil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHastaneTanimla
            // 
            this.buttonHastaneTanimla.Location = new System.Drawing.Point(15, 15);
            this.buttonHastaneTanimla.Margin = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.buttonHastaneTanimla.Name = "buttonHastaneTanimla";
            this.buttonHastaneTanimla.Size = new System.Drawing.Size(145, 40);
            this.buttonHastaneTanimla.TabIndex = 1;
            this.buttonHastaneTanimla.Text = "Hastane Tanımlama";
            this.buttonHastaneTanimla.UseVisualStyleBackColor = true;
            this.buttonHastaneTanimla.Click += new System.EventHandler(this.buttonHastaneTanimla_Click);
            // 
            // buttonHastaTanimla
            // 
            this.buttonHastaTanimla.Location = new System.Drawing.Point(15, 70);
            this.buttonHastaTanimla.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHastaTanimla.Name = "buttonHastaTanimla";
            this.buttonHastaTanimla.Size = new System.Drawing.Size(145, 40);
            this.buttonHastaTanimla.TabIndex = 0;
            this.buttonHastaTanimla.Text = "Hasta Tanımlama";
            this.buttonHastaTanimla.UseVisualStyleBackColor = true;
            this.buttonHastaTanimla.Click += new System.EventHandler(this.buttonHastaTanimla_Click);
            // 
            // buttonDoktorTanimla
            // 
            this.buttonDoktorTanimla.Location = new System.Drawing.Point(15, 125);
            this.buttonDoktorTanimla.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDoktorTanimla.Name = "buttonDoktorTanimla";
            this.buttonDoktorTanimla.Size = new System.Drawing.Size(145, 40);
            this.buttonDoktorTanimla.TabIndex = 2;
            this.buttonDoktorTanimla.Text = "Doktor Tanımlama";
            this.buttonDoktorTanimla.UseVisualStyleBackColor = true;
            this.buttonDoktorTanimla.Click += new System.EventHandler(this.buttonDoktorTanimla_Click);
            // 
            // buttonRandevuOlusturma
            // 
            this.buttonRandevuOlusturma.Location = new System.Drawing.Point(15, 180);
            this.buttonRandevuOlusturma.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRandevuOlusturma.Name = "buttonRandevuOlusturma";
            this.buttonRandevuOlusturma.Size = new System.Drawing.Size(145, 40);
            this.buttonRandevuOlusturma.TabIndex = 3;
            this.buttonRandevuOlusturma.Text = "Randevu Oluşturma";
            this.buttonRandevuOlusturma.UseVisualStyleBackColor = true;
            this.buttonRandevuOlusturma.Click += new System.EventHandler(this.buttonRandevuOlusturma_Click);
            // 
            // buttonTeshisKayit
            // 
            this.buttonTeshisKayit.Location = new System.Drawing.Point(15, 235);
            this.buttonTeshisKayit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTeshisKayit.Name = "buttonTeshisKayit";
            this.buttonTeshisKayit.Size = new System.Drawing.Size(145, 40);
            this.buttonTeshisKayit.TabIndex = 4;
            this.buttonTeshisKayit.Text = "Teşhis Kayıt";
            this.buttonTeshisKayit.UseVisualStyleBackColor = true;
            this.buttonTeshisKayit.Click += new System.EventHandler(this.buttonTeshisKayit_Click);
            // 
            // buttonTestTahlil
            // 
            this.buttonTestTahlil.Location = new System.Drawing.Point(15, 290);
            this.buttonTestTahlil.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTestTahlil.Name = "buttonTestTahlil";
            this.buttonTestTahlil.Size = new System.Drawing.Size(145, 40);
            this.buttonTestTahlil.TabIndex = 5;
            this.buttonTestTahlil.Text = "Test Tahlil";
            this.buttonTestTahlil.UseVisualStyleBackColor = true;
            this.buttonTestTahlil.Click += new System.EventHandler(this.buttonTestTahlil_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(15, 15);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(100, 45);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(130, 15);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(100, 45);
            this.buttonGuncelle.TabIndex = 3;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(245, 15);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(100, 45);
            this.buttonSil.TabIndex = 5;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.buttonHastaneTanimla);
            this.panel1.Controls.Add(this.buttonHastaTanimla);
            this.panel1.Controls.Add(this.buttonTestTahlil);
            this.panel1.Controls.Add(this.buttonTeshisKayit);
            this.panel1.Controls.Add(this.buttonDoktorTanimla);
            this.panel1.Controls.Add(this.buttonRandevuOlusturma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 609);
            this.panel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHastaneTanimlama);
            this.tabControl1.Controls.Add(this.tabPageHastaTanimlama);
            this.tabControl1.Controls.Add(this.tabPageDoktorTanimlama);
            this.tabControl1.Controls.Add(this.tabPageRandevuOlusturma);
            this.tabControl1.Controls.Add(this.tabPageTeshisKayit);
            this.tabControl1.Controls.Add(this.tabPageTestTahlil);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 494);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageHastaneTanimlama
            // 
            this.tabPageHastaneTanimlama.Controls.Add(this.button5);
            this.tabPageHastaneTanimlama.Controls.Add(this.button6);
            this.tabPageHastaneTanimlama.Controls.Add(this.bolumler);
            this.tabPageHastaneTanimlama.Controls.Add(this.buttonBolumEkle);
            this.tabPageHastaneTanimlama.Controls.Add(this.textBoxHastaneBolum);
            this.tabPageHastaneTanimlama.Controls.Add(this.label5);
            this.tabPageHastaneTanimlama.Controls.Add(this.maskedTextBoxHastaneTelefon);
            this.tabPageHastaneTanimlama.Controls.Add(this.label4);
            this.tabPageHastaneTanimlama.Controls.Add(this.numericUpDownHastaneDoktorSayisi);
            this.tabPageHastaneTanimlama.Controls.Add(this.label3);
            this.tabPageHastaneTanimlama.Controls.Add(this.comboBoxHastaneSehir);
            this.tabPageHastaneTanimlama.Controls.Add(this.label1);
            this.tabPageHastaneTanimlama.Controls.Add(this.textBoxKayitliHastaneler);
            this.tabPageHastaneTanimlama.Controls.Add(this.label2);
            this.tabPageHastaneTanimlama.Controls.Add(this.textBoxHastaneAdi);
            this.tabPageHastaneTanimlama.Controls.Add(this.label10);
            this.tabPageHastaneTanimlama.Location = new System.Drawing.Point(4, 25);
            this.tabPageHastaneTanimlama.Name = "tabPageHastaneTanimlama";
            this.tabPageHastaneTanimlama.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHastaneTanimlama.Size = new System.Drawing.Size(879, 465);
            this.tabPageHastaneTanimlama.TabIndex = 0;
            this.tabPageHastaneTanimlama.Text = "Hastane Tanımlama";
            this.tabPageHastaneTanimlama.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(599, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 26);
            this.button5.TabIndex = 91;
            this.button5.Text = "Yazı Fontu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(694, 409);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 26);
            this.button6.TabIndex = 90;
            this.button6.Text = "Yazı Rengi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bolumler
            // 
            this.bolumler.FormattingEnabled = true;
            this.bolumler.ItemHeight = 16;
            this.bolumler.Location = new System.Drawing.Point(430, 65);
            this.bolumler.Name = "bolumler";
            this.bolumler.Size = new System.Drawing.Size(246, 100);
            this.bolumler.TabIndex = 89;
            // 
            // buttonBolumEkle
            // 
            this.buttonBolumEkle.Location = new System.Drawing.Point(601, 25);
            this.buttonBolumEkle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBolumEkle.Name = "buttonBolumEkle";
            this.buttonBolumEkle.Size = new System.Drawing.Size(75, 25);
            this.buttonBolumEkle.TabIndex = 64;
            this.buttonBolumEkle.Text = "Ekle";
            this.buttonBolumEkle.UseVisualStyleBackColor = true;
            this.buttonBolumEkle.Click += new System.EventHandler(this.buttonBolumEkle_Click);
            // 
            // textBoxHastaneBolum
            // 
            this.textBoxHastaneBolum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxHastaneBolum.Location = new System.Drawing.Point(430, 25);
            this.textBoxHastaneBolum.Name = "textBoxHastaneBolum";
            this.textBoxHastaneBolum.Size = new System.Drawing.Size(150, 26);
            this.textBoxHastaneBolum.TabIndex = 63;
            this.toolTip1.SetToolTip(this.textBoxHastaneBolum, "Hastanede Aktif Görev Yapan Bölümleri Giriniz");
            this.textBoxHastaneBolum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHastaneBolum_KeyDown);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(335, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Bölümler:";
            // 
            // maskedTextBoxHastaneTelefon
            // 
            this.maskedTextBoxHastaneTelefon.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxHastaneTelefon.Location = new System.Drawing.Point(156, 140);
            this.maskedTextBoxHastaneTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxHastaneTelefon.Name = "maskedTextBoxHastaneTelefon";
            this.maskedTextBoxHastaneTelefon.Size = new System.Drawing.Size(150, 26);
            this.maskedTextBoxHastaneTelefon.TabIndex = 62;
            this.toolTip1.SetToolTip(this.maskedTextBoxHastaneTelefon, "Hastanenin Telefon Numarası");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Telefon:";
            // 
            // numericUpDownHastaneDoktorSayisi
            // 
            this.numericUpDownHastaneDoktorSayisi.Location = new System.Drawing.Point(156, 102);
            this.numericUpDownHastaneDoktorSayisi.Name = "numericUpDownHastaneDoktorSayisi";
            this.numericUpDownHastaneDoktorSayisi.Size = new System.Drawing.Size(150, 22);
            this.numericUpDownHastaneDoktorSayisi.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "Doktor Sayısı:";
            // 
            // comboBoxHastaneSehir
            // 
            this.comboBoxHastaneSehir.FormattingEnabled = true;
            this.comboBoxHastaneSehir.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Adana",
            "Bursa",
            "Antalya",
            "Muğla",
            "Gaziantep"});
            this.comboBoxHastaneSehir.Location = new System.Drawing.Point(156, 65);
            this.comboBoxHastaneSehir.Name = "comboBoxHastaneSehir";
            this.comboBoxHastaneSehir.Size = new System.Drawing.Size(150, 24);
            this.comboBoxHastaneSehir.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "Şehir:";
            // 
            // textBoxKayitliHastaneler
            // 
            this.textBoxKayitliHastaneler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKayitliHastaneler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKayitliHastaneler.Location = new System.Drawing.Point(29, 234);
            this.textBoxKayitliHastaneler.Multiline = true;
            this.textBoxKayitliHastaneler.Name = "textBoxKayitliHastaneler";
            this.textBoxKayitliHastaneler.ReadOnly = true;
            this.textBoxKayitliHastaneler.Size = new System.Drawing.Size(786, 210);
            this.textBoxKayitliHastaneler.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "Kayıtlı Hastaneler:";
            // 
            // textBoxHastaneAdi
            // 
            this.textBoxHastaneAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxHastaneAdi.Location = new System.Drawing.Point(156, 25);
            this.textBoxHastaneAdi.Name = "textBoxHastaneAdi";
            this.textBoxHastaneAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxHastaneAdi.TabIndex = 59;
            this.toolTip1.SetToolTip(this.textBoxHastaneAdi, "Hastanenin Adı");
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(25, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 67;
            this.label10.Text = "Hastane Adı:";
            // 
            // tabPageHastaTanimlama
            // 
            this.tabPageHastaTanimlama.Controls.Add(this.button4);
            this.tabPageHastaTanimlama.Controls.Add(this.button3);
            this.tabPageHastaTanimlama.Controls.Add(this.groupBox1);
            this.tabPageHastaTanimlama.Controls.Add(this.groupBox);
            this.tabPageHastaTanimlama.Controls.Add(this.textBoxTelefon);
            this.tabPageHastaTanimlama.Controls.Add(this.label30);
            this.tabPageHastaTanimlama.Controls.Add(this.textBoxKayitliHastalar);
            this.tabPageHastaTanimlama.Controls.Add(this.label12);
            this.tabPageHastaTanimlama.Controls.Add(this.textBoxEmail);
            this.tabPageHastaTanimlama.Controls.Add(this.label29);
            this.tabPageHastaTanimlama.Controls.Add(this.textBoxMeslek);
            this.tabPageHastaTanimlama.Controls.Add(this.label28);
            this.tabPageHastaTanimlama.Controls.Add(this.label14);
            this.tabPageHastaTanimlama.Controls.Add(this.label15);
            this.tabPageHastaTanimlama.Controls.Add(this.textBoxAdres);
            this.tabPageHastaTanimlama.Controls.Add(this.textBoxHastaAdi);
            this.tabPageHastaTanimlama.Controls.Add(this.textBoxHastaSoyadi);
            this.tabPageHastaTanimlama.Controls.Add(this.label27);
            this.tabPageHastaTanimlama.Controls.Add(this.textBoxTamAdi);
            this.tabPageHastaTanimlama.Controls.Add(this.label23);
            this.tabPageHastaTanimlama.Controls.Add(this.label16);
            this.tabPageHastaTanimlama.Controls.Add(this.label22);
            this.tabPageHastaTanimlama.Controls.Add(this.label17);
            this.tabPageHastaTanimlama.Controls.Add(this.label21);
            this.tabPageHastaTanimlama.Controls.Add(this.label18);
            this.tabPageHastaTanimlama.Controls.Add(this.label13);
            this.tabPageHastaTanimlama.Controls.Add(this.label19);
            this.tabPageHastaTanimlama.Controls.Add(this.label20);
            this.tabPageHastaTanimlama.Location = new System.Drawing.Point(4, 25);
            this.tabPageHastaTanimlama.Name = "tabPageHastaTanimlama";
            this.tabPageHastaTanimlama.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHastaTanimlama.Size = new System.Drawing.Size(879, 465);
            this.tabPageHastaTanimlama.TabIndex = 1;
            this.tabPageHastaTanimlama.Text = "Hasta Tanımlama";
            this.tabPageHastaTanimlama.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(599, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 26);
            this.button4.TabIndex = 61;
            this.button4.Text = "Yazı Fontu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(694, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 26);
            this.button3.TabIndex = 60;
            this.button3.Text = "Yazı Rengi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(386, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 25);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kadın";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonKadin_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(132, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 25);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Erkek";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtonErkek_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonKadin);
            this.groupBox.Controls.Add(this.radioButtonErkek);
            this.groupBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox.Location = new System.Drawing.Point(386, 135);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(235, 71);
            this.groupBox.TabIndex = 59;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Cinsiyet";
            // 
            // radioButtonKadin
            // 
            this.radioButtonKadin.AutoSize = true;
            this.radioButtonKadin.Location = new System.Drawing.Point(32, 33);
            this.radioButtonKadin.Name = "radioButtonKadin";
            this.radioButtonKadin.Size = new System.Drawing.Size(73, 24);
            this.radioButtonKadin.TabIndex = 6;
            this.radioButtonKadin.TabStop = true;
            this.radioButtonKadin.Text = "Kadın";
            this.radioButtonKadin.UseVisualStyleBackColor = true;
            this.radioButtonKadin.CheckedChanged += new System.EventHandler(this.radioButtonKadin_CheckedChanged);
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(132, 33);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(74, 24);
            this.radioButtonErkek.TabIndex = 7;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            this.radioButtonErkek.CheckedChanged += new System.EventHandler(this.radioButtonErkek_CheckedChanged);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTelefon.Location = new System.Drawing.Point(471, 60);
            this.textBoxTelefon.Mask = "(999) 000-0000";
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(150, 26);
            this.textBoxTelefon.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(25, 240);
            this.label30.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(120, 21);
            this.label30.TabIndex = 55;
            this.label30.Text = "Kayıtlı Hastalar:";
            // 
            // textBoxKayitliHastalar
            // 
            this.textBoxKayitliHastalar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxKayitliHastalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKayitliHastalar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKayitliHastalar.Location = new System.Drawing.Point(29, 273);
            this.textBoxKayitliHastalar.Multiline = true;
            this.textBoxKayitliHastalar.Name = "textBoxKayitliHastalar";
            this.textBoxKayitliHastalar.ReadOnly = true;
            this.textBoxKayitliHastalar.Size = new System.Drawing.Size(765, 176);
            this.textBoxKayitliHastalar.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(25, 240);
            this.label12.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "Kayıtlı Hastalar";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEmail.Location = new System.Drawing.Point(471, 25);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(150, 26);
            this.textBoxEmail.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(382, 95);
            this.label29.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 25);
            this.label29.TabIndex = 49;
            this.label29.Text = "Meslek:";
            // 
            // textBoxMeslek
            // 
            this.textBoxMeslek.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMeslek.Location = new System.Drawing.Point(471, 95);
            this.textBoxMeslek.Name = "textBoxMeslek";
            this.textBoxMeslek.Size = new System.Drawing.Size(150, 26);
            this.textBoxMeslek.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(382, 60);
            this.label28.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 25);
            this.label28.TabIndex = 48;
            this.label28.Text = "Telefon:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.Location = new System.Drawing.Point(382, 95);
            this.label14.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 25);
            this.label14.TabIndex = 49;
            this.label14.Text = "Meslek:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label15.Location = new System.Drawing.Point(382, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 25);
            this.label15.TabIndex = 48;
            this.label15.Text = "Telefon:";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdres.Location = new System.Drawing.Point(156, 131);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(150, 75);
            this.textBoxAdres.TabIndex = 2;
            // 
            // textBoxHastaAdi
            // 
            this.textBoxHastaAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxHastaAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxHastaAdi.Location = new System.Drawing.Point(156, 25);
            this.textBoxHastaAdi.Name = "textBoxHastaAdi";
            this.textBoxHastaAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxHastaAdi.TabIndex = 0;
            this.textBoxHastaAdi.Leave += new System.EventHandler(this.textBoxHastaAdi_Leave);
            // 
            // textBoxHastaSoyadi
            // 
            this.textBoxHastaSoyadi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxHastaSoyadi.Location = new System.Drawing.Point(156, 60);
            this.textBoxHastaSoyadi.Name = "textBoxHastaSoyadi";
            this.textBoxHastaSoyadi.Size = new System.Drawing.Size(150, 26);
            this.textBoxHastaSoyadi.TabIndex = 1;
            this.textBoxHastaSoyadi.Leave += new System.EventHandler(this.textBoxHastaSoyadi_Leave);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(382, 25);
            this.label27.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 25);
            this.label27.TabIndex = 43;
            this.label27.Text = "E-mail:";
            // 
            // textBoxTamAdi
            // 
            this.textBoxTamAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTamAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTamAdi.Location = new System.Drawing.Point(156, 95);
            this.textBoxTamAdi.Name = "textBoxTamAdi";
            this.textBoxTamAdi.ReadOnly = true;
            this.textBoxTamAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxTamAdi.TabIndex = 44;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(25, 130);
            this.label23.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 25);
            this.label23.TabIndex = 42;
            this.label23.Text = "Adresi:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label16.Location = new System.Drawing.Point(382, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = "E-mail:";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(25, 95);
            this.label22.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 25);
            this.label22.TabIndex = 41;
            this.label22.Text = "Hasta Tam Adı:";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label17.Location = new System.Drawing.Point(25, 130);
            this.label17.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 25);
            this.label17.TabIndex = 42;
            this.label17.Text = "Adresi:";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(25, 60);
            this.label21.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(127, 25);
            this.label21.TabIndex = 40;
            this.label21.Text = "Hasta Soyadı:";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label18.Location = new System.Drawing.Point(25, 95);
            this.label18.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 25);
            this.label18.TabIndex = 41;
            this.label18.Text = "Hasta Tam Adı:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(25, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "Hasta Adı:";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label19.Location = new System.Drawing.Point(25, 60);
            this.label19.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 25);
            this.label19.TabIndex = 40;
            this.label19.Text = "Hasta Soyadı:";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label20.Location = new System.Drawing.Point(25, 25);
            this.label20.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 25);
            this.label20.TabIndex = 39;
            this.label20.Text = "Hasta Adı:";
            // 
            // tabPageDoktorTanimlama
            // 
            this.tabPageDoktorTanimlama.Controls.Add(this.button7);
            this.tabPageDoktorTanimlama.Controls.Add(this.button8);
            this.tabPageDoktorTanimlama.Controls.Add(this.label9);
            this.tabPageDoktorTanimlama.Controls.Add(this.uzmanlikAlanlari);
            this.tabPageDoktorTanimlama.Controls.Add(this.dateTimePickerDoktorDogum);
            this.tabPageDoktorTanimlama.Controls.Add(this.label8);
            this.tabPageDoktorTanimlama.Controls.Add(this.pictureBoxDoktor);
            this.tabPageDoktorTanimlama.Controls.Add(this.label6);
            this.tabPageDoktorTanimlama.Controls.Add(this.textBoxKayitliDoktorlar);
            this.tabPageDoktorTanimlama.Controls.Add(this.label7);
            this.tabPageDoktorTanimlama.Controls.Add(this.textBoxDoktorAdi);
            this.tabPageDoktorTanimlama.Controls.Add(this.textBoxDoktorSoyadi);
            this.tabPageDoktorTanimlama.Controls.Add(this.textBoxDoktorTamAdi);
            this.tabPageDoktorTanimlama.Controls.Add(this.label24);
            this.tabPageDoktorTanimlama.Controls.Add(this.label25);
            this.tabPageDoktorTanimlama.Controls.Add(this.label26);
            this.tabPageDoktorTanimlama.Location = new System.Drawing.Point(4, 25);
            this.tabPageDoktorTanimlama.Name = "tabPageDoktorTanimlama";
            this.tabPageDoktorTanimlama.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoktorTanimlama.Size = new System.Drawing.Size(879, 465);
            this.tabPageDoktorTanimlama.TabIndex = 2;
            this.tabPageDoktorTanimlama.Text = "Doktor Tanımlama";
            this.tabPageDoktorTanimlama.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(597, 412);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 26);
            this.button7.TabIndex = 85;
            this.button7.Text = "Yazı Fontu";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(692, 412);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 26);
            this.button8.TabIndex = 84;
            this.button8.Text = "Yazı Rengi";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(420, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 25);
            this.label9.TabIndex = 83;
            this.label9.Text = "Uzmanlık Alanları:";
            // 
            // uzmanlikAlanlari
            // 
            this.uzmanlikAlanlari.FormattingEnabled = true;
            this.uzmanlikAlanlari.Items.AddRange(new object[] {
            "Dahiliye",
            "Genel Cerrahi",
            "Nöroloji",
            "Ortopedi",
            "Kadın Doğum",
            "Göz Hastalıkları",
            "Kulak Burun Boğaz"});
            this.uzmanlikAlanlari.Location = new System.Drawing.Point(424, 61);
            this.uzmanlikAlanlari.Name = "uzmanlikAlanlari";
            this.uzmanlikAlanlari.Size = new System.Drawing.Size(196, 123);
            this.uzmanlikAlanlari.TabIndex = 62;
            // 
            // dateTimePickerDoktorDogum
            // 
            this.dateTimePickerDoktorDogum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDoktorDogum.Location = new System.Drawing.Point(205, 145);
            this.dateTimePickerDoktorDogum.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDoktorDogum.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDoktorDogum.Name = "dateTimePickerDoktorDogum";
            this.dateTimePickerDoktorDogum.Size = new System.Drawing.Size(150, 22);
            this.dateTimePickerDoktorDogum.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 80;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // pictureBoxDoktor
            // 
            this.pictureBoxDoktor.BackColor = System.Drawing.Color.White;
            this.pictureBoxDoktor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoktor.Image")));
            this.pictureBoxDoktor.Location = new System.Drawing.Point(685, 62);
            this.pictureBoxDoktor.Name = "pictureBoxDoktor";
            this.pictureBoxDoktor.Size = new System.Drawing.Size(105, 105);
            this.pictureBoxDoktor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDoktor.TabIndex = 79;
            this.pictureBoxDoktor.TabStop = false;
            this.pictureBoxDoktor.Click += new System.EventHandler(this.pictureBoxDoktor_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(681, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 78;
            this.label6.Text = "Fotoğraf:";
            // 
            // textBoxKayitliDoktorlar
            // 
            this.textBoxKayitliDoktorlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKayitliDoktorlar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKayitliDoktorlar.Location = new System.Drawing.Point(29, 235);
            this.textBoxKayitliDoktorlar.Multiline = true;
            this.textBoxKayitliDoktorlar.Name = "textBoxKayitliDoktorlar";
            this.textBoxKayitliDoktorlar.ReadOnly = true;
            this.textBoxKayitliDoktorlar.Size = new System.Drawing.Size(765, 214);
            this.textBoxKayitliDoktorlar.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 76;
            this.label7.Text = "Kayıtlı Doktorlar:";
            // 
            // textBoxDoktorAdi
            // 
            this.textBoxDoktorAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDoktorAdi.Location = new System.Drawing.Point(205, 25);
            this.textBoxDoktorAdi.Name = "textBoxDoktorAdi";
            this.textBoxDoktorAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxDoktorAdi.TabIndex = 59;
            this.textBoxDoktorAdi.TextChanged += new System.EventHandler(this.textBoxDoktorAdi_TextChanged);
            // 
            // textBoxDoktorSoyadi
            // 
            this.textBoxDoktorSoyadi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDoktorSoyadi.Location = new System.Drawing.Point(205, 65);
            this.textBoxDoktorSoyadi.Name = "textBoxDoktorSoyadi";
            this.textBoxDoktorSoyadi.Size = new System.Drawing.Size(150, 26);
            this.textBoxDoktorSoyadi.TabIndex = 60;
            this.textBoxDoktorSoyadi.TextChanged += new System.EventHandler(this.textBoxDoktorSoyadi_TextChanged);
            // 
            // textBoxDoktorTamAdi
            // 
            this.textBoxDoktorTamAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDoktorTamAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDoktorTamAdi.Location = new System.Drawing.Point(205, 105);
            this.textBoxDoktorTamAdi.Name = "textBoxDoktorTamAdi";
            this.textBoxDoktorTamAdi.ReadOnly = true;
            this.textBoxDoktorTamAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxDoktorTamAdi.TabIndex = 72;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(25, 105);
            this.label24.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(160, 25);
            this.label24.TabIndex = 69;
            this.label24.Text = "Doktor Tam Adı:";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(25, 65);
            this.label25.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(141, 25);
            this.label25.TabIndex = 68;
            this.label25.Text = "Doktor Soyadı:";
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(25, 25);
            this.label26.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(141, 25);
            this.label26.TabIndex = 67;
            this.label26.Text = "Doktor Adı:";
            // 
            // tabPageRandevuOlusturma
            // 
            this.tabPageRandevuOlusturma.Controls.Add(this.button9);
            this.tabPageRandevuOlusturma.Controls.Add(this.button10);
            this.tabPageRandevuOlusturma.Controls.Add(this.dateTimePickerRandevuSaat);
            this.tabPageRandevuOlusturma.Controls.Add(this.label38);
            this.tabPageRandevuOlusturma.Controls.Add(this.dateTimePickerRandevuTarih);
            this.tabPageRandevuOlusturma.Controls.Add(this.label33);
            this.tabPageRandevuOlusturma.Controls.Add(this.textBoxRandevuDoktorAdi);
            this.tabPageRandevuOlusturma.Controls.Add(this.textBoxRandevuHastaneAdi);
            this.tabPageRandevuOlusturma.Controls.Add(this.textBoxRandevuBolumAdi);
            this.tabPageRandevuOlusturma.Controls.Add(this.label32);
            this.tabPageRandevuOlusturma.Controls.Add(this.label34);
            this.tabPageRandevuOlusturma.Controls.Add(this.label35);
            this.tabPageRandevuOlusturma.Controls.Add(this.textBoxKayitliRandevular);
            this.tabPageRandevuOlusturma.Controls.Add(this.label36);
            this.tabPageRandevuOlusturma.Controls.Add(this.textBoxRandevuHastaAdi);
            this.tabPageRandevuOlusturma.Controls.Add(this.label37);
            this.tabPageRandevuOlusturma.Location = new System.Drawing.Point(4, 25);
            this.tabPageRandevuOlusturma.Name = "tabPageRandevuOlusturma";
            this.tabPageRandevuOlusturma.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRandevuOlusturma.Size = new System.Drawing.Size(879, 465);
            this.tabPageRandevuOlusturma.TabIndex = 3;
            this.tabPageRandevuOlusturma.Text = "Randevu Oluşturma";
            this.tabPageRandevuOlusturma.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(598, 407);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 26);
            this.button9.TabIndex = 111;
            this.button9.Text = "Yazı Fontu";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(693, 407);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 26);
            this.button10.TabIndex = 110;
            this.button10.Text = "Yazı Rengi";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dateTimePickerRandevuSaat
            // 
            this.dateTimePickerRandevuSaat.CustomFormat = "hh:mm";
            this.dateTimePickerRandevuSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerRandevuSaat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerRandevuSaat.Location = new System.Drawing.Point(430, 102);
            this.dateTimePickerRandevuSaat.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerRandevuSaat.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerRandevuSaat.Name = "dateTimePickerRandevuSaat";
            this.dateTimePickerRandevuSaat.ShowUpDown = true;
            this.dateTimePickerRandevuSaat.Size = new System.Drawing.Size(150, 22);
            this.dateTimePickerRandevuSaat.TabIndex = 95;
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(335, 100);
            this.label38.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(88, 25);
            this.label38.TabIndex = 108;
            this.label38.Text = "Saat:";
            // 
            // dateTimePickerRandevuTarih
            // 
            this.dateTimePickerRandevuTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRandevuTarih.Location = new System.Drawing.Point(430, 68);
            this.dateTimePickerRandevuTarih.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerRandevuTarih.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerRandevuTarih.Name = "dateTimePickerRandevuTarih";
            this.dateTimePickerRandevuTarih.Size = new System.Drawing.Size(150, 22);
            this.dateTimePickerRandevuTarih.TabIndex = 94;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(335, 66);
            this.label33.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(88, 25);
            this.label33.TabIndex = 106;
            this.label33.Text = "Tarih:";
            // 
            // textBoxRandevuDoktorAdi
            // 
            this.textBoxRandevuDoktorAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRandevuDoktorAdi.Location = new System.Drawing.Point(156, 100);
            this.textBoxRandevuDoktorAdi.Name = "textBoxRandevuDoktorAdi";
            this.textBoxRandevuDoktorAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxRandevuDoktorAdi.TabIndex = 92;
            // 
            // textBoxRandevuHastaneAdi
            // 
            this.textBoxRandevuHastaneAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRandevuHastaneAdi.Location = new System.Drawing.Point(156, 65);
            this.textBoxRandevuHastaneAdi.Name = "textBoxRandevuHastaneAdi";
            this.textBoxRandevuHastaneAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxRandevuHastaneAdi.TabIndex = 91;
            // 
            // textBoxRandevuBolumAdi
            // 
            this.textBoxRandevuBolumAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRandevuBolumAdi.Location = new System.Drawing.Point(430, 25);
            this.textBoxRandevuBolumAdi.Name = "textBoxRandevuBolumAdi";
            this.textBoxRandevuBolumAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxRandevuBolumAdi.TabIndex = 93;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(335, 25);
            this.label32.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(92, 25);
            this.label32.TabIndex = 100;
            this.label32.Text = "Bölüm:";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(25, 100);
            this.label34.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(123, 25);
            this.label34.TabIndex = 96;
            this.label34.Text = "Doktor Adı:";
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(25, 65);
            this.label35.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(123, 25);
            this.label35.TabIndex = 94;
            this.label35.Text = "Hastane Adı:";
            // 
            // textBoxKayitliRandevular
            // 
            this.textBoxKayitliRandevular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKayitliRandevular.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKayitliRandevular.Location = new System.Drawing.Point(29, 190);
            this.textBoxKayitliRandevular.Multiline = true;
            this.textBoxKayitliRandevular.Name = "textBoxKayitliRandevular";
            this.textBoxKayitliRandevular.ReadOnly = true;
            this.textBoxKayitliRandevular.Size = new System.Drawing.Size(765, 254);
            this.textBoxKayitliRandevular.TabIndex = 96;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(25, 159);
            this.label36.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(142, 21);
            this.label36.TabIndex = 92;
            this.label36.Text = "Kayıtlı Randevular:";
            // 
            // textBoxRandevuHastaAdi
            // 
            this.textBoxRandevuHastaAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRandevuHastaAdi.Location = new System.Drawing.Point(156, 25);
            this.textBoxRandevuHastaAdi.Name = "textBoxRandevuHastaAdi";
            this.textBoxRandevuHastaAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxRandevuHastaAdi.TabIndex = 90;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(25, 25);
            this.label37.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(123, 25);
            this.label37.TabIndex = 91;
            this.label37.Text = "Hasta Adı:";
            // 
            // tabPageTeshisKayit
            // 
            this.tabPageTeshisKayit.Controls.Add(this.button11);
            this.tabPageTeshisKayit.Controls.Add(this.button12);
            this.tabPageTeshisKayit.Controls.Add(this.textBoxKayitliTeshisler);
            this.tabPageTeshisKayit.Controls.Add(this.label44);
            this.tabPageTeshisKayit.Controls.Add(this.button1);
            this.tabPageTeshisKayit.Controls.Add(this.textBoxTeshis);
            this.tabPageTeshisKayit.Controls.Add(this.label43);
            this.tabPageTeshisKayit.Controls.Add(this.dateTimePickerTeshisTarih);
            this.tabPageTeshisKayit.Controls.Add(this.label42);
            this.tabPageTeshisKayit.Controls.Add(this.textBoxTeshisDoktorAdi);
            this.tabPageTeshisKayit.Controls.Add(this.textBoxTeshisHastaneAdi);
            this.tabPageTeshisKayit.Controls.Add(this.label39);
            this.tabPageTeshisKayit.Controls.Add(this.label40);
            this.tabPageTeshisKayit.Controls.Add(this.textBoxTeshisHastaAdi);
            this.tabPageTeshisKayit.Controls.Add(this.label41);
            this.tabPageTeshisKayit.Location = new System.Drawing.Point(4, 25);
            this.tabPageTeshisKayit.Name = "tabPageTeshisKayit";
            this.tabPageTeshisKayit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeshisKayit.Size = new System.Drawing.Size(879, 465);
            this.tabPageTeshisKayit.TabIndex = 4;
            this.tabPageTeshisKayit.Text = "Teşhis Kayıt";
            this.tabPageTeshisKayit.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(597, 406);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 26);
            this.button11.TabIndex = 120;
            this.button11.Text = "Yazı Fontu";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(692, 406);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 26);
            this.button12.TabIndex = 119;
            this.button12.Text = "Yazı Rengi";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBoxKayitliTeshisler
            // 
            this.textBoxKayitliTeshisler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKayitliTeshisler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKayitliTeshisler.Location = new System.Drawing.Point(29, 200);
            this.textBoxKayitliTeshisler.Multiline = true;
            this.textBoxKayitliTeshisler.Name = "textBoxKayitliTeshisler";
            this.textBoxKayitliTeshisler.ReadOnly = true;
            this.textBoxKayitliTeshisler.Size = new System.Drawing.Size(765, 243);
            this.textBoxKayitliTeshisler.TabIndex = 112;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label44.Location = new System.Drawing.Point(25, 165);
            this.label44.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(124, 21);
            this.label44.TabIndex = 117;
            this.label44.Text = "Kayıtlı Teşhisler:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 111;
            this.button1.Text = "Dosya Olarak Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTeshis
            // 
            this.textBoxTeshis.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTeshis.Location = new System.Drawing.Point(430, 65);
            this.textBoxTeshis.Multiline = true;
            this.textBoxTeshis.Name = "textBoxTeshis";
            this.textBoxTeshis.Size = new System.Drawing.Size(150, 75);
            this.textBoxTeshis.TabIndex = 110;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label43.Location = new System.Drawing.Point(335, 65);
            this.label43.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(88, 25);
            this.label43.TabIndex = 114;
            this.label43.Text = "Teşhis:";
            // 
            // dateTimePickerTeshisTarih
            // 
            this.dateTimePickerTeshisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTeshisTarih.Location = new System.Drawing.Point(430, 27);
            this.dateTimePickerTeshisTarih.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerTeshisTarih.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTeshisTarih.Name = "dateTimePickerTeshisTarih";
            this.dateTimePickerTeshisTarih.Size = new System.Drawing.Size(150, 22);
            this.dateTimePickerTeshisTarih.TabIndex = 109;
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.Location = new System.Drawing.Point(335, 25);
            this.label42.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(88, 25);
            this.label42.TabIndex = 112;
            this.label42.Text = "Tarih:";
            // 
            // textBoxTeshisDoktorAdi
            // 
            this.textBoxTeshisDoktorAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTeshisDoktorAdi.Location = new System.Drawing.Point(156, 100);
            this.textBoxTeshisDoktorAdi.Name = "textBoxTeshisDoktorAdi";
            this.textBoxTeshisDoktorAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxTeshisDoktorAdi.TabIndex = 108;
            // 
            // textBoxTeshisHastaneAdi
            // 
            this.textBoxTeshisHastaneAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTeshisHastaneAdi.Location = new System.Drawing.Point(156, 65);
            this.textBoxTeshisHastaneAdi.Name = "textBoxTeshisHastaneAdi";
            this.textBoxTeshisHastaneAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxTeshisHastaneAdi.TabIndex = 107;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.Location = new System.Drawing.Point(25, 100);
            this.label39.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(123, 25);
            this.label39.TabIndex = 109;
            this.label39.Text = "Doktor Adı:";
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(25, 65);
            this.label40.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(123, 25);
            this.label40.TabIndex = 108;
            this.label40.Text = "Hastane Adı:";
            // 
            // textBoxTeshisHastaAdi
            // 
            this.textBoxTeshisHastaAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTeshisHastaAdi.Location = new System.Drawing.Point(156, 25);
            this.textBoxTeshisHastaAdi.Name = "textBoxTeshisHastaAdi";
            this.textBoxTeshisHastaAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxTeshisHastaAdi.TabIndex = 106;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.Location = new System.Drawing.Point(25, 25);
            this.label41.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(123, 25);
            this.label41.TabIndex = 107;
            this.label41.Text = "Hasta Adı:";
            // 
            // tabPageTestTahlil
            // 
            this.tabPageTestTahlil.Controls.Add(this.buttonSifirla);
            this.tabPageTestTahlil.Controls.Add(this.labelSeciliDosya);
            this.tabPageTestTahlil.Controls.Add(this.button13);
            this.tabPageTestTahlil.Controls.Add(this.button14);
            this.tabPageTestTahlil.Controls.Add(this.textBoxKayitliTestler);
            this.tabPageTestTahlil.Controls.Add(this.label45);
            this.tabPageTestTahlil.Controls.Add(this.button2);
            this.tabPageTestTahlil.Controls.Add(this.label47);
            this.tabPageTestTahlil.Controls.Add(this.textBoxTestAdi);
            this.tabPageTestTahlil.Controls.Add(this.textBoxTestHastaneAdi);
            this.tabPageTestTahlil.Controls.Add(this.label48);
            this.tabPageTestTahlil.Controls.Add(this.label49);
            this.tabPageTestTahlil.Controls.Add(this.textBoxTestHastaAdi);
            this.tabPageTestTahlil.Controls.Add(this.label50);
            this.tabPageTestTahlil.Location = new System.Drawing.Point(4, 25);
            this.tabPageTestTahlil.Name = "tabPageTestTahlil";
            this.tabPageTestTahlil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestTahlil.Size = new System.Drawing.Size(879, 465);
            this.tabPageTestTahlil.TabIndex = 5;
            this.tabPageTestTahlil.Text = "Test Tahlil";
            this.tabPageTestTahlil.UseVisualStyleBackColor = true;
            // 
            // labelSeciliDosya
            // 
            this.labelSeciliDosya.AutoSize = true;
            this.labelSeciliDosya.Location = new System.Drawing.Point(538, 104);
            this.labelSeciliDosya.Name = "labelSeciliDosya";
            this.labelSeciliDosya.Size = new System.Drawing.Size(0, 16);
            this.labelSeciliDosya.TabIndex = 134;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(599, 407);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 26);
            this.button13.TabIndex = 133;
            this.button13.Text = "Yazı Fontu";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(694, 407);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 26);
            this.button14.TabIndex = 132;
            this.button14.Text = "Yazı Rengi";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBoxKayitliTestler
            // 
            this.textBoxKayitliTestler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKayitliTestler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKayitliTestler.Location = new System.Drawing.Point(29, 200);
            this.textBoxKayitliTestler.Multiline = true;
            this.textBoxKayitliTestler.Name = "textBoxKayitliTestler";
            this.textBoxKayitliTestler.ReadOnly = true;
            this.textBoxKayitliTestler.Size = new System.Drawing.Size(765, 243);
            this.textBoxKayitliTestler.TabIndex = 131;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label45.Location = new System.Drawing.Point(25, 165);
            this.label45.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(110, 21);
            this.label45.TabIndex = 130;
            this.label45.Text = "Kayıtlı Testler:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 26);
            this.button2.TabIndex = 129;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label47.Location = new System.Drawing.Point(339, 65);
            this.label47.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(154, 25);
            this.label47.TabIndex = 125;
            this.label47.Text = "Test Tahlil Yükle:";
            // 
            // textBoxTestAdi
            // 
            this.textBoxTestAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTestAdi.Location = new System.Drawing.Point(475, 25);
            this.textBoxTestAdi.Name = "textBoxTestAdi";
            this.textBoxTestAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxTestAdi.TabIndex = 124;
            // 
            // textBoxTestHastaneAdi
            // 
            this.textBoxTestHastaneAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTestHastaneAdi.Location = new System.Drawing.Point(156, 65);
            this.textBoxTestHastaneAdi.Name = "textBoxTestHastaneAdi";
            this.textBoxTestHastaneAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxTestHastaneAdi.TabIndex = 123;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label48.Location = new System.Drawing.Point(339, 25);
            this.label48.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(123, 25);
            this.label48.TabIndex = 122;
            this.label48.Text = "Test Adı:";
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label49.Location = new System.Drawing.Point(25, 65);
            this.label49.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(123, 25);
            this.label49.TabIndex = 121;
            this.label49.Text = "Hastane Adı:";
            // 
            // textBoxTestHastaAdi
            // 
            this.textBoxTestHastaAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTestHastaAdi.Location = new System.Drawing.Point(156, 25);
            this.textBoxTestHastaAdi.Name = "textBoxTestHastaAdi";
            this.textBoxTestHastaAdi.Size = new System.Drawing.Size(150, 26);
            this.textBoxTestHastaAdi.TabIndex = 119;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label50.Location = new System.Drawing.Point(25, 25);
            this.label50.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(123, 25);
            this.label50.TabIndex = 120;
            this.label50.Text = "Hasta Adı:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 609);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.tabControl1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 75);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(887, 494);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.linkLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 569);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(887, 40);
            this.panel4.TabIndex = 1;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(738, 11);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(131, 16);
            this.linkLabel.TabIndex = 0;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "T.C. Sağlık Bakanlığı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.buttonSekmeleriKapat);
            this.panel3.Controls.Add(this.buttonKaydet);
            this.panel3.Controls.Add(this.buttonSil);
            this.panel3.Controls.Add(this.buttonGuncelle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 75);
            this.panel3.TabIndex = 0;
            // 
            // buttonSekmeleriKapat
            // 
            this.buttonSekmeleriKapat.Location = new System.Drawing.Point(360, 15);
            this.buttonSekmeleriKapat.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.buttonSekmeleriKapat.Name = "buttonSekmeleriKapat";
            this.buttonSekmeleriKapat.Size = new System.Drawing.Size(125, 45);
            this.buttonSekmeleriKapat.TabIndex = 6;
            this.buttonSekmeleriKapat.Text = "Sekmeleri Kapat";
            this.buttonSekmeleriKapat.UseVisualStyleBackColor = true;
            this.buttonSekmeleriKapat.Click += new System.EventHandler(this.buttonSekmeleriKapat_Click);
            // 
            // buttonSifirla
            // 
            this.buttonSifirla.BackColor = System.Drawing.Color.Transparent;
            this.buttonSifirla.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonSifirla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSifirla.Location = new System.Drawing.Point(475, 101);
            this.buttonSifirla.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSifirla.Name = "buttonSifirla";
            this.buttonSifirla.Size = new System.Drawing.Size(57, 23);
            this.buttonSifirla.TabIndex = 135;
            this.buttonSifirla.Text = "Sıfırla";
            this.buttonSifirla.UseVisualStyleBackColor = false;
            this.buttonSifirla.Visible = false;
            this.buttonSifirla.Click += new System.EventHandler(this.buttonSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1062, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Hasta Kayıt Sistemi";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageHastaneTanimlama.ResumeLayout(false);
            this.tabPageHastaneTanimlama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHastaneDoktorSayisi)).EndInit();
            this.tabPageHastaTanimlama.ResumeLayout(false);
            this.tabPageHastaTanimlama.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tabPageDoktorTanimlama.ResumeLayout(false);
            this.tabPageDoktorTanimlama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoktor)).EndInit();
            this.tabPageRandevuOlusturma.ResumeLayout(false);
            this.tabPageRandevuOlusturma.PerformLayout();
            this.tabPageTeshisKayit.ResumeLayout(false);
            this.tabPageTeshisKayit.PerformLayout();
            this.tabPageTestTahlil.ResumeLayout(false);
            this.tabPageTestTahlil.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonHastaTanimla;
        private System.Windows.Forms.Button buttonHastaneTanimla;
        private System.Windows.Forms.Button buttonDoktorTanimla;
        private System.Windows.Forms.Button buttonRandevuOlusturma;
        private System.Windows.Forms.Button buttonTeshisKayit;
        private System.Windows.Forms.Button buttonTestTahlil;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHastaneTanimlama;
        private System.Windows.Forms.TabPage tabPageHastaTanimlama;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.TextBox textBoxKayitliHastalar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButtonKadin;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMeslek;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxHastaAdi;
        private System.Windows.Forms.TextBox textBoxHastaSoyadi;
        private System.Windows.Forms.TextBox textBoxTamAdi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPageDoktorTanimlama;
        private System.Windows.Forms.TabPage tabPageRandevuOlusturma;
        private System.Windows.Forms.TabPage tabPageTeshisKayit;
        private System.Windows.Forms.TabPage tabPageTestTahlil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSekmeleriKapat;
        private System.Windows.Forms.TextBox textBoxKayitliHastaneler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHastaneAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHastaneSehir;
        private System.Windows.Forms.MaskedTextBox textBoxTelefon;
        private System.Windows.Forms.ListBox bolumler;
        private System.Windows.Forms.Button buttonBolumEkle;
        private System.Windows.Forms.TextBox textBoxHastaneBolum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHastaneTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownHastaneDoktorSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoktorDogum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxDoktor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKayitliDoktorlar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDoktorAdi;
        private System.Windows.Forms.TextBox textBoxDoktorSoyadi;
        private System.Windows.Forms.TextBox textBoxDoktorTamAdi;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox uzmanlikAlanlari;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxRandevuDoktorAdi;
        private System.Windows.Forms.TextBox textBoxRandevuHastaneAdi;
        private System.Windows.Forms.TextBox textBoxRandevuBolumAdi;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBoxKayitliRandevular;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBoxRandevuHastaAdi;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevuSaat;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevuTarih;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DateTimePicker dateTimePickerTeshisTarih;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBoxTeshisDoktorAdi;
        private System.Windows.Forms.TextBox textBoxTeshisHastaneAdi;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBoxTeshisHastaAdi;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTeshis;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBoxKayitliTeshisler;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBoxKayitliTestler;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBoxTestAdi;
        private System.Windows.Forms.TextBox textBoxTestHastaneAdi;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBoxTestHastaAdi;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label labelSeciliDosya;
        private System.Windows.Forms.Button buttonSifirla;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

