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
    public partial class FormAdminSetCarService : Form
    {
        public FormAdminSetCarService()
        {
            InitializeComponent();
        }

        private string servisniUkon;
        private DateTime datumProvedeni;
        private decimal cena;
        private int cisloFaktury;

        private string jmenoSouboruAuta = "cars.txt";
        private string jmenoSouboruServisniUkony = "service.txt";

        private void AktualizujSeznamServisnichUkonu()
        {
            listBox1.Items.Clear();
            if (File.Exists(jmenoSouboruServisniUkony))
            {
                for (int i = 0; i < FormLogin.seznamServisnichUkonu.Length; i++)
                {
                    char separator = '|';
                    string[] oddelene = FormLogin.seznamServisnichUkonu[i].Split(separator);

                    string AktualniIdAuta = oddelene[0];

                    if (FormAdminSetCar.IDoznacenehoAuta.ToString() == AktualniIdAuta)
                    {
                        string radek = oddelene[1] + "|" + oddelene[2] + "|" +oddelene[3] + "|" + oddelene[4];
                        listBox1.Items.Add(radek);
                    }
                }
            }
        }

        private void buttonPridat_Click(object sender, EventArgs e)
        {
            servisniUkon = textBoxServisniUkon.Text;
            datumProvedeni = dateTimePickerDatumProvedeni.Value;

            if (textBoxServisniUkon.Text == "")
            {
                labelPrazdnyServisniUkon.Visible = true;
            }
            else
            {
                labelPrazdnyServisniUkon.Visible = false;

                if (textBoxCena.Text == "")
                {
                    labelPrazdnaCena.Visible = true;
                }
                else
                {
                    labelPrazdnaCena.Visible = false;

                    if (decimal.TryParse(textBoxCena.Text, out cena))
                    {
                        labelPrazdnaCena.Visible = false;
                        labelPrazdnaCena.Text = "Vyplňte cenu";

                        if (textBoxCisloFaktury.Text == "")
                        {
                            labelPrazdneCisloFaktury.Visible = true;
                        }
                        else
                        {
                            labelPrazdneCisloFaktury.Visible = false;

                            if (int.TryParse(textBoxCisloFaktury.Text, out cisloFaktury))
                            {
                                labelPrazdneCisloFaktury.Visible = false;
                                labelPrazdneCisloFaktury.Text = "Vyplňte číslo faktury";

                                //Vše v pořádku
                                string radek = servisniUkon + "|" + datumProvedeni.Date + "|" + cena + "|" + cisloFaktury;
                                listBox1.Items.Add(radek);

                                textBoxServisniUkon.ResetText();
                                textBoxCena.ResetText();
                                textBoxCisloFaktury.ResetText();
                            }
                            else
                            {
                                labelPrazdneCisloFaktury.Text = "Číslo faktury musí být číslo";
                                labelPrazdneCisloFaktury.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        labelPrazdnaCena.Text = "Cena musí být číslo";
                        labelPrazdnaCena.Visible = true;
                    }
                }
            }
        }

        private void FormAdminSetCarService_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(jmenoSouboruServisniUkony))
            {
                string[] novySeznam = new string[FormLogin.seznamServisnichUkonu.Length + listBox1.Items.Count];

                for (int i = 0; i < FormLogin.seznamServisnichUkonu.Length; i++)
                {
                    novySeznam[i] = FormLogin.seznamServisnichUkonu[i];
                }

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SelectedIndex = i;
                    novySeznam[FormLogin.seznamServisnichUkonu.Length + i] = FormAdminSetCar.IDoznacenehoAuta + "|" + listBox1.SelectedItem.ToString();
                }

                FormLogin.seznamServisnichUkonu = novySeznam;
                File.WriteAllLines(jmenoSouboruServisniUkony, FormLogin.seznamServisnichUkonu);
            }
            else
            {
                string[] novySeznam = new string[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SelectedIndex = i;
                    novySeznam[FormLogin.seznamServisnichUkonu.Length + i] = FormAdminSetCar.IDoznacenehoAuta + "|" + listBox1.SelectedItem.ToString();
                }
                FormLogin.seznamServisnichUkonu = novySeznam;
                File.WriteAllLines(jmenoSouboruServisniUkony, FormLogin.seznamServisnichUkonu);
            }
        }

        private void FormAdminSetCarService_Load(object sender, EventArgs e)
        {
            AktualizujSeznamServisnichUkonu();
        }

        private void buttonSmazat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
