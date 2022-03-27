using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizilerform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] ders = new string[0];
        string[] süre = new string[0];
        string[] dizi = new string[0];
        int[] dizi1 = new int[0];
        int[,] dizi2 = new int[2,2];
        int[,] dizi3 = new int[2,2];
        int i = 0,n=0,k=0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                for (int i = 0; i < ders.Length; i++)
                {
                    listBox1.Items.Add(ders[i] + " dersinin süresi: " + süre[i]);
                }
            }
            else if (radioButton2.Checked)
            {
                foreach (var item in dizi)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (radioButton3.Checked)
            {
                //if (n < ders.Length)
                //{
                //    listBox1.Items.Add($"{ders[n]} dersinin süresi {ders[n + 1]} dakikadır.");
                //    n = n + 2;
                //}
                for (int n = 0; n < ders.Length; n=n+2)
                {
                    listBox1.Items.Add(ders[n] + " dersinin süresi: " + ders[n+1]);
                }
            }
            else if (radioButton4.Checked)
            {
                foreach (var item in dizi1)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (radioButton5.Checked)
            {
                TekCift(dizi1);
            }
            else if (radioButton6.Checked)
            {
               SayıKontrol(dizi1);
            }
            else if (radioButton7.Checked)
            {
               //listBox2.Items.Add(Degistir(ders));
            }
            else if (radioButton8.Checked)
            {
               listBox1.Items.Add(diziler(dizi1));
            }
            else if (radioButton9.Checked)
            {
                Karsilastir(dizi);
            }

        }
        int uzun = 0, indeks = 0,sayac=0;
        string uzunmetin = "", enuzunmetin = "";
        private void Karsilastir(string[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i].Length > uzun)
                {
                    uzun = dizi[i].Length;
                    uzunmetin = dizi[i];
                    indeks = i;
                }
            }
            listBox2.Items.Add("Uzun metin: " + uzunmetin);
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[indeks].Length == dizi[i].Length)
                {
                    enuzunmetin =enuzunmetin+ dizi[i]+",";
                    sayac++;
                }
            }
            listBox2.Items.Add("En uzun metinler: " + enuzunmetin);
            listBox2.Items.Add("En uzun metinin indeks numarası:" + indeks);
        }

        static int toplama = 0,ort=0;
        private static string diziler(int[] dizi1)
        {
            foreach (var item in dizi1)
            {
                toplama += item;
            }
            ort = toplama / dizi1.Length;
            return "Dizi ortalaması: " + ort.ToString();
        }

        static int negsayi = 0, csayi = 0,bessayi = 0;
        static string posayi = "", tsayi = "",ucsayi ="";
        private void SayıKontrol(int[] ali)
        {
            foreach (var item in ali)
            {
                if (item < 0)
                    negsayi++;

                if (item > 0)
                {
                    posayi += item.ToString();
                    posayi += ",";
                }
                if (item % 2 != 0)
                {
                    tsayi += item.ToString();
                    tsayi += ",";
                }
                if (item % 2 == 0)
                {
                    csayi++;
                }
                if(item%3==0 && item != 0)
                {
                    ucsayi += item.ToString();
                    ucsayi += ",";
                }
                if(item%5==0 && item != 5)
                {
                    bessayi += item;
                }

            }
            listBox1.Items.Add("Negatif sayı adeti: " + negsayi.ToString());
            listBox1.Items.Add("Pozitif sayılar: " + posayi);
            listBox1.Items.Add("Tek sayılar: " + tsayi);
            listBox1.Items.Add("Çift sayıların adeti: " + csayi.ToString());
            listBox1.Items.Add("3'e bölünebilen sayılar: " + ucsayi);
            listBox1.Items.Add("5'e bölünebilen sayıalrın toplamı: " + bessayi.ToString());
        }

        int m = 0;
        int toplam = 0, carpım = 1;

        private void TekCift(int[] gel)
        {

            for (m = 0; m < gel.Length; m++)
            {
                if (m % 2 == 0)
                {
                    carpım *= gel[m];
                }
                else
                    toplam = toplam + gel[m];
            }
            listBox2.Items.Add(carpım.ToString());
            listBox1.Items.Add(toplam.ToString());

        }  //toplama çarpma metot void

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "1.Matrisi Doldur: ";
            label2.Text = "2.Matrisi Doldur:";
            label3.Visible = false;
            //textBox2.Visible = true;
            textBox3.Visible = false;
            listBox1.Items.Clear();
            listBox2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            i = 0;
            textBox1.Clear();
            label1.Text = "Dizinin Eleman Sayısı:";
            label2.Text = "Diziye Eleman Ata:";
            label3.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = false;
            listBox1.Items.Clear();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Kaç eleman gireceksiniz:";
            label2.Text = "Dizi elemanlarını gir:";
            label3.Text = "Eleman değiştir: ";
            textBox3.Visible = true;
            label4.Visible = true;
            comboBox1.Visible = true;
            listBox2.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Kaç eleman gireceksiniz:";
            label2.Text = "Diziye eleman gir:";
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            comboBox1.Visible = false;
            listBox2.Visible = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Kaç eleman gireceksiniz:";
            label2.Text = "Diziye sayı gir:";
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            comboBox1.Visible = false;
            listBox2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            snc.Text = "";
            label1.Text = "Kaç ders gireceksiniz: ";
            label2.Text = "Ders Adı:";
            label3.Text = "Ders Süresi:";
            label3.Visible =true;
            textBox3.Visible = true;
            listBox1.Items.Clear();
            i = 0;
            n = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "Kaç ders gireceksiniz: ";
            label2.Text = "Ders Adı:";
            label3.Text = "Ders Süresi:";
            label3.Visible = true;
            textBox3.Visible = true;
            listBox1.Items.Clear();
            i = 0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Kaç eleman gireceksiniz: ";
            label2.Text = "Eleman gir: ";
            label3.Visible = false;
            textBox3.Visible = false;
            button1.Visible = true;
            listBox1.Items.Clear();
            textBox1.Clear();

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Kaç sayı gireceksiniz: ";
            label2.Text = "Eleman gir: ";
            label3.Visible = false;
            textBox3.Visible = false;
            button1.Visible = true;
            listBox1.Items.Clear();
            textBox1.Clear();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Kaç sayı girilecek: ";
            label2.Text = "Sayı gir: ";
            label3.Visible = false;
            textBox3.Visible = false;
            listBox2.Visible = true;
            indis1.Text = "İndisi Tek Olanların Toplamı";
            indis2.Text = "İndisi Çift Olanalrın Çarpımı";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int adet1 = Convert.ToInt32(textBox1.Text);
                Array.Resize(ref ders, adet1);
                Array.Resize(ref süre, adet1);

                if (i < ders.Length)
                {
                    ders[i] = textBox2.Text;
                    textBox2.Clear();
                    i++;
                }

                if (n < süre.Length)
                {
                    süre[n] = textBox3.Text;
                    textBox3.Clear();
                    n++;
                }
                if (n == adet1)
                {
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                }
            }
            else if (radioButton2.Checked)
            {
                
                int adet2 = Convert.ToInt32(textBox1.Text);
                Array.Resize(ref dizi, adet2);
                if(i<dizi.Length)
                {
                        dizi[i] = textBox2.Text;
                        textBox2.Clear();
                        snc.Text = ((i + 1).ToString()+".eleman girildi.");
                        i++;
                }
                if (i == dizi.Length)
                {
                    textBox2.Visible = false;
                }
            }
            else if (radioButton3.Checked)
            {
                int adet3 = int.Parse(textBox1.Text);
                Array.Resize(ref ders, adet3*2);
                if (i < ders.Length)
                {
                    ders[i] = textBox2.Text;
                    ders[i + 1] = textBox3.Text;
                    textBox2.Clear();
                    textBox3.Clear();
                    i = i + 2;
                }
            }
            else if (radioButton4.Checked)
            {
                int adet4 = int.Parse(textBox1.Text);
                Array.Resize(ref dizi1, adet4);
                if (i < dizi1.Length)
                {
                    dizi1[i] = int.Parse(textBox2.Text);
                    if (dizi1[i] < 0 || dizi1[i] > 100)
                    {
                        MessageBox.Show("Sınır dışı giriş yaptınız lütfen tekrar giriş yapınız.");
                        textBox2.Clear();
                    }
                    else
                    {
                        textBox2.Clear();
                        i++;
                    }
                        

                }
                if (i == dizi1.Length)
                {
                    button1.Visible = false;
                }
            }
            else if (radioButton5.Checked)
            {
                int adet5 = int.Parse(textBox1.Text);
                Array.Resize(ref dizi1, adet5);
                if (i < dizi1.Length)
                {
                    dizi1[i] = int.Parse(textBox2.Text);
                    textBox2.Clear();
                    i++;
                    
                }
                if (i == dizi1.Length)
                {
                    button1.Visible = false;
                }

            }
            else if (radioButton6.Checked)
            {
                int adet6 = int.Parse(textBox1.Text);
                Array.Resize(ref dizi1, adet6);
                if (i < adet6)
                {
                    dizi1[i] = int.Parse(textBox2.Text);
                    textBox2.Clear();
                    textBox2.Select();
                    i++;
                }
            }
            else if (radioButton7.Checked)
            {
                //int adet7 = int.Parse(textBox1.Text);
                //Array.Resize(ref ders, adet7);
                //if (i < ders.Length)
                //{
                //    ders[i] = textBox2.Text;
                //    listBox1.Items.Add($"{i+1}.eleman: {ders[i]}");
                //    comboBox1.Items.Add(i + 1);
                //    i++;
                //}
                //if (i == ders.Length)
                //{
                //    button1.Visible = false;
                //}
               
            }
            else if (radioButton8.Checked)
            {
                int adet8 = int.Parse(textBox1.Text);
                Array.Resize(ref dizi1, adet8);
                if (i < dizi1.Length)
                {
                    if (int.TryParse(textBox2.Text, out dizi1[i]))
                    {
                        textBox2.Clear();
                        i++;
                    }
                    else
                        MessageBox.Show("Sayı gir.");
                }
                if (i == dizi1.Length)
                {
                    button1.Visible = false;
                }
            }
            else if (radioButton9.Checked)
            {
                int adet9 = int.Parse(textBox1.Text);
                Array.Resize(ref dizi, adet9);
                if (i < dizi.Length)
                {
                    dizi[i] = textBox2.Text;
                    listBox1.Items.Add(dizi[i]);
                    i++;
                }
            }
            else if (radioButton10.Checked)
            {
                if (i < dizi2.GetLength(0))
                {
                    if (k < dizi2.GetLength(1))
                    {
                        dizi2[i, k] = Convert.ToInt32(textBox1.Text);
                        listBox1.Items.Add($"1.Dizi {i + 1}.satır {k + 1}.sütun: {dizi2[i, k]}");
                        k++;
                    }
                    if (k == dizi2.GetLength(1))
                    {
                        k = 0;
                        i++;
                    }    
                }

                if (i == dizi2.GetLength(0))
                {
                    if (m < dizi3.GetLength(0))
                    {
                        if (n < dizi3.GetLength(1))
                        {
                            dizi3[m, n] = Convert.ToInt32(textBox2.Text);
                            listBox1.Items.Add($"2.Dizi {m + 1}.satır {n + 1}.sütun: {dizi3[m, n]}");
                            n++;
                        }
                        if (n == dizi3.GetLength(1))
                        {
                            n = 0;
                            m++;
                        }
                    }
                }
            }
        }
    }
}
