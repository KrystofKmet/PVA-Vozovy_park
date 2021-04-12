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
    public partial class FormUserChangePassword : Form
    {
        public FormUserChangePassword()
        {
            InitializeComponent();
        }

        private void FormUserChangePassword_Load(object sender, EventArgs e)
        {
            if (FormLogin.zmenitHeslo == true)
            {
                MessageBox.Show("Je požadovaná změna hesla!");
            }
        }

        private string jmenoSouboru = "users.txt";

        private void ZapisNoveHesloDoSouboru(string noveHeslo)
        {
            string[] novySeznam = new string[FormLogin.seznamUzivatelu.Length];

            for (int i = 0; i < FormLogin.seznamUzivatelu.Length; i++)
            {
                char separator = '|';
                string[] oddelene = FormLogin.seznamUzivatelu[i].Split(separator);
                Guid aktualniID = Guid.Parse(oddelene[4]);

                if (aktualniID == FormLogin.IDPrihlasenehoUzivatele)
                {
                    novySeznam[i] = oddelene[0] + "|" + oddelene[1] + "|" + oddelene[2] + "|" + noveHeslo + "|" + oddelene[4] + "|" + oddelene[5];
                    FormLogin.zmenitHeslo = false;
                }
                else
                {
                    novySeznam[i] = FormLogin.seznamUzivatelu[i];
                }
            }

            FormLogin.seznamUzivatelu = novySeznam;     //Aktualizuji seznam uživatelů
            File.WriteAllLines(jmenoSouboru, FormLogin.seznamUzivatelu); //Zapisuji do souboru
        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {
            string stareHeslo = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(textBoxStareHeslo.Text));
            string noveHeslo = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(textBoxNoveHeslo.Text));

            if (stareHeslo == "")
            {
                labelPrazdneStareHeslo.Visible = true;
            }
            else
            {
                labelPrazdneStareHeslo.Visible = false;

                if (stareHeslo == FormLogin.hesloPrihlasenehoUzivatele)
                {
                    labelPrazdneStareHeslo.Text = "Vyplňte staré heslo";
                    labelPrazdneStareHeslo.Visible = false;

                    if (noveHeslo == "")
                    {
                        labelPrazdneNoveHeslo.Visible = true;
                    }
                    else
                    {
                        labelPrazdneNoveHeslo.Visible = false;

                        if(noveHeslo == stareHeslo)
                        {
                            labelPrazdneNoveHeslo.Text = "Staré a nové heslo nemohou být stejné";
                            labelPrazdneNoveHeslo.Visible = true;
                        }
                        else
                        {
                            labelPrazdneNoveHesloZnovu.Text = "Vyplňte nové heslo znovu";
                            labelPrazdneNoveHesloZnovu.Visible = false;

                            if (textBoxNoveHesloZnovu.Text == "")
                            {
                                labelPrazdneNoveHesloZnovu.Visible = true;
                            }
                            else
                            {
                                labelPrazdneNoveHesloZnovu.Visible = false;

                                if (textBoxNoveHeslo.Text == textBoxNoveHesloZnovu.Text)
                                {
                                    labelPrazdneNoveHesloZnovu.Text = "Vyplňte nové heslo znovu";
                                    labelPrazdneNoveHesloZnovu.Visible = false;

                                    //Uživatel správně zadal staré i nové heslo
                                    FormLogin.hesloPrihlasenehoUzivatele = noveHeslo;
                                    ZapisNoveHesloDoSouboru(noveHeslo);
                                    MessageBox.Show("Vaše heslo bylo úspěšně změněno");
                                    this.Close();
                                }
                                else
                                {
                                    labelPrazdneNoveHesloZnovu.Text = "Nové heslo znovu je špatně, prosím zkuste to znovu";
                                    labelPrazdneNoveHesloZnovu.Visible = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    labelPrazdneStareHeslo.Text = "Staré heslo je špatně, prosím zkuste to znovu";
                    labelPrazdneStareHeslo.Visible = true;
                }
            }
        }
    }
}
