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
using static ModelGry.Gra;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;
        private Ruch hist = new Ruch();
        public Form1()
        {
            InitializeComponent();
            this.Width = 326;
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
                int b = int.Parse(textBoxDo.Text);

                // utwórz gre
                g = new Gra(a, b);

                textBoxOd.Enabled = false;
                textBoxDo.Enabled = false;
                buttonWylosuj.Enabled = false;

                // wyświetl kolejne elementy formularza
                textBoxSprawdz.Visible = true;
                buttonSprawdz.Visible = true;
                WylosowanaLiczba.Visible = true;
                WylosowanaLiczba.Text = g.wylosowana.ToString();
            }
            catch (FormatException er)
            {
                string message = er.Message + Environment.NewLine + "Wprowadz poprawna liczbe.";
                string title = "Niepoprawne dane";
                MessageBox.Show(message, title);
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

        private void ClearAndFocusTextbox()
        {
            textBoxSprawdz.Text = "";
            textBoxSprawdz.Focus();
        }

        private void NewGame()
        {
            textBoxHistoria.Text = "";
            hist = null;
            hist = new Ruch();
            textBoxOd.Enabled = true;
            textBoxDo.Enabled = true;
            buttonWylosuj.Enabled = true;
            WylosowanaLiczba.Visible = false;
            textBoxSprawdz.Visible = false;
            buttonSprawdz.Visible = false;
            LabelWynik.Visible = false;
            buttonAgain.Visible = false;
            textBoxOd.Text = "";
            textBoxDo.Text = "";
            labelIle.Text = "";
            labelIle.Visible = false;
            this.Width = 326;
            this.Height = 522;
            buttonHistoria.Visible = false;
        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            try
            {
                int wprowadzona = int.Parse(textBoxSprawdz.Text);
                Odpowiedz odp = g.Ocena(wprowadzona);
                hist.DodajPozycje(wprowadzona, odp);
                switch (odp)
                {
                    case Odpowiedz.ZaMalo:
                        LabelWynik.Visible = true;
                        LabelWynik.Text = "Za malo!";
                        LabelWynik.ForeColor = System.Drawing.Color.Red;
                        ClearAndFocusTextbox();
                        break;
                    case Odpowiedz.ZaDuzo:
                        LabelWynik.Visible = true;
                        LabelWynik.Text = "Za duzo!";
                        LabelWynik.ForeColor = System.Drawing.Color.Red;
                        ClearAndFocusTextbox();
                        break;
                    case Odpowiedz.Trafiono:
                        LabelWynik.Visible = true;
                        LabelWynik.Text = "Brawo!";
                        LabelWynik.ForeColor = System.Drawing.Color.Green;
                        ClearAndFocusTextbox();
                        buttonAgain.Visible = true;
                        labelIle.Visible = true;
                        labelIle.Text = "Trafiles za " + g.LicznikRuchow.ToString() + " razem";
                        buttonHistoria.Enabled = true;
                        buttonHistoria.Visible = true;
                        break;
                }
            }
            catch (FormatException err)
            {
                string message = err.Message + Environment.NewLine + "Wprowadz poprawna liczbe.";
                string title = "Niepoprawne dane";
                MessageBox.Show(message, title);
            }
            

        }

        private void buttonAgain_Click(object sender, EventArgs e)
        {
            NewGame();
            
        }

        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            buttonHistoria.Enabled = false;
            this.Width = 634;
            this.Height = 522;
            textBoxHistoria.AppendText("Historia ruchow");
            textBoxHistoria.AppendText(Environment.NewLine);
            var data = hist.GetPropozycje();
            int i = 1;
            foreach (var item in data)
            {
                textBoxHistoria.AppendText("Proba "+i+": "+item.ToString());
                textBoxHistoria.AppendText(Environment.NewLine);
                i++;
            }
            //textBoxHistoria.AppendText(data[0].ToString());
            //textBoxHistoria.AppendText(Environment.NewLine);
            //textBoxHistoria.AppendText(data[1].ToString());

        }
    }
}
