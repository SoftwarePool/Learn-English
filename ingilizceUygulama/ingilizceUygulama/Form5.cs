using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizceUygulama
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Tekrar Dene";
            button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Tekrar Dene";
            button2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Tekrar Dene";
            button3.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button4.BackColor = Color.Green;
            Application.DoEvents();
            Thread.Sleep(400); //Butonumuzun renginin değiştirildiğini görebilmek için ekranda bekletiyoruz.
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
