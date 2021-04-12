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
    public partial class FormAdminSetUserNewUser : Form
    {
        public FormAdminSetUserNewUser()
        {
            InitializeComponent();
        }

        private string jmenoSouboru = "users.txt";

        private void ZapisUzivateleDoSouboru(string jmeno, string prijmeni, bool jeAdmin, string heslo)
        {
            
            Guid ID = Guid.NewGuid();

            if (File.Exists(jmenoSouboru))
            {
                string[] novySeznam = new string[FormLogin.seznamUzivatelu.Length + 1];

                //Naplním novySeznam stávajícími uživateli
                for (int i = 0; i < FormLogin.seznamUzivatelu.Length; i++)
                {
                    novySeznam[i] = FormLogin.seznamUzivatelu[i];
                }
                novySeznam[novySeznam.Length - 1] = jmeno + "|" + prijmeni + "|" + jeAdmin + "|" + heslo + "|" + ID + "|none"; //Na konec seznamu přidávám nově vytvořeného uživatele
                FormLogin.seznamUzivatelu = novySeznam;     //Aktualizuji seznam uživatelů
                File.WriteAllLines(jmenoSouboru, FormLogin.seznamUzivatelu); //Zapisuji do souboru
            }
            else
            {
                string[] novySeznam = new string[1];

                novySeznam[0] = jmeno + "|" + prijmeni + "|" + jeAdmin + "|" + heslo + "|" + ID + "|none"; //Na konec seznamu přidávám nově vytvořeného uživatele
                FormLogin.seznamUzivatelu = novySeznam;     //Aktualizuji seznam uživatelů
                File.WriteAllLines(jmenoSouboru, FormLogin.seznamUzivatelu); //Zapisuji do souboru
            }
        }

        private void buttonVytvorit_Click(object sender, EventArgs e)
        {
            string jmeno = textBoxJmeno.Text;
            string prijmeni = textBoxPrijmeni.Text;
            string heslo = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(textBoxHeslo.Text));
            bool jeAdmin = checkBoxJeAdmin.Checked;

            if (jmeno == "")
            {
                //Když je prázdné jméno
                labelPrazdneJmeno.Visible = true;
            }
            else
            {
                labelPrazdneJmeno.Visible = false;

                if (prijmeni == "")
                {
                    //Když je prázdné příjmení
                    labelPrazdnePrijmeni.Visible = true;
                }
                else
                {
                    labelPrazdnePrijmeni.Visible = false;

                    if (heslo == "")
                    {
                        //Když je prázdné heslo
                        labelPrazdneHeslo.Visible = true;
                    }
                    else
                    {
                        labelPrazdneHeslo.Visible = false;

                        if (textBoxHeslo.Text == textBoxHesloZnovu.Text)
                        {
                            //Když je heslo zadané dobře
                            labelSpatneHeslo.Visible = false;

                            //Vytvoření nového uživatele se zadaným jménem, příjmením a heslem
                            ZapisUzivateleDoSouboru(jmeno, prijmeni, jeAdmin, heslo);
                            textBoxJmeno.ResetText();
                            textBoxPrijmeni.ResetText();
                            textBoxHeslo.ResetText();
                            textBoxHesloZnovu.ResetText();
                            checkBoxJeAdmin.Checked = false;
                            MessageBox.Show("Uživatel " + jmeno + " " + prijmeni + " byl úspěšně vytvořen");
                        }
                        else
                        {
                            //Když je heslo zadané špatně
                            labelSpatneHeslo.Visible = true;
                        }
                    }
                }
            }
        }
    }
}
