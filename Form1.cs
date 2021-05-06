using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometrikCisim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int UzunKenar, KisaKenar,Alan,Cevre;
                UzunKenar = Convert.ToInt32(textBox1.Text);
                KisaKenar = Convert.ToInt32(textBox2.Text);

                Alan = UzunKenar * KisaKenar;
                Cevre = 2 * (UzunKenar + KisaKenar);

                label13.Text = Cevre.ToString();
                label11.Text = Alan.ToString();
               
            }
            if (radioButton2.Checked == true)
            {
                int Kenar1, Kenar2, Taban, Yukseklik,Alan,Cevre;

                Kenar1 = Convert.ToInt32(textBox4.Text);
                Kenar2 = Convert.ToInt32(textBox3.Text);
                Taban = Convert.ToInt32(textBox5.Text);
                Yukseklik= Convert.ToInt32(textBox6.Text);

                Cevre = Kenar1 + Kenar2 + Taban;
                Alan = (Taban * Yukseklik) / 2;

                label13.Text = Cevre.ToString();
                label11.Text = Alan.ToString();

            }
            if (radioButton3.Checked == true)
            {
                int YariCap, PiSayisi,Alan,Cevre;
                YariCap = Convert.ToInt32(textBox8.Text);
                PiSayisi = Convert.ToInt32(textBox7.Text);

                Cevre = 2 * PiSayisi * YariCap;
                Alan = PiSayisi * YariCap * YariCap;


                label13.Text = Cevre.ToString();
                label11.Text = Alan.ToString();
            }


        }
    }
}
