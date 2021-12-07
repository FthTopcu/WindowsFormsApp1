using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double FirstNumber;

        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Button b = new Button();
            //this.Controls.Add(b);
            //b.Width = 50;
            //b.Height = 50;
            //b.Left = 50;
            //b.Top = 50;

            Button[,] button = new Button[8, 8];
            int top = 0;
            int left = 0;
            this.Controls.Add(button[0, 0]);
            for (int i = 0; i < button.GetLength(0); i++)
            {
                for (int j = 0; j < button.GetLength(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 50;
                    button[i, j].Height = 50;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {

                        button[i, j].BackColor = Color.Black;
                        button[i, j].Click += new EventHandler(buttonSiyah_Click);

                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                        button[i, j].Click += new EventHandler(buttonBeyaz_Click);
                    }
                    groupBox1.Controls.Add(button[i, j]);
                    groupBox1.Name = "Kareler";

                }
                left = 0;
                top += 50;
            }
        }
        private void buttonSiyah_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siyah");
        }
        private void buttonBeyaz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beyaz");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Sifir.Text = "0";
            Bir.Text = "1";
            Iki.Text = "2";
            Uc.Text = "3";
            Dort.Text = "4";
            Bes.Text = "5";
            Alti.Text = "6";
            Yedi.Text = "7";
            Sekiz.Text = "8";
            Dokuz.Text = "9";
            Ce.Text = "Ce";
            Cikarma.Text = "-";
            Toplama.Text = "+";
            Carpma.Text = "*";
            Bolme.Text = "/";
            Sonuc.Text = "=";

        }

        private void Bir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "1";

            }

            else

            {

                textBox1.Text = textBox1.Text + "1";

            }
        }

        private void Iki_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "2";

            }

            else

            {

                textBox1.Text = textBox1.Text + "2";

            }
        }

        private void Uc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "3";

            }

            else

            {

                textBox1.Text = textBox1.Text + "3";

            }
        }

        private void Dort_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "4";

            }

            else

            {

                textBox1.Text = textBox1.Text + "4";

            }
        }

        private void Bes_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "5";

            }

            else

            {

                textBox1.Text = textBox1.Text + "5";

            }
        }

        private void Alti_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "6";

            }

            else

            {

                textBox1.Text = textBox1.Text + "6";

            }
        }

        private void Yedi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "7";

            }

            else

            {

                textBox1.Text = textBox1.Text + "7";

            }
        }

        private void Sekiz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "8";

            }

            else

            {

                textBox1.Text = textBox1.Text + "8";

            }
        }

        private void Dokuz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "9";

            }

            else

            {

                textBox1.Text = textBox1.Text + "9";

            }
        }

        private void Sifir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "0";

            }

            else

            {

                textBox1.Text = textBox1.Text + "0";

            }
        }

        private void Ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            
        }

        private void Cikarma_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "-";
        }

        private void Toplama_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "+";
        }

        private void Bolme_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "/";
        }

        private void Carpma_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "*";
        }

        private void Sonuc_Click(object sender, EventArgs e)
        {
            double SecondNumber;

            double Result;
            try
            {
                SecondNumber = Convert.ToDouble(textBox1.Text);

            
            
            if (Operation == "+")

            {

                Result = (FirstNumber + SecondNumber);

                textBox1.Text = Convert.ToString(Result);

                FirstNumber = Result;

            }

            if (Operation == "-")

            {

                Result = (FirstNumber - SecondNumber);

                textBox1.Text = Convert.ToString(Result);

                FirstNumber = Result;



            }

            if (Operation == "*")

            {

                Result = (FirstNumber * SecondNumber);

                textBox1.Text = Convert.ToString(Result);

                FirstNumber = Result;

            }

            if (Operation == "/")
            {
                if (SecondNumber == 0)

                {

                    textBox1.Text = "Uygulanamaz";

                }

                else

                {

                    Result = (FirstNumber / SecondNumber);

                    textBox1.Text = Convert.ToString(Result);

                    FirstNumber = Result;
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

