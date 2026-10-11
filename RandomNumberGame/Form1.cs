using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGame
{
    public partial class Form1 : Form
    {
        int num;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void yenioyunbtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(0, 101);
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            count = 0;
            errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Axtarılan ədəd xanası boş ola bilməz!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            int a = Convert.ToInt32(textBox1.Text);

            if (a == num)
            {
                count++;
                textBox2.Text = "Siz düzgün tapdınız!\r\nCəhd sayı: " + count + "\r\nOyunu qazandınız!";
                button1.Enabled = false;
                textBox1.Enabled = false;
            }
            else if (a > num)
            {
                count++;
                textBox2.Text = "Siz yanlış tapdınız!\r\nCəhd sayı: " + count + "\r\nDaxil etdiyiniz ədəd gizli ədəddən böyükdür.";
            }
            else
            {
                count++;
                textBox2.Text = "Siz yanlış tapdınız!\r\nCəhd sayı: " + count + "\r\nDaxil etdiyiniz ədəd gizli ədəddən kiçikdir.";
            }
        }
    }
}