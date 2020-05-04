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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string girilen = textBox1.Text;
            string cevap = "Chocolate";
            string cevapp = "chocolate";
            if (girilen == cevap || girilen==cevapp)
            {
                label2.BackColor = Color.Green;
                label2.Text = "Doğru";
                Application.DoEvents();
                Thread.Sleep(400); //Butonumuzun renginin değiştirildiğini görebilmek için ekranda bekletiyoruz.
                this.Hide();
                Form13 f13 = new Form13();
                f13.Show();

            }
            else
            {
                label2.BackColor = Color.Red;
                label2.Text = "Yanlış Cevap. Yeniden Dene!";
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
