using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vozovy_park
{
    public partial class FormAdminSetCar : Form
    {
        public FormAdminSetCar()
        {
            InitializeComponent();
            AktualizujSeznamAut();
        }

        private string jmenoSouboruAuta = "cars.txt";

        private void AktualizujSeznamAut()
        {
            if (File.Exists(jmenoSouboruAuta))
            {
                for (int i = 0; i < FormLogin.seznamAut.Length; i++)
                {
                    listBox1.Items.Add(FormLogin.seznamAut[i]);
                }
            }
        }

        private void buttonVlozitNovyAutomobil_Click(object sender, EventArgs e)
        {
            FormAdminSetCarNewCar formAdminSetCarNewCar = new FormAdminSetCarNewCar();
            formAdminSetCarNewCar.ShowDialog();
        }

        private void buttonAktualizovatSeznamAut_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AktualizujSeznamAut();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            char separator = '|';
            string[] oddelene = listBox1.SelectedItem.ToString().Split(separator);
            
            
            if (bool.Parse(oddelene[5]) == true) //Když je automobil dostupný
            {
                buttonDostupnyNedostupny.Text = "Nedostupné";
            }
            else
            {
                buttonDostupnyNedostupny.Text = "Dostupné";
            }
        }

        private void buttonDostupnyNedostupny_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                int oznacenyIndex = listBox1.SelectedIndex;

                string[] novySeznam = new string[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SelectedIndex = i;
                    if (i == oznacenyIndex)
                    {
                        char separator = '|';
                        string[] oddelene = listBox1.SelectedItem.ToString().Split(separator);

                        string novyRadek;
                        if (bool.Parse(oddelene[5]) == true) //Když je automobil dostupný
                        {
                            novyRadek = oddelene[0] + "|" + oddelene[1] + "|" + oddelene[2] + "|" + oddelene[3] + "|" + oddelene[4] + "|" + false;
                        }
                        else
                        {
                            novyRadek = oddelene[0] + "|" + oddelene[1] + "|" + oddelene[2] + "|" + oddelene[3] + "|" + oddelene[4] + "|" + true;
                        }
                        novySeznam[i] = novyRadek;
                    }
                    else
                    {
                        novySeznam[i] = listBox1.SelectedItem.ToString();
                    }
                }

                listBox1.Items.Clear();
                FormLogin.seznamAut = novySeznam;
                File.WriteAllLines(jmenoSouboruAuta, FormLogin.seznamAut);
                AktualizujSeznamAut();

                listBox1.SelectedIndex = oznacenyIndex;
            }
        }

        public static Guid IDoznacenehoAuta;

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            char separator = '|';
            string[] oddelene = listBox1.SelectedItem.ToString().Split(separator);

            IDoznacenehoAuta = Guid.Parse(oddelene[4]);

            FormAdminSetCarService formAdminSetCarService = new FormAdminSetCarService();
            formAdminSetCarService.ShowDialog();
        }

        private void buttonZrusitAutomobil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                int oznacenyIndex = listBox1.SelectedIndex;

                string[] novySeznam = new string[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SelectedIndex = i;
                    if (i == oznacenyIndex)
                    {
                        char separator = '|';
                        string[] oddelene = listBox1.SelectedItem.ToString().Split(separator);

                        string novyRadek;
                        novyRadek = oddelene[0] + "|" + oddelene[1] + "|" + oddelene[2] + "|" + oddelene[3] + "|" + oddelene[4] + "|" + false;
                        novySeznam[i] = novyRadek;
                    }
                    else
                    {
                        novySeznam[i] = listBox1.SelectedItem.ToString();
                    }
                }

                listBox1.Items.Clear();
                FormLogin.seznamAut = novySeznam;
                File.WriteAllLines(jmenoSouboruAuta, FormLogin.seznamAut);
                AktualizujSeznamAut();

                listBox1.SelectedIndex = oznacenyIndex;
            }
        }
    }
}
