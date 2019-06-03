using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            buttonNowaGra.Enabled = false;
        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            // wczytaj zakres do losowania
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            // utwórz gre
            g = new Gra(a, b);

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            buttonWylosuj.Enabled = false;

            // wyświetl kolejne elementy formularza

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
