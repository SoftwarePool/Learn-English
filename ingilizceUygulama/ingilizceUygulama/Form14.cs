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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string girilen = textBox1.Text;
            string cevap = "Banana";
            string cevapp = "banana";
            if (girilen == cevap || girilen==cevapp)
            {
                label2.BackColor = Color.Green;
                label2.Text = "Doğru";
                Application.DoEvents();
                Thread.Sleep(400); //Butonumuzun renginin değiştirildiğini görebilmek için ekranda bekletiyoruz.
                this.Hide();
                Form15 f15 = new Form15();
                f15.Show();

            }
            else
            {
                label2.BackColor = Color.Red;
                label2.Text = "Yanlış Cevap. Yeniden Dene!";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
