using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Metodlari_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = textBox1.Text;

            int a = int.Parse(textBox2.Text); // a değeri başlangıç değerimiz.

            int b = int.Parse(textBox3.Text); // b değeri ise başlangıçtan itibaren kaç karakter alınacak bunu t

            label5.Text = kelime.Substring(a, b).ToString(); // metodumuzla parçamızı aldık ve yazdırdık.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kelime2 = textBox6.Text;

            int c = int.Parse(textBox5.Text); // başlangıç değerini tutacak.

            label6.Text = kelime2.Substring(c); // başlangıç değerine göre parçaladık.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kelime3 = textBox4.Text; 

            label13.Text = kelime3.Trim('*').ToString(); // baştaki ve sondaki yıldız karakterlerini kaldırdık.


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kelime4 = textBox7.Text;

            label14.Text = kelime4.TrimEnd('#'); // Sondaki # karakterini kaldırdık.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kelime5 = textBox8.Text;
            label17.Text = kelime5.TrimStart('-'); // Baştaki eksi karakterlerini kaldırdık.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string kelime6 = textBox9.Text;

            string d1 = textBox10.Text; // değiştirilecek karakter.

            string d2 = textBox11.Text; // değişimden sonra yazılacak ifade.

            label24.Text = kelime6.Replace(d1,d2); // değişimi yaptık.

           
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
