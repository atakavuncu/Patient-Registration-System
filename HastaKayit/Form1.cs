using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HastaKayit
{
    public partial class Form1 : Form
    {
        private List<Hasta> hastaList = new List<Hasta>();
        private List<Hastane> hastaneList = new List<Hastane>();
        private List<Doktor> doktorList = new List<Doktor>();
        private List<Randevu> randevuList = new List<Randevu>();
        private List<Teshis> teshisList = new List<Teshis>();
        private List<TestTahlil> testTahlilList = new List<TestTahlil>();
        private string chosenGender = "";
        private FontDialog fontDialog = new FontDialog();
        private ColorDialog colorDialog = new ColorDialog();

        public Form1()
        {
            InitializeComponent();
        }

        //
        // SOL PANEL
        //
        private void buttonHastaTanimla_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Visible)
                tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPageHastaTanimlama;
        }

        private void buttonHastaneTanimla_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Visible)
                tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPageHastaneTanimlama;
        }

        private void buttonDoktorTanimla_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Visible)
                tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPageDoktorTanimlama;
        }

        private void buttonRandevuOlusturma_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Visible)
                tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPageRandevuOlusturma;
        }

        private void buttonTeshisKayit_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Visible)
                tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPageTeshisKayit;
        }

        private void buttonTestTahlil_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Visible)
                tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPageTestTahlil;
        }

        //
        // ÜST PANEL
        //
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string selectedTab = tabControl1.SelectedTab.Name;
            switch(selectedTab)
            {
                case "tabPageHastaneTanimlama":
                    Hastane hastane = new Hastane(
                        textBoxHastaneAdi.Text,
                        comboBoxHastaneSehir.Text,
                        numericUpDownHastaneDoktorSayisi.Value,
                        maskedTextBoxHastaneTelefon.Text,
                        bolumler.Items.Cast<string>().ToList()
                        );

                    hastaneList.Add(hastane);

                    textBoxKayitliHastaneler.Text = kayitliHastaneleriYazdir();

                    if (textBoxKayitliHastaneler.ClientSize.Height < TextRenderer.MeasureText(textBoxKayitliHastaneler.Text, textBoxKayitliHastaneler.Font).Height)
                        textBoxKayitliHastaneler.ScrollBars = ScrollBars.Vertical;
                    else
                        textBoxKayitliHastaneler.ScrollBars = ScrollBars.None;

                    break;

                case "tabPageHastaTanimlama":
                    Hasta hasta = new Hasta(
                        textBoxTamAdi.Text,
                        textBoxAdres.Text,
                        textBoxEmail.Text,
                        textBoxTelefon.Text,
                        textBoxMeslek.Text,
                        chosenGender);

                    hastaList.Add(hasta);

                    textBoxKayitliHastalar.Text = kayitliHastalariYazdir();

                    if (textBoxKayitliHastalar.ClientSize.Height < TextRenderer.MeasureText(textBoxKayitliHastalar.Text, textBoxKayitliHastalar.Font).Height)
                        textBoxKayitliHastalar.ScrollBars = ScrollBars.Vertical;
                    else
                        textBoxKayitliHastalar.ScrollBars = ScrollBars.None;

                    break;

                case "tabPageDoktorTanimlama":
                    Doktor doktor = new Doktor(
                        textBoxDoktorTamAdi.Text,
                        dateTimePickerDoktorDogum.Text,
                        uzmanlikAlanlari.CheckedItems.Cast<string>().ToList());

                    doktorList.Add(doktor);

                    textBoxKayitliDoktorlar.Text = kayitliDoktorlariYazdir();

                    break;

                case "tabPageRandevuOlusturma":
                    Randevu randevu = new Randevu(
                        textBoxRandevuHastaAdi.Text,
                        textBoxRandevuHastaneAdi.Text,
                        textBoxRandevuDoktorAdi.Text,
                        textBoxRandevuBolumAdi.Text,
                        dateTimePickerRandevuTarih.Text,
                        dateTimePickerRandevuSaat.Text);

                    randevuList.Add(randevu);

                    textBoxKayitliRandevular.Text = kayitliRandevulariYazdir();


                    break;

                case "tabPageTeshisKayit":
                    Teshis teshis = new Teshis(
                        textBoxTeshisHastaAdi.Text,
                        textBoxTeshisHastaneAdi.Text,
                        textBoxTeshisDoktorAdi.Text,
                        textBoxTeshis.Text,
                        dateTimePickerTeshisTarih.Text);

                    teshisList.Add(teshis);

                    textBoxKayitliTeshisler.Text = kayitliTeshisleriYazdir();

                    break;

                case "tabPageTestTahlil":
                    TestTahlil testTahlil = new TestTahlil(
                        textBoxTestHastaAdi.Text,
                        textBoxTestHastaneAdi.Text,
                        textBoxTestAdi.Text);

                    testTahlilList.Add(testTahlil);

                    textBoxKayitliTestler.Text = kayitliTestleriYazdir();

                    break;

                default:
                    break;
            }

            
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            string selectedTab = tabControl1.SelectedTab.Name;
            switch (selectedTab)
            {
                case "tabPageHastaneTanimlama":
                    for (int i = 0; i < hastaneList.Count; i++)
                    {
                        if (hastaneList[i].ad == textBoxHastaneAdi.Text)
                        {
                            hastaneList[i].sehir = comboBoxHastaneSehir.Text;
                            hastaneList[i].doktorSayisi = numericUpDownHastaneDoktorSayisi.Value;
                            hastaneList[i].telefon = maskedTextBoxHastaneTelefon.Text;
                            hastaneList[i].bolumler = bolumler.Items.Cast<string>().ToList();
                            break;
                        }
                        if (i == hastaneList.Count - 1)
                        {
                            bool choose = guncelleUyariKutusu("Hastane Adı");
                            if (choose)
                            {
                                Hastane hastane = new Hastane(
                                    textBoxHastaneAdi.Text,
                                    comboBoxHastaneSehir.Text,
                                    numericUpDownHastaneDoktorSayisi.Value,
                                    maskedTextBoxHastaneTelefon.Text,
                                    bolumler.Items.Cast<string>().ToList()
                                    );

                                hastaneList.Add(hastane);
                            }
                        }
                    }

                    textBoxKayitliHastaneler.Text = kayitliHastaneleriYazdir();

                    if (textBoxKayitliHastaneler.ClientSize.Height < TextRenderer.MeasureText(textBoxKayitliHastaneler.Text, textBoxKayitliHastaneler.Font).Height)
                        textBoxKayitliHastaneler.ScrollBars = ScrollBars.Vertical;
                    else
                        textBoxKayitliHastaneler.ScrollBars = ScrollBars.None;

                    break;

                case "tabPageHastaTanimlama":
                    for (int i = 0; i < hastaList.Count; i++)
                    {
                        if (hastaList[i].hastaTamAdi == textBoxTamAdi.Text)
                        {
                            hastaList[i].adres = textBoxAdres.Text;
                            hastaList[i].email = textBoxEmail.Text;
                            hastaList[i].telefon = textBoxTelefon.Text;
                            hastaList[i].meslek = textBoxMeslek.Text;
                            hastaList[i].cinsiyet = chosenGender;
                            break;
                        }
                        if (i == hastaList.Count - 1)
                        {
                            bool choose = guncelleUyariKutusu("Hasta Adı");
                            if (choose)
                            {
                                Hasta hasta = new Hasta(
                                    textBoxTamAdi.Text,
                                    textBoxAdres.Text,
                                    textBoxEmail.Text,
                                    textBoxTelefon.Text,
                                    textBoxMeslek.Text,
                                    chosenGender);

                                hastaList.Add(hasta);
                            }
                        }
                    }

                    textBoxKayitliHastalar.Text = kayitliHastalariYazdir();

                    if (textBoxKayitliHastalar.ClientSize.Height < TextRenderer.MeasureText(textBoxKayitliHastalar.Text, textBoxKayitliHastalar.Font).Height)
                        textBoxKayitliHastalar.ScrollBars = ScrollBars.Vertical;
                    else
                        textBoxKayitliHastalar.ScrollBars = ScrollBars.None;

                    break;

                case "tabPageDoktorTanimlama":
                    for (int i = 0; i < doktorList.Count; i++)
                    {
                        if (doktorList[i].doktorTamAdi == textBoxDoktorTamAdi.Text)
                        {
                            doktorList[i].dogumTarihi = dateTimePickerDoktorDogum.Text;
                            doktorList[i].uzmanlikAlanlari = uzmanlikAlanlari.CheckedItems.Cast<string>().ToList();
                            break;
                        }
                        if (i == doktorList.Count - 1)
                        {
                            bool choose = guncelleUyariKutusu("Doktor Adı");
                            if (choose)
                            {
                                Doktor doktor = new Doktor(
                                    textBoxDoktorTamAdi.Text,
                                    dateTimePickerDoktorDogum.Text,
                                    uzmanlikAlanlari.CheckedItems.Cast<string>().ToList());

                                doktorList.Add(doktor);
                            }
                        }
                    }

                    textBoxKayitliDoktorlar.Text = kayitliDoktorlariYazdir();

                    if (textBoxKayitliDoktorlar.ClientSize.Height < TextRenderer.MeasureText(textBoxKayitliDoktorlar.Text, textBoxKayitliDoktorlar.Font).Height)
                        textBoxKayitliDoktorlar.ScrollBars = ScrollBars.Vertical;
                    else
                        textBoxKayitliDoktorlar.ScrollBars = ScrollBars.None;

                    break;

                case "tabPageRandevuOlusturma":
                    for (int i = 0; i < randevuList.Count; i++)
                    {
                        if (randevuList[i].hastaAdi == textBoxRandevuHastaAdi.Text)
                        {
                            randevuList[i].hastaneAdi = textBoxRandevuHastaneAdi.Text;
                            randevuList[i].doktorAdi = textBoxRandevuDoktorAdi.Text;
                            randevuList[i].bolum = textBoxRandevuBolumAdi.Text;
                            randevuList[i].tarih = dateTimePickerRandevuTarih.Text;
                            randevuList[i].saat = dateTimePickerRandevuSaat.Text;

                            break;
                        }
                        if (i == randevuList.Count - 1)
                        {
                            bool choose = guncelleUyariKutusu("Hasta Adı");
                            if (choose)
                            {
                                Randevu randevu = new Randevu(
                                    textBoxRandevuHastaAdi.Text,
                                    textBoxRandevuHastaneAdi.Text,
                                    textBoxRandevuDoktorAdi.Text,
                                    textBoxRandevuBolumAdi.Text,
                                    dateTimePickerRandevuTarih.Text,
                                    dateTimePickerRandevuSaat.Text);

                                randevuList.Add(randevu);
                            }
                        }
                    }

                    textBoxKayitliRandevular.Text = kayitliRandevulariYazdir();

                    if (textBoxKayitliRandevular.ClientSize.Height < TextRenderer.MeasureText(textBoxKayitliRandevular.Text, textBoxKayitliRandevular.Font).Height)
                        textBoxKayitliRandevular.ScrollBars = ScrollBars.Vertical;
                    else
                        textBoxKayitliRandevular.ScrollBars = ScrollBars.None;


                    break;

                case "tabPageTeshisKayit":
                    for (int i = 0; i < teshisList.Count; i++)
                    {
                        if (teshisList[i].hastaAdi == textBoxTeshisHastaAdi.Text)
                        {
                            teshisList[i].hastaneAdi = textBoxTeshisHastaneAdi.Text;
                            teshisList[i].doktorAdi = textBoxTeshisDoktorAdi.Text;
                            teshisList[i].teshis = textBoxTeshis.Text;
                            teshisList[i].tarih = dateTimePickerTeshisTarih.Text;

                            break;
                        }
                        if (i == teshisList.Count - 1)
                        {
                            bool choose = guncelleUyariKutusu("Hasta Adı");
                            if (choose)
                            {
                                Teshis teshis = new Teshis(
                                    textBoxTeshisHastaAdi.Text,
                                    textBoxTeshisHastaneAdi.Text,
                                    textBoxTeshisDoktorAdi.Text,
                                    textBoxTeshis.Text,
                                    dateTimePickerTeshisTarih.Text);

                                teshisList.Add(teshis);
                            }
                        }
                    }

                    textBoxKayitliTeshisler.Text = kayitliTeshisleriYazdir();

                    if (textBoxKayitliTeshisler.ClientSize.Height < TextRenderer.MeasureText(textBoxKayitliTeshisler.Text, textBoxKayitliTeshisler.Font).Height)
                        textBoxKayitliTeshisler.ScrollBars = ScrollBars.Vertical;
                    else
                        textBoxKayitliTeshisler.ScrollBars = ScrollBars.None;

                    break;

                case "tabPageTestTahlil":
                    for (int i = 0; i < testTahlilList.Count; i++)
                    {
                        if (testTahlilList[i].hastaAdi == textBoxTestHastaAdi.Text)
                        {
                            testTahlilList[i].hastaneAdi = textBoxTestHastaneAdi.Text;
                            testTahlilList[i].testAdi = textBoxTestAdi.Text;

                            break;
                        }
                        if (i == testTahlilList.Count - 1)
                        {
                            bool choose = guncelleUyariKutusu("Hasta Adı");
                            if (choose)
                            {
                                TestTahlil testTahlil = new TestTahlil(
                                    textBoxTestHastaAdi.Text,
                                    textBoxTestHastaneAdi.Text,
                                    textBoxTestAdi.Text);

                                testTahlilList.Add(testTahlil);
                            }
                        }
                    }

                    textBoxKayitliTestler.Text = kayitliTestleriYazdir();

                    if (textBoxKayitliTestler.ClientSize.Height < TextRenderer.MeasureText(textBoxKayitliTestler.Text, textBoxKayitliTestler.Font).Height)
                        textBoxKayitliTestler.ScrollBars = ScrollBars.Vertical;
                    else
                        textBoxKayitliTestler.ScrollBars = ScrollBars.None;

                    break;

                default:
                    break;
            }
        }

        private void buttonSekmeleriKapat_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        //
        // HASTANE TANIMLAMA EKRANI
        //
        private void buttonBolumEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxHastaneBolum.Text))
            {
                bolumler.Items.Add(textBoxHastaneBolum.Text);
                textBoxHastaneBolum.Clear();
                textBoxHastaneBolum.Focus();
            }
        }

        private void textBoxHastaneBolum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = textBoxHastaneBolum.Text;

                if (!string.IsNullOrEmpty(text))
                {
                    bolumler.Items.Add(text);
                    textBoxHastaneBolum.Clear();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFontDialog(textBoxKayitliHastaneler);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openColorDialog(textBoxKayitliHastaneler);
        }


        //
        // HASTA TANIMLAMA EKRANI
        //
        private void textBoxHastaAdi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTamAdi.Text))
                textBoxTamAdi.Text = textBoxHastaAdi.Text + " ";
            else
            {
                string[] tamAdi = textBoxTamAdi.Text.Split(' ');
                textBoxTamAdi.Text = textBoxHastaAdi.Text + " " + tamAdi.GetValue(tamAdi.Length - 1);
            }
        }

        private void textBoxHastaSoyadi_Leave(object sender, EventArgs e)
        {
            textBoxTamAdi.Text += textBoxHastaSoyadi.Text;
        }

        private void radioButtonKadin_CheckedChanged(object sender, EventArgs e)
        {
            chosenGender = "Kadın";
        }

        private void radioButtonErkek_CheckedChanged(object sender, EventArgs e)
        {
            chosenGender = "Erkek";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFontDialog(textBoxKayitliHastalar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openColorDialog(textBoxKayitliHastalar);
        }


        //
        // DOKTOR TANIMLAMA EKRANI
        //
        private void textBoxDoktorAdi_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDoktorTamAdi.Text))
                textBoxDoktorTamAdi.Text = textBoxDoktorAdi.Text + " ";
            else
            {
                string[] tamAdi = textBoxDoktorTamAdi.Text.Split(' ');
                textBoxDoktorTamAdi.Text = textBoxDoktorAdi.Text + " " + tamAdi.GetValue(tamAdi.Length - 1);
            }
        }

        private void textBoxDoktorSoyadi_TextChanged(object sender, EventArgs e)
        {
            textBoxDoktorTamAdi.Text = textBoxDoktorAdi.Text + " " + textBoxDoktorSoyadi.Text;
        }

        private void pictureBoxDoktor_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg|Tüm Dosyalar|*.*";

                openFileDialog.Title = "Fotoğraf Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen fotoğrafın yolunu al
                    string dosyaYolu = openFileDialog.FileName;

                    // PictureBox'a seçilen fotoğrafı yükle
                    pictureBoxDoktor.Image = Image.FromFile(dosyaYolu);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFontDialog(textBoxKayitliDoktorlar);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openColorDialog(textBoxKayitliDoktorlar);
        }

        //
        // RANDEVU OLUŞTURMA EKRANI
        //
        private void button9_Click(object sender, EventArgs e)
        {
            openFontDialog(textBoxKayitliRandevular);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openColorDialog(textBoxKayitliRandevular);
        }

        //
        // TEŞHİS KAYIT EKRANI
        //
        private void button11_Click(object sender, EventArgs e)
        {
            openFontDialog(textBoxKayitliTeshisler);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openColorDialog(textBoxKayitliTeshisler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";

                saveFileDialog.Title = "Dosyayı Kaydet";

                saveFileDialog.FileName = "Yeni Metin Belgesi.txt";

                saveFileDialog.OverwritePrompt = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter dosya = new StreamWriter(saveFileDialog.FileName);
                    string dosyaIcerigi = kayitliTeshisleriYazdir();
                    dosya.WriteLine(dosyaIcerigi);
                    dosya.Close();
                }
            }
        }

        //
        // TEST TAHLİL EKRANI
        //
        private void button13_Click(object sender, EventArgs e)
        {
            openFontDialog(textBoxKayitliTestler);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openColorDialog(textBoxKayitliTestler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";

                openFileDialog.Title = "Dosya Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dosyaAdi = openFileDialog.SafeFileName;
                    labelSeciliDosya.Text = dosyaAdi;
                    buttonSifirla.Visible = true;
                }
            }
        }

        private void buttonSifirla_Click(object sender, EventArgs e)
        {
            labelSeciliDosya.Text = "";
            buttonSifirla.Visible = false;
        }

        //
        // YARDIMCI FONKSİYONLAR
        //
        private string kayitliHastaneleriYazdir()
        {
            string kayitliHastaneler = "";
            List<string> bolumler = new List<string>();

            for (int i = 0; i < hastaneList.Count; i++)
            {
                bolumler = hastaneList[i].bolumler;
                kayitliHastaneler += ($"Hastane Adı: {hastaneList[i].ad}\r\n" +
                   $"Şehir: {hastaneList[i].sehir}\r\n" +
                   $"Doktor Sayısı: {hastaneList[i].doktorSayisi}\r\n" +
                   $"Telefon: {hastaneList[i].telefon}\r\n" +
                   $"Bölümler: ");
                for (int j = 0; j < bolumler.Count; j++)
                {
                    kayitliHastaneler += (bolumler[j]);
                    if (j != bolumler.Count - 1)
                        kayitliHastaneler += " - ";
                }
                kayitliHastaneler += ($"\r\n\r\n----------\r\n\r\n");
            }

            return kayitliHastaneler;
        }

        private string kayitliHastalariYazdir()
        {
            string kayitliHastalar = "";

            for (int i = 0; i < hastaList.Count; i++)
            {
                kayitliHastalar += ($"Ad Soyad: {hastaList[i].hastaTamAdi}\r\n" +
                    $"Telefon: {hastaList[i].telefon}\r\n" +
                    $"Email: {hastaList[i].email}\r\n" +
                    $"Cinsiyet: {hastaList[i].cinsiyet}\r\n" +
                    $"Meslek: {hastaList[i].meslek}\r\n" +
                    $"Adres: {hastaList[i].adres}\r\n\r\n" +
                    $"----------\r\n\r\n");
            }

            return kayitliHastalar;
        }

        private string kayitliDoktorlariYazdir()
        {
            string kayitliDoktorlar = "";
            List<string> uzmanlikAlanlari = new List<string>();

            for (int i = 0; i < doktorList.Count; i++)
            {
                uzmanlikAlanlari = doktorList[i].uzmanlikAlanlari;
                kayitliDoktorlar += ($"Doktor Adı: {doktorList[i].doktorTamAdi}\r\n" +
                   $"Doğum Tarihi: {doktorList[i].dogumTarihi}\r\n" +
                   $"Uzmanlık Alanları: ");
                for (int j = 0; j < uzmanlikAlanlari.Count; j++)
                {
                    kayitliDoktorlar += (uzmanlikAlanlari[j]);
                    if (j != uzmanlikAlanlari.Count - 1)
                        kayitliDoktorlar += " - ";
                }
                kayitliDoktorlar += ($"\r\n\r\n----------\r\n\r\n");
            }

            return kayitliDoktorlar;
        }

        private string kayitliRandevulariYazdir()
        {
            string kayitliRandevular = "";

            for (int i = 0; i < randevuList.Count; i++)
            {
                kayitliRandevular += ($"Hasta Adı: {randevuList[i].hastaAdi}\r\n" +
                    $"Hastane Adı: {randevuList[i].hastaneAdi}\r\n" +
                    $"Doktor Adı: {randevuList[i].doktorAdi}\r\n" +
                    $"Bölüm: {randevuList[i].bolum} \r\n" +
                    $"Tarih: {randevuList[i].tarih} \r\n" +
                    $"Saat: {randevuList[i].saat} \r\n\r\n" +
                    $"----------\r\n\r\n");
            }

            return kayitliRandevular;
        }

        private string kayitliTeshisleriYazdir()
        {
            string kayitliTeshisler = "";

            for (int i = 0; i < teshisList.Count; i++)
            {
                kayitliTeshisler += ($"Hasta Adı: {teshisList[i].hastaAdi}\r\n" +
                    $"Hastane Adı: {teshisList[i].hastaneAdi}\r\n" +
                    $"Doktor Adı: {teshisList[i].doktorAdi}\r\n" +
                    $"Tarih: {teshisList[i].tarih} \r\n" +
                    $"Teşhis: {teshisList[i].teshis} \r\n\r\n" +
                    $"----------\r\n\r\n");
            }

            return kayitliTeshisler;
        }

        private string kayitliTestleriYazdir()
        {
            string kayitliTestler = "";

            for (int i = 0; i < testTahlilList.Count; i++)
            {
                kayitliTestler += ($"Hasta Adı: {testTahlilList[i].hastaAdi}\r\n" +
                    $"Hastane Adı: {testTahlilList[i].hastaneAdi}\r\n" +
                    $"Doktor Adı: {testTahlilList[i].testAdi}\r\n" +
                    $"----------\r\n\r\n");
            }

            return kayitliTestler;
        }

        private void openFontDialog(TextBox textBox)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                textBox.Font = fontDialog.Font;
        }

        private void openColorDialog(TextBox textBox)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                textBox.ForeColor = colorDialog.Color;
        }

        private bool guncelleUyariKutusu(string labelName)
        {
            DialogResult result = MessageBox.Show(text: $"Girdiğiniz {labelName} sistemimizde kayıtlı değil. Kaydetmek ister misiniz?",
                caption: "Uyarı",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }
    }
}
