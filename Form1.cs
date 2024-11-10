using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overloading_o1
{
    public partial class Form1 : Form
    {
        private int sayac;

        public Form1()
        {
            InitializeComponent();
        }
        public void asal(int sayi)
        {
            int sayac = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }

            if (sayac == 0)
            {
                listBox1.Items.Add("asaldır" + sayi);
            }
            else
            {
                listBox1.Items.Add("asal sayı değildir." + sayi);
            }
        }

        public void asal(int baslangic, int son)
        {
            for (int i = baslangic; i <= son; i++)
            {
                int sayac = 0;
                for (int j = 2; j < baslangic; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                        break;
                    }

                    if (sayac == 0)
                    {
                        listBox1.Items.Add("asaldır." + i);
                    }

                    else
                    {
                        listBox1.Items.Add("asal değildir." + i);
                    }
                }
            }
        }

        public void asal(params int[] sayilar)
        {
            Random rastgeleSayi = new Random();
            int uSayi = Convert.ToInt32(textBox1.Text);
            int sayi = 0;
            for (int i = 0; i < uSayi; i++)
            {
                sayi = rastgeleSayi.Next(1, 100);
                int sayac = 0;
                for (int j = 2; j < sayi; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }

                }

                if (sayac == 0)
                {
                    listBox1.Items.Add("asaldır." + sayi);
                }
                else
                {
                    listBox1.Items.Add("asal değildir." + sayi);

                }

            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("1.Metot");
                asal(sayi1);
                listBox1.Items.Add("-----");
                listBox1.Items.Add("3. Metot");
                asal();
            }
            else
            {
                listBox1.Items.Clear();
                int sayi2 = Convert.ToInt32(textBox2.Text);
                listBox1.Items.Add("2. Metot");
                asal(sayi1, sayi2);

            }


        }

        public Boolean Asal(int sayi)
        {
            bool asal = true;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0 && i != 1)
                {
                    asal = false;
                }
            }
            return asal;
        }

        public void asalSayi(int baslangic, int bitis)
        {
            if (Asal(baslangic))
            {
                listBox1.Items.Add(baslangic.ToString() + "asaldır.");
            }
            baslangic++;
            if (baslangic <= bitis)
            {
                asalSayi(baslangic, bitis);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            asalSayi(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

        }
    }
}
