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

namespace MACERA_DÜNYASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int kolaygonder = 200;
        public int ortagonder = 100;
        public int zorgonder = 1;
        

        private void AYARLARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form7 ayar = new Form7();
            this.Hide();
            ayar.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    Form2 oyun1 = new Form2();
                    this.Hide();
                    oyun1.timer2.Interval = kolaygonder;
                    oyun1.Show();
                }

                else if (checkBox2.Checked == true)
                {
                    Form2 oyun1 = new Form2();
                    this.Hide();
                    oyun1.timer2.Interval = ortagonder;
                    oyun1.Show();
                }

                else if (checkBox3.Checked == true)
                {
                    Form2 oyun1 = new Form2();
                    this.Hide();
                    oyun1.timer2.Interval = zorgonder;
                    oyun1.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen bir zorluk seçiniz!");
                }

            }

            else if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    Form3 oyun2 = new Form3();
                    oyun2.timer2.Interval = kolaygonder;
                    this.Hide();
                    oyun2.Show();
                }


                else if (checkBox2.Checked == true)
                {
                    Form3 oyun2 = new Form3();
                    oyun2.timer2.Interval = ortagonder;
                    this.Hide();
                    oyun2.Show();
                }


                else if (checkBox3.Checked == true)
                {
                    Form3 oyun2 = new Form3();
                    oyun2.timer2.Interval = zorgonder;
                    this.Hide();
                    oyun2.Show();
                }

                else
                {
                    MessageBox.Show("Lütfen bir zorluk seçiniz!");
                }

            }

            else if (radioButton3.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    Form4 oyun3 = new Form4();
                    oyun3.timer2.Interval = kolaygonder;
                    this.Hide();
                    oyun3.Show();
                }


                else if (checkBox2.Checked == true)
                {
                    Form4 oyun3 = new Form4();
                    oyun3.timer2.Interval = ortagonder;
                    this.Hide();
                    oyun3.Show();
                }


                else if (checkBox3.Checked == true)
                {
                    Form4 beach = new Form4();
                    beach.timer2.Interval = zorgonder;
                    this.Hide();
                    beach.Show();
                }

                else
                {
                    MessageBox.Show("Lütfen bir zorluk seçiniz!");
                }

            }

            else if (radioButton4.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    Form5 oyun4 = new Form5();
                    oyun4.timer2.Interval = kolaygonder;
                    this.Hide();
                    oyun4.Show(); ;
                }


                else if (checkBox2.Checked == true)
                {
                    Form5 oyun4 = new Form5();
                    oyun4.timer2.Interval = ortagonder;
                    this.Hide();
                    oyun4.Show(); ;
                }


                else if (checkBox3.Checked == true)
                {
                    Form5 oyun4 = new Form5();
                    oyun4.timer2.Interval = zorgonder;
                    this.Hide();
                    oyun4.Show(); ;
                }

                else
                {
                    MessageBox.Show("Lütfen bir zorluk seçiniz!");
                }

            }

            else if (radioButton5.Checked == true)
            {

                if (checkBox1.Checked == true)
                {
                    Form6 oyun5 = new Form6();
                    oyun5.timer2.Interval = kolaygonder;
                    this.Hide();
                    oyun5.Show();
                }


                else if (checkBox2.Checked == true)
                {
                    Form6 oyun5 = new Form6();
                    oyun5.timer2.Interval = ortagonder;
                    this.Hide();
                    oyun5.Show();
                }


                else if (checkBox3.Checked == true)
                {
                    Form6 oyun5 = new Form6();
                    oyun5.timer2.Interval = zorgonder;
                    this.Hide();
                    oyun5.Show();
                }

                else
                {
                    MessageBox.Show("Lütfen bir zorluk seçiniz!");
                }

            }
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
        }

        private void dURAKLATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;

            }
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }

            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}