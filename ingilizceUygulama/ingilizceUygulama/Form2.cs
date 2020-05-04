using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Sql;
namespace ingilizceUygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;



        private void button1_Click(object sender, EventArgs e)
        {

              string ad = textBox1.Text;
              string sifre = textBox2.Text;
              con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kullaniciGirisi.accdb");
              cmd = new OleDbCommand();
              con.Open();
              cmd.Connection = con;
              cmd.CommandText = "SELECT * FROM kullanici where kullaniciAdi='" + textBox1.Text + "'AND kullaniciSifre='" + textBox2.Text + "'";
              dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }

            else
            {
                MessageBox.Show("Kullanici Adı ya da Şifre Yanlış.");
            }

            con.Close(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}