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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string girilen = textBox1.Text;
            string cevap = "Pasta";
            string cevapp = "pasta";
            if (girilen == cevap || girilen==cevapp)
            {
                label2.BackColor = Color.Green;
                label2.Text = "Doğru";
                Application.DoEvents();
                Thread.Sleep(400); //Butonumuzun renginin değiştirildiğini görebilmek için ekranda bekletiyoruz.
                this.Hide();
                Form14 f14 = new Form14();
                f14.Show();

            }
            else
            {
                label2.BackColor = Color.Red;
                label2.Text = "Yanlış Cevap. Yeniden Dene!";
            }
        }
    }
}
