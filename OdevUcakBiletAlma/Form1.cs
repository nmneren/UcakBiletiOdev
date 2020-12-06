using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevUcakBiletAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            HavaAlanıIsim(cmb_nereden, cmb_nereye);

            cmb_bilet_turu.SelectedIndex = 0;
            checkBox_yon.Checked = true;

            Yenile();
        }

        // Comboboxlardaki SelectedIndexChangedlerde aynı yerleri seçememe kodu var.
        private void cmb_nereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_nereden.SelectedIndex != -1)
            {
                if (cmb_nereden.SelectedItem.Equals(cmb_nereye.SelectedItem))
                {
                    MessageBox.Show("Aynı Şehri Seçemezsiniz.");
                    cmb_nereden.SelectedIndex = -1;
                }
            }
        }
        private void cmb_nereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_nereye.SelectedIndex != -1)
            {
                if (cmb_nereye.SelectedItem.Equals(cmb_nereden.SelectedItem))
                {
                    MessageBox.Show("Aynı Şehri Seçemezsiniz.");
                    cmb_nereye.SelectedIndex = -1;
                }
            }
        }
        private void checkBox_yon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_yon.Checked)
            {
                dateTimePicker_donus.Enabled = false;
            }
            else
            {
                dateTimePicker_donus.Enabled = true;
            }
        }
        private void dateTimePicker_donus_ValueChanged(object sender, EventArgs e)
        {
            DateTime gidis = dateTimePicker_gidis.Value, donus = dateTimePicker_donus.Value;
            TarihKontrol(gidis, donus);
        }

        //Comboboxlardaki yerleri kontrollü şekilde yer değiştiriyor.
        private void btn_degistir_Click(object sender, EventArgs e)
        {
            int nereden = cmb_nereden.SelectedIndex, nereye = cmb_nereye.SelectedIndex;

            if (nereden != -1 && nereye != -1)
            {
                cmb_nereden.SelectedIndex = -1;
                cmb_nereye.SelectedIndex = -1;

                cmb_nereden.SelectedIndex = nereye;
                cmb_nereye.SelectedIndex = nereden;
            }
            else
            {
                if (nereden == -1)
                {
                    MessageBox.Show("Nereden Gideceğinizi Seçmeniz Gerekiyor..");
                }
                else if (nereye == -1)
                {
                    MessageBox.Show("Nereye Gideceğinizi Seçmeniz Gerekiyor..");

                }
            }

        }
        private void btn_satın_al_Click(object sender, EventArgs e)
        {
            if (TarihKontrol())
            {
                if (cmb_bilet_turu.SelectedIndex == 0)
                {
                    Ekonomi eko = new Ekonomi();

                    eko.KisiSayisi = (int)numericUpDown1.Value;
                    Kaydet(eko.Hesap(0));
                }
                else if (cmb_bilet_turu.SelectedIndex == 1)
                {
                    Premium pre = new Premium();

                    pre.KisiSayisi = (int)numericUpDown1.Value;
                    Kaydet(pre.Hesap(0), pre.Ekstra);

                }
                else if (cmb_bilet_turu.SelectedIndex == 1)
                {
                    Business bus = new Business();

                    bus.KisiSayisi = (int)numericUpDown1.Value;
                    Kaydet(bus.Hesap(0), bus.Ekstra);
                }

                Yenile();
                Temizle();
            }
        }


        void Kaydet(double tutar)
        {
            string path = @"C:\Users\MOSTER\Desktop\Bilet.txt";

            if (!File.Exists(path))
            {
                FileStream yaz = new FileStream(path, FileMode.Create, FileAccess.Write);

                StreamWriter sw = new StreamWriter(yaz);

                if (checkBox_yon.Checked == true)
                {
                    sw.WriteLine(cmb_bilet_turu.Text + "-" + txt_ad.Text + "-" + txt_tel.Text + "-" + cmb_nereden.Text + "-" + cmb_nereye.Text + "-" + dateTimePicker_gidis.Value + "-" + tutar);
                }
                else
                {
                    sw.WriteLine(cmb_bilet_turu.Text + "-" + txt_ad.Text + "-" + txt_tel.Text + "-" + cmb_nereden.Text + "-" + cmb_nereye.Text + "-" + dateTimePicker_gidis.Value + "/" + dateTimePicker_donus.Value + "-" + tutar);
                }
                sw.Close();

            }
            else
            {
                FileStream yaz = new FileStream(path, FileMode.Append, FileAccess.Write);

                StreamWriter sw = new StreamWriter(yaz);

                if (checkBox_yon.Checked == true)
                {
                    sw.WriteLine(cmb_bilet_turu.Text + "-" + txt_ad.Text + "-" + txt_tel.Text + "-" + cmb_nereden.Text + "-" + cmb_nereye.Text + "-" + dateTimePicker_gidis.Value + "-" + tutar);
                }
                else
                {
                    sw.WriteLine(cmb_bilet_turu.Text + "-" + txt_ad.Text + "-" + txt_tel.Text + "-" + cmb_nereden.Text + "-" + cmb_nereye.Text + "-" + dateTimePicker_gidis.Value + "/" + dateTimePicker_donus.Value + "-" + tutar);
                }

                sw.Close();
            }

        }
        void Kaydet(double tutar, string ekstra)
        {
            string path = @"C:\Users\MOSTER\Desktop\Bilet.txt";

            if (!File.Exists(path))
            {
                FileStream yaz = new FileStream(path, FileMode.Create, FileAccess.Write);

                StreamWriter sw = new StreamWriter(yaz);
                if (checkBox_yon.Checked == true)
                {
                    sw.WriteLine(cmb_bilet_turu.Text + "-" + txt_ad.Text + "-" + txt_tel.Text + "-" + cmb_nereden.Text + "-" + cmb_nereye.Text + "-" + dateTimePicker_gidis.Value + "-" + ekstra + "-" + tutar);
                }
                else
                {
                    sw.WriteLine(cmb_bilet_turu.Text + "-" + txt_ad.Text + "-" + txt_tel.Text + "-" + cmb_nereden.Text + "-" + cmb_nereye.Text + "-" + dateTimePicker_gidis.Value + "/" + dateTimePicker_donus.Value + "-" + ekstra + "-" + tutar);
                }


                sw.Close();

            }
            else
            {
                FileStream yaz = new FileStream(path, FileMode.Append, FileAccess.Write);

                StreamWriter sw = new StreamWriter(yaz);

                if (checkBox_yon.Checked == true)
                {
                    sw.WriteLine(cmb_bilet_turu.Text + "-" + txt_ad.Text + "-" + txt_tel.Text + "-" + cmb_nereden.Text + "-" + cmb_nereye.Text + "-" + dateTimePicker_gidis.Value + "-" + ekstra + "-" + tutar);
                }
                else
                {
                    sw.WriteLine(cmb_bilet_turu.Text + "-" + txt_ad.Text + "-" + txt_tel.Text + "-" + cmb_nereden.Text + "-" + cmb_nereye.Text + "-" + dateTimePicker_gidis.Value + "/" + dateTimePicker_donus.Value + "-" + ekstra + "-" + tutar);
                }
                sw.Close();
            }

        }
        bool TarihKontrol()
        {
            bool knt = true;

            DateTime gidis = dateTimePicker_gidis.Value, donus = dateTimePicker_donus.Value;
            TimeSpan kntTarih = donus - gidis;
            if (kntTarih.Days == 0 && dateTimePicker_donus.Enabled != false)
            {
                MessageBox.Show("Aynı Tarihte Dönüş Bileti Alamazsınız!");

                knt = false;
            }

            return knt;
        }
        bool TarihKontrol(DateTime gidis, DateTime donus)
        {
            bool knt = true;

            TimeSpan kntTarih = donus - gidis;

            if (kntTarih.Days < 0)
            {
                MessageBox.Show("Dönüşünüzü Eski Tarih Seçemezsiniz!");
                dateTimePicker_donus.Value = DateTime.Now;
            }

            return knt;
        }
        void Yenile()
        {
            listBox_biletler.Items.Clear();

            string path = @"C:\Users\MOSTER\Desktop\Bilet.txt";


            if (File.Exists(path))
            {
                string[] liste = File.ReadAllLines(path);

                foreach (var item in liste)
                {
                    listBox_biletler.Items.Add(item);
                }
            }
        }
        void Temizle()
        {
            cmb_bilet_turu.SelectedIndex = 0;
            cmb_nereden.SelectedIndex = -1;
            cmb_nereye.SelectedIndex = -1;

            txt_ad.Clear();
            txt_tel.Clear();

            numericUpDown1.Value = 1;

        }
        public void HavaAlanıIsim(ComboBox one, ComboBox two)
        {
            string[] havalanı = { "İstanbul Havalimanı", "Adana Havalimanı", "Adıyaman Havalimanı", "İzmir Havalimanı", "Trabzon Havalimanı", "Konya Havalimanı", "Samsun Havalimanı", "Sivas Havalimanı", "Antalya Havalimanı", "Kayseri Havalimanı", "Hatay Havalimanı", "Van Havalimanı", "Edirne Havalimanı" };

            Array.Sort(havalanı);


            foreach (var item in havalanı)
            {
                one.Items.Add(item);
            }

            foreach (var item in havalanı)
            {
                two.Items.Add(item);
            }
        }
    }
}