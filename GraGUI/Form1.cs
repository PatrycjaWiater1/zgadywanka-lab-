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
            try
            {
                int a = int.Parse(textBoxOd.Text);
                int b = int.Parse(textBox2.Text);

                // utwórz gre
                g = new Gra(a, b);

                textBoxOd.Enabled = false;
                textBox2.Enabled = false;
                buttonWylosuj.Enabled = false;

                // wyświetl kolejne elementy formularza
                textBoxSprawdz.Visible = true;
                buttonSprawdz.Visible = true;
            }
            catch (FormatException er)
            {
                errorMsg.Text = er.Message;
                errorMsg.Visible = true;
            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void errorMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
