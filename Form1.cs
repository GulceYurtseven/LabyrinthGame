using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lebirent
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
        }   

        string[,] oyun = new string[10, 4];
        int[] sayi = new int[10];
        int j, kolaySaniye = 50, ortaSaniye = 25, zorSaniye = 10;

        private void buttonAktiflestir()
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            timer1.Enabled = true;
        }
        
        private void xler()
        {
            string yedek = "";
            //string[,] oyun = new string[10, 4];
            for (int i = 0; i < 10; i++)
            {
                yedek = "";
                for (int j = 0; j < 4; j++)
                {
                    yedek = yedek  + "  " + oyun[i, j] ;// x leri yerleştir
                }
                Harita.Items.Add(yedek);
            }
        }

        private void oyunaBaslabutton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    oyun[i, j] = "X";// x leri diziye al
                }
            }           
            for (int i = 0; i < 10; i++)
            {
                sayi[i] = rand.Next(1, 5);
                Sayılar.Items.Add(sayi[i].ToString());
            }
            xler();
            buttonAktiflestir();
        }

        int a = 0, b = 0, k = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            j = Convert.ToInt16(button1.Text);
            if (sayi[a] == j){
                oyun[b, j-1] = "*";
                b++;
                a++;
                if (b == 10)
                {
                    MessageBox.Show("TEBRİKLER!!");
                }
            }
            else
            {
                k--;
                MessageBox.Show("HATA YAPTIN kalan hakkın: "+ k.ToString());
                if (k == 0)
                {
                    //MessageBox.Show("AĞLA");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    oyunaBaslabutton.Enabled = false;

                }
            }
            Harita.Items.Clear();
            xler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            j = Convert.ToInt16(button2.Text);
            if (sayi[a] == j)
            {
                oyun[b, j - 1] = "*";
                b++;
                a++;
                if (b == 10)
                {
                    MessageBox.Show("TEBRİKLER!!");
                }
            }
            else
            {
                k--;
                MessageBox.Show("HATA YAPTIN kalan hakkın: "+ k.ToString());
                if (k == 0)
                {
                   // MessageBox.Show("AĞLA");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    oyunaBaslabutton.Enabled = false;

                }
            }
            Harita.Items.Clear();
            xler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            j = Convert.ToInt16(button3.Text);
            if (sayi[a] == j)
            {
                oyun[b, j - 1] = "*";
                b++;
                a++;
                if (b == 10)
                {
                    MessageBox.Show("TEBRİKLER!!");
                }
            }
            else
            {
                k--;
                MessageBox.Show("HATA YAPTIN kalan hakkın: "+ k.ToString());
                if (k == 0)
                {
                    //MessageBox.Show("AĞLA");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    oyunaBaslabutton.Enabled = false;

                }
            }
            Harita.Items.Clear();
            xler();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            j = Convert.ToInt16(button4.Text);
            if (sayi[a] == j)
            {
                oyun[b, j - 1] = "*";
                b++;
                a++;
                if (b == 10)//sona ulaşmış demektir
                {
                    MessageBox.Show("TEBRİKLER!!");
                }
            }
            else
            {
                k--;
                MessageBox.Show("HATA YAPTIN kalan hakkın: "+ k.ToString());
                if (k == 0)
                {
                    //MessageBox.Show("AĞLA");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    oyunaBaslabutton.Enabled = false;    
                }
            }
            Harita.Items.Clear();
            xler();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                kolaySaniye--;
                kalanSureLabel.Text = kolaySaniye.ToString();
                
                if (kolaySaniye == 0)
                {
                    timer1.Stop();
                    Sayılar.Visible = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
            }
            if (radioButton2.Checked)
            {
               
                ortaSaniye--;
                kalanSureLabel.Text = ortaSaniye.ToString();
                if (ortaSaniye == 0)
                {
                    timer1.Stop();
                    Sayılar.Visible = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
            }
            if (radioButton3.Checked)
            {
              
                zorSaniye--;
                kalanSureLabel.Text = zorSaniye.ToString();
                if (zorSaniye == 0)
                {
                    timer1.Stop();
                    Sayılar.Visible = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
            }
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkSlateBlue;
        }
      
        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
        }
    }
}