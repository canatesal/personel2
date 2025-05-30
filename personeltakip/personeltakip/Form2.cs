using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;


namespace personeltakip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Dictionary<string, int> depVeri = new Dictionary<string, int>();


        private void Form2_Load(object sender, EventArgs e)
        {
            DepartmanPersonelTablosuOlustur();
            timerSaat.Start();
            DepartmanlariYukle();
            PersonelListesiYukle();
            comboDepFiltreDoldur();
            SayilariGuncelle();
            StilUygula(dataGridView1);


        }


        private void SayilariGuncelle()
        {
            string depDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\departmanlar.txt";
            string prsDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";

            int depSayisi = File.Exists(depDosya) ? File.ReadAllLines(depDosya).Count(x => !string.IsNullOrWhiteSpace(x)) : 0;
            int prsSayisi = File.Exists(prsDosya) ? File.ReadAllLines(prsDosya).Count(x => !string.IsNullOrWhiteSpace(x)) : 0;

            lblDepartmanSayisi.Text = $"Departman Sayısı: {depSayisi}";
            lblPersonelSayisi.Text = $"Personel Sayısı: {prsSayisi}";
        }

        private void DepartmanPersonelTablosuOlustur()
        {
            string depDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\departmanlar.txt";
            string prsDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";

            var depSayilari = new Dictionary<string, int>();

            // Departmanları oku ve sayıları 0 olarak başlat
            if (File.Exists(depDosya))
            {
                foreach (var dep in File.ReadAllLines(depDosya))
                {
                    if (!string.IsNullOrWhiteSpace(dep) && !depSayilari.ContainsKey(dep))
                        depSayilari[dep] = 0;
                }
            }

            // Personelleri oku ve departman sayılarını arttır
            if (File.Exists(prsDosya))
            {
                foreach (var satir in File.ReadAllLines(prsDosya))
                {
                    var veri = satir.Split(',');
                    if (veri.Length >= 7)
                    {
                        string dep = veri[6];
                        if (depSayilari.ContainsKey(dep))
                            depSayilari[dep]++;
                    }
                }
            }

            // DataGridView temizle ve doldur
            dataGridViewDepartmanlar.Rows.Clear();
            dataGridViewDepartmanlar.Columns.Clear();

            dataGridViewDepartmanlar.Columns.Add("Departman", "Departman");
            dataGridViewDepartmanlar.Columns.Add("Sayisi", "Personel Sayısı");

            foreach (var kvp in depSayilari)
            {
                dataGridViewDepartmanlar.Rows.Add(kvp.Key, kvp.Value);
            }

            // Görsel Ayarlar
            dataGridViewDepartmanlar.Columns[0].Width = 200;
            dataGridViewDepartmanlar.Columns[1].Width = 120;

            dataGridViewDepartmanlar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridViewDepartmanlar.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewDepartmanlar.DefaultCellStyle.BackColor = Color.White;
            dataGridViewDepartmanlar.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewDepartmanlar.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
        }


        private void comboDepFiltreDoldur()
        {
            string depDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\departmanlar.txt";
            if (!File.Exists(depDosya)) return;

            comboDepFiltre.Items.Clear();

            var depListesi = File.ReadAllLines(depDosya);
            foreach (var dep in depListesi)
            {
                if (!string.IsNullOrWhiteSpace(dep))
                    comboDepFiltre.Items.Add(dep);
            }
        }

        private void PersonelListesiYukle()
        {
            string dosyaYolu = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";
            listBox1.Items.Clear();

            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);
                foreach (string satir in satirlar)
                {
                    string[] veriler = satir.Split(',');
                    if (veriler.Length > 0)
                    {
                        listBox1.Items.Add(veriler[0]);
                    }
                }
            }
        }

        private void prsEkle_Click(object sender, EventArgs e)
        {
            string ad = prsAd.Text;
            string yas = prsYas.Text;
            string tel = prsTel.Text;
            string sigortaNo = prsSigno.Text;
            string baslamaTarihi = prsBastrh.Text;
            string departman = comPrsDep.Text;

            string maas = MaasGetir(departman); // otomatik maaş al

            string dosyaYolu = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";
            string satir = $"{ad},{yas},{tel},{sigortaNo},{baslamaTarihi},{maas},{departman},0";

            try
            {
                File.AppendAllText(dosyaYolu, satir + Environment.NewLine);
                MessageBox.Show("Personel başarıyla kaydedildi.");

                prsAd.Clear();
                prsYas.Clear();
                prsTel.Clear();
                prsSigno.Clear();

                comPrsDep.SelectedIndex = -1;

                PersonelListesiYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            SayilariGuncelle();
            DepartmanPersonelTablosuOlustur();
            
        }

        // Departmana göre maaş bul
        private string MaasGetir(string departman)
        {
            string maasDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\departmanlar_maas.txt";
            if (!File.Exists(maasDosya)) return "0";

            var satirlar = File.ReadAllLines(maasDosya);
            foreach (var satir in satirlar)
            {
                var veri = satir.Split(',');
                if (veri.Length == 2 && veri[0] == departman)
                    return veri[1];
            }
            return "0";
        }

        private void persSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silinecek personeli seçin.");
                return;
            }

            string seciliIsim = listBox1.SelectedItem.ToString();
            string dosyaYolu = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";

            var satirlar = File.ReadAllLines(dosyaYolu).ToList();
            bool silindi = false;

            for (int i = 0; i < satirlar.Count; i++)
            {
                var veri = satirlar[i].Split(',');
                if (veri[0] == seciliIsim)
                {
                    satirlar.RemoveAt(i);
                    silindi = true;
                    break;
                }
            }

            if (silindi)
            {
                File.WriteAllLines(dosyaYolu, satirlar);
                MessageBox.Show("Personel silindi.");
                PersonelListesiYukle();
            }
            else
            {
                MessageBox.Show("Personel bulunamadı.");
            }

            guncelYas.Clear();
            guncelMaas.Clear();
            guncelDep.SelectedIndex = -1;
            guncelTel.Clear();
            guncelSigno.Clear();
            guncelMesai.Clear();
            SayilariGuncelle();
            DepartmanPersonelTablosuOlustur();
            StilUygula(dataGridViewDepartmanlar);
            StilUygula(dataGridViewDepartmanlar);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;

            string seciliIsim = listBox1.SelectedItem.ToString();
            string dosyaYolu = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";
            string[] satirlar = File.ReadAllLines(dosyaYolu);

            foreach (string satir in satirlar)
            {
                string[] veri = satir.Split(',');
                if (veri[0] == seciliIsim)
                {
                    guncelYas.Text = veri[1];
                    guncelTel.Text = veri[2];
                    guncelSigno.Text = veri[3];
                    guncelDep.Text = veri[6];
                    guncelMesai.Text = veri.Length >= 8 ? veri[7] : "0";

                    // Departmana göre maaşı otomatik getir
                    string departman = veri[6];
                    string maas = MaasGetir(departman);
                    guncelMaas.Text = maas;
                    break;
                }
            }
        }

        private void StilUygula(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.LightGray;

            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;

            // Satırlar (zebra efekti)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Başlıklar
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.RowTemplate.Height = 38;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Güncellemek için bir personel seçin.");
                return;
            }

            string seciliIsim = listBox1.SelectedItem.ToString();
            string dosyaYolu = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";
            List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();

            for (int i = 0; i < satirlar.Count; i++)
            {
                string[] veri = satirlar[i].Split(',');
                if (veri[0] == seciliIsim)
                {
                    string yeniSatir = $"{seciliIsim},{guncelYas.Text},{guncelTel.Text},{guncelSigno.Text},{veri[4]},{guncelMaas.Text},{guncelDep.Text},{guncelMesai.Text}";
                    satirlar[i] = yeniSatir;
                    break;
                }
            }

            File.WriteAllLines(dosyaYolu, satirlar);
            MessageBox.Show("Güncelleme tamamlandı.");

            guncelYas.Clear();
            guncelMaas.Clear();
            guncelDep.SelectedIndex = -1;
            guncelTel.Clear();
            guncelSigno.Clear();
            guncelMesai.Clear();

            PersonelListesiYukle();
            SayilariGuncelle();
            DepartmanPersonelTablosuOlustur();
            StilUygula(dataGridViewDepartmanlar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";

            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("personellistesi.txt bulunamadı.");
                return;
            }

            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("AdSoyad", "İsim Soyisim");
            dataGridView1.Columns.Add("Departman", "Departman");
            dataGridView1.Columns.Add("GirisSaati", "Giriş Saati");
            dataGridView1.Columns.Add("CikisSaati", "Çıkış Saati");
            dataGridView1.Columns.Add("KatilimDurumu", "Katılım Durumu");
            dataGridView1.Columns.Add("Aciklama", "Açıklama");
            dataGridView1.Columns.Add("BugunkuUcret", "Bugünkü Ücret");
            dataGridView1.Columns.Add("ToplamUcret", "Toplam Mesai Ücreti");

            string[] satirlar = File.ReadAllLines(dosyaYolu);
            TimeSpan cikis = new TimeSpan(17, 0, 0);
            double saatlikUcret = 50;
            Random rnd = new Random();

            foreach (string satir in satirlar)
            {
                string[] veri = satir.Split(',');
                if (veri.Length >= 8)
                {
                    string ad = veri[0];
                    string departman = veri[6];
                    int ekMesai = int.TryParse(veri[7], out int em) ? em : 0;

                    int saat = rnd.Next(7, 10);
                    int dakika = rnd.Next(0, 60);
                    TimeSpan giris = new TimeSpan(saat, dakika, 0);

                    // Değerlendirme sınırı: 08:30
                    string durum;
                    if (giris <= new TimeSpan(8, 30, 0))
                        durum = "✔";
                    else if (giris < new TimeSpan(9, 0, 0))
                        durum = "○";
                    else
                        durum = "X";

                    string aciklama = "-";
                    if (durum == "X")
                    {
                        string[] nedenler = { "Raporlu", "Bilinmiyor" };
                        aciklama = nedenler[rnd.Next(nedenler.Length)];
                    }
                    else if (durum == "○")
                    {
                        aciklama = "Geç kaldı";
                    }

                    TimeSpan calisma = cikis - giris;
                    double bugunkuUcret = calisma.TotalHours * saatlikUcret;
                    double toplamUcret = bugunkuUcret + (ekMesai * saatlikUcret);

                    if (bugunkuUcret < 0) bugunkuUcret = 0;
                    if (toplamUcret < 0) toplamUcret = 0;

                    dataGridView1.Rows.Add(
                        ad,
                        departman,
                        giris.ToString(@"hh\:mm"),
                        cikis.ToString(@"hh\:mm"),
                        durum,
                        aciklama,
                        bugunkuUcret.ToString("0.00"),
                        toplamUcret.ToString("0.00")
                    );
                }
            }

            MessageBox.Show("Mesai tablosu başarıyla oluşturuldu.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDepSil_Click(object sender, EventArgs e)
        {
            if (listBoxDepartmanlar.SelectedIndex == -1)
            {
                MessageBox.Show("Silinecek departmanı seçin.");
                return;
            }

            string seciliDep = listBoxDepartmanlar.SelectedItem.ToString();
            string dosyaYolu = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\departmanlar.txt";

            var satirlar = File.ReadAllLines(dosyaYolu).ToList();
            satirlar.RemoveAll(x => x == seciliDep);
            File.WriteAllLines(dosyaYolu, satirlar);

            DepartmanlariYukle();
            MessageBox.Show("Departman silindi.");

            SayilariGuncelle();
        }

        private void DepartmanlariYukle()
        {
            string depDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\departmanlar.txt";
            string prsDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";

            if (!File.Exists(depDosya)) File.Create(depDosya).Close();

            // txt'deki kayıtlı departmanları al
            var depListesi = File.ReadAllLines(depDosya).Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            // personellistesi.txt'deki departmanları da ekle
            if (File.Exists(prsDosya))
            {
                var satirlar = File.ReadAllLines(prsDosya);
                foreach (var satir in satirlar)
                {
                    var veri = satir.Split(',');
                    if (veri.Length >= 7)
                    {
                        string dep = veri[6].Trim();
                        if (!string.IsNullOrWhiteSpace(dep) && !depListesi.Contains(dep))
                        {
                            depListesi.Add(dep);
                        }
                    }
                }
            }

            // Tekrar yaz ve tüm comboboxları temizle → yeniden ekle
            depListesi = depListesi.Distinct().OrderBy(x => x).ToList();
            File.WriteAllLines(depDosya, depListesi);

            listBoxDepartmanlar.Items.Clear();
            comPrsDep.Items.Clear();
            guncelDep.Items.Clear();
            comboDepFiltre.Items.Clear();

            foreach (var dep in depListesi)
            {
                listBoxDepartmanlar.Items.Add(dep);
                comPrsDep.Items.Add(dep);
                guncelDep.Items.Add(dep);
                comboDepFiltre.Items.Add(dep);
            }

        }



        private void btnDepEkle_Click(object sender, EventArgs e)
        {
            string yeniDep = txtYeniDepartman.Text.Trim();
            string yeniMaas = txtDepMaas.Text.Trim(); // txtDepMaas yeni textbox

            string depDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\departmanlar.txt";
            string maasDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\departmanlar_maas.txt";

            if (string.IsNullOrWhiteSpace(yeniDep) || string.IsNullOrWhiteSpace(yeniMaas))
            {
                MessageBox.Show("Departman ve maaş bilgisi boş olamaz.");
                return;
            }

            var mevcutDep = File.ReadAllLines(depDosya).ToList();
            if (mevcutDep.Contains(yeniDep))
            {
                MessageBox.Show("Bu departman zaten var.");
                return;
            }

            File.AppendAllText(depDosya, yeniDep + Environment.NewLine);
            File.AppendAllText(maasDosya, $"{yeniDep},{yeniMaas}" + Environment.NewLine);

            txtYeniDepartman.Clear();
            txtDepMaas.Clear();

            DepartmanlariYukle();
            SayilariGuncelle();
            DepartmanPersonelTablosuOlustur();
           


            MessageBox.Show("Departman ve maaşı eklendi.");

        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string seciliDep = comboDepFiltre.SelectedItem?.ToString();
            string prsDosya = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";

            listBox2.Items.Clear();

            if (string.IsNullOrWhiteSpace(seciliDep) || !File.Exists(prsDosya))
            {
                MessageBox.Show("Departman seçilmedi veya dosya bulunamadı.");
                return;
            }

            var satirlar = File.ReadAllLines(prsDosya);
            foreach (var satir in satirlar)
            {
                var veri = satir.Split(',');
                if (veri.Length >= 7 && veri[6] == seciliDep)
                {
                    listBox2.Items.Add(veri[0]);
                }
            }

            if (listBox2.Items.Count == 0)
                listBox2.Items.Add("Bu departmanda personel yok.");

            SayilariGuncelle();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnTarihKontrol_Click(object sender, EventArgs e)
        {
            listBoxTarihSonuc.Items.Clear();

            DateTime secilenTarih = dtTarihSec.Value.Date;
            string bugun = DateTime.Now.Date.ToShortDateString(); // örnek için

            string dosyaYolu = @"C:\Users\canat\OneDrive\Masaüstü\C#PROJEE\personeltakip\personellistesi.txt";
            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("personellistesi.txt dosyası bulunamadı.");
                return;
            }

            string[] satirlar = File.ReadAllLines(dosyaYolu);
            Random rnd = new Random();

            foreach (string satir in satirlar)
            {
                string[] veri = satir.Split(',');
                if (veri.Length >= 7)
                {
                    string ad = veri[0];
                    // Simülasyon olarak %70 ihtimalle katıldı varsayalım
                    bool katildi = rnd.Next(0, 100) < 70;

                    string sonuc = $"{ad} {(katildi ? "✔ Katıldı" : "❌ Katılmadı")}";
                    listBoxTarihSonuc.Items.Add(sonuc);
                }
            }

            MessageBox.Show($"{secilenTarih.ToShortDateString()} için yoklama kontrolü tamamlandı.");
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void prsAd_TextChanged(object sender, EventArgs e)
        {
            string temizMetin = new string(prsAd.Text.Where(c => !char.IsDigit(c)).ToArray());

            if (prsAd.Text != temizMetin)
            {
                prsAd.Text = temizMetin;
                prsAd.SelectionStart = prsAd.Text.Length; // imleci sona taşı
                MessageBox.Show("Ad alanına rakam girilemez.");
            }
        }

        private void prsYas_TextChanged(object sender, EventArgs e)
        {
            string temiz = new string(prsYas.Text.Where(char.IsDigit).ToArray());
            if (temiz.Length > 2)
                temiz = temiz.Substring(0, 2);

            if (prsYas.Text != temiz)
            {
                prsYas.Text = temiz;
                prsYas.SelectionStart = temiz.Length;
                MessageBox.Show("Yaş alanına en fazla 2 haneli rakam girilebilir.");
            }
        }

        private void prsTel_TextChanged(object sender, EventArgs e)
        {
            string temiz = new string(prsTel.Text.Where(char.IsDigit).ToArray());
            if (temiz.Length > 11)
                temiz = temiz.Substring(0, 11);

            if (prsTel.Text != temiz)
            {
                prsTel.Text = temiz;
                prsTel.SelectionStart = temiz.Length;
                MessageBox.Show("Telefon numarası 11 haneli olmalıdır.");
            }
        }

        private void prsSigno_TextChanged(object sender, EventArgs e)
        {
            string temiz = new string(prsSigno.Text.Where(char.IsDigit).ToArray());
            if (temiz.Length > 11)
                temiz = temiz.Substring(0, 11);

            if (prsSigno.Text != temiz)
            {
                prsSigno.Text = temiz;
                prsSigno.SelectionStart = temiz.Length;
                MessageBox.Show("Sigorta numarası 11 haneli olmalıdır.");
            }
        }

        private void prsBastrh_TextChanged(object sender, EventArgs e)
        {
            string giris = prsBastrh.Text;
            DateTime tarih;

            if (giris.Length == 10 && !DateTime.TryParseExact(giris, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tarih))
            {
                MessageBox.Show("Tarih formatı 'gg/aa/yyyy' şeklinde olmalıdır.");
            }
        }

        private void labelTarihSaat_Click(object sender, EventArgs e)
        {
            labelTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}