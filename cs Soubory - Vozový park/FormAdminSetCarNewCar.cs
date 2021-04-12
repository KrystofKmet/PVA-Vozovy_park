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
    public partial class FormAdminSetCarNewCar : Form
    {
        public FormAdminSetCarNewCar()
        {
            InitializeComponent();
        }

        private string jmenoSouboruAuta = "cars.txt";
        private string jmenoSouboruServisniUkony = "service.txt";

        private void ZapisAutomobilDoSouboru(Guid ID, string znacka, string model, string typ, double spotreba)
        {
            if (File.Exists(jmenoSouboruAuta))
            {
                string[] novySeznam = new string[FormLogin.seznamAut.Length + 1];

                for (int i = 0; i < FormLogin.seznamAut.Length; i++)
                {
                    novySeznam[i] = FormLogin.seznamAut[i];
                }
                novySeznam[novySeznam.Length - 1] = znacka + "|" + model + "|" + typ + "|" + spotreba + "|" + ID + "|" + true;
                FormLogin.seznamAut = novySeznam;
                File.WriteAllLines(jmenoSouboruAuta, FormLogin.seznamAut);
            }
            else
            {
                string[] novySeznam = new string[1];
                novySeznam[0] = znacka + "|" + model + "|" + typ + "|" + spotreba + "|" + ID + "|" + true;
                FormLogin.seznamAut = novySeznam;
                File.WriteAllLines(jmenoSouboruAuta, FormLogin.seznamAut);
            }
        }

        private void ZapisServisniUkonyDoSouboru(Guid ID, string servisniUkon, DateTime datumProvedeni, decimal cena, int cisloFaktury)
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
                    novySeznam[FormLogin.seznamServisnichUkonu.Length + i] = ID + "|" + listBox1.SelectedItem.ToString();
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
                    novySeznam[i] = ID + "|" + listBox1.SelectedItem.ToString();
                }
                FormLogin.seznamServisnichUkonu = novySeznam;
                File.WriteAllLines(jmenoSouboruServisniUkony, FormLogin.seznamServisnichUkonu);
            }
        }

        private string servisniUkon;
        private DateTime datumProvedeni;
        private decimal cena;
        private int cisloFaktury;

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

        private void buttonSmazat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void buttonVytvorit_Click(object sender, EventArgs e)
        {
            string znacka = textBoxZnacka.Text;
            string model = textBoxModel.Text;
            string typ = textBoxTyp.Text;
            double spotreba;

            if (textBoxZnacka.Text == "")
            {
                labelPrazdnaZnacka.Visible = true;
            }
            else
            {
                labelPrazdnaZnacka.Visible = false;

                if (textBoxModel.Text == "")
                {
                    labelPrazdnyModel.Visible = true;
                }
                else
                {
                    labelPrazdnyModel.Visible = false;
                    
                    if (textBoxTyp.Text == "")
                    {
                        labelPrazdyTyp.Visible = true;
                    }
                    else
                    {
                        labelPrazdyTyp.Visible = false;

                        if (textBoxSpotreba.Text == "")
                        {
                            labelPrazdnaSpotreba.Visible = true;
                        }
                        else
                        {
                            labelPrazdnaSpotreba.Visible = false;

                            if (double.TryParse(textBoxSpotreba.Text, out spotreba))
                            {
                                labelPrazdnaSpotreba.Visible = false;
                                labelPrazdnaSpotreba.Text = "Vyplňte cenu";

                                //Vše v pořádku
                                Guid ID = Guid.NewGuid();
                                ZapisAutomobilDoSouboru(ID, znacka, model, typ, spotreba);
                                textBoxZnacka.ResetText();
                                textBoxModel.ResetText();
                                textBoxTyp.ResetText();
                                textBoxSpotreba.ResetText();

                                ZapisServisniUkonyDoSouboru(ID, servisniUkon, datumProvedeni, cena, cisloFaktury);
                                listBox1.Items.Clear();
                                MessageBox.Show("Automobil " + znacka + " " + model + " byl úspěšně vytvořen");
                            }
                            else
                            {
                                labelPrazdnaSpotreba.Text = "Spotřeba musí být číslo";
                                labelPrazdnaSpotreba.Visible = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
