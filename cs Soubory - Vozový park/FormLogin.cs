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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private string jmenoSouboruUzivatele = "users.txt";
        private string jmenoSouboruAuta = "cars.txt";
        private string jmenoSouboruServisniUkony = "service.txt";
        private string jmenoSouboruRezervace = "reservation.txt";

        public static string[] seznamUzivatelu;
        public static string[] seznamAut;
        public static string[] seznamServisnichUkonu;
        public static string[] seznamRezervaci;

        public static bool zmenitHeslo = false;

        public static string jmenoPrihlasenehoUzivatele;
        public static string prijmeniPrihlasenehoUzivatele;
        public static bool jePrihlasenyUzivatelAdmin;
        public static string hesloPrihlasenehoUzivatele;
        public static Guid IDPrihlasenehoUzivatele;
        public static DateTime datumPoslednihoPrihlaseniUzivatele;
        public static DateTime datumNynejsihoPrihlaseniUzivatele;

        private void NactiSeznamUzivatelu()
        {
            if (File.Exists(jmenoSouboruUzivatele))
            {
                seznamUzivatelu = File.ReadAllLines(jmenoSouboruUzivatele);
            }
            else
            {
                MessageBox.Show("Soubor " + jmenoSouboruUzivatele + " nebyl nalezen");
            }
        }

        private void NactiSeznamAutomobilu()
        {
            if (File.Exists(jmenoSouboruAuta))
            {
                seznamAut = File.ReadAllLines(jmenoSouboruAuta);
            }
            else
            {
                MessageBox.Show("Soubor " + jmenoSouboruAuta + " nebyl nalezen");
            }
        }

        private void NactiSeznamServisnichUkonu()
        {
            if (File.Exists(jmenoSouboruServisniUkony))
            {
                seznamServisnichUkonu = File.ReadAllLines(jmenoSouboruServisniUkony);
            }
            else
            {
                MessageBox.Show("Soubor " + jmenoSouboruServisniUkony + " nebyl nalezen");
            }
        }

        private void NactiSeznamRezervaci()
        {
            if (File.Exists(jmenoSouboruRezervace))
            {
                seznamRezervaci = File.ReadAllLines(jmenoSouboruRezervace);
            }
            else
            {
                MessageBox.Show("Soubor " + jmenoSouboruRezervace + " nebyl nalezen");
            }
        }

        private void buttonPrihlasitSe_Click(object sender, EventArgs e)
        {
            NactiSeznamUzivatelu();
            NactiSeznamAutomobilu();
            NactiSeznamServisnichUkonu();
            NactiSeznamRezervaci();



            string jmeno = textBoxJmeno.Text;
            string prijmeni = textBoxPrijmeni.Text;
            string heslo = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(textBoxHeslo.Text));

            bool jmenoSpravne = false;
            bool prijmeniSpravne = false;
            bool hesloSpravne = false;
            

            if (jmeno == "")
            {
                labelPrazdneJmeno.Visible = true;
            }
            else
            {
                labelPrazdneJmeno.Visible = false;
            }

            if (prijmeni == "")
            {
                labelPrazdnePrijmeni.Visible = true;
            }
            else
            {
                labelPrazdnePrijmeni.Visible = false;
            }

            for (int i = 0; i < seznamUzivatelu.Length; i++)
            {
                char separator = '|';
                string[] oddelene = seznamUzivatelu[i].Split(separator);
                string aktualniJmeno = oddelene[0];
                string aktualniPrijmeni = oddelene[1];
                bool jeAdmin = bool.Parse(oddelene[2]);
                string aktualniHeslo = oddelene[3];
                

                if(aktualniJmeno == jmeno)
                {
                    jmenoSpravne = true;

                    if (aktualniPrijmeni == prijmeni)
                    {
                        prijmeniSpravne = true;

                        if (aktualniHeslo == heslo)
                        {
                            hesloSpravne = true;

                            jmenoPrihlasenehoUzivatele = aktualniJmeno;
                            prijmeniPrihlasenehoUzivatele = aktualniPrijmeni;
                            jePrihlasenyUzivatelAdmin = jeAdmin;
                            hesloPrihlasenehoUzivatele = aktualniHeslo;
                            IDPrihlasenehoUzivatele = Guid.Parse(oddelene[4]);
                            if (oddelene[5] != "none")  //Uživatelovo první přihlášení
                            {
                                datumPoslednihoPrihlaseniUzivatele = DateTime.Parse(oddelene[5]);
                            }
                            else
                            {
                                datumPoslednihoPrihlaseniUzivatele = new DateTime(1, 1, 1, 1, 1, 1);
                            }

                            datumNynejsihoPrihlaseniUzivatele = DateTime.Now;

                            if (bool.TryParse(oddelene[oddelene.Length - 1], out zmenitHeslo))
                            {
                                //U tohoto uživatele je vynucena změna hesla
                            }
                        }
                    }
                }

                if (jmenoSpravne == true && prijmeniSpravne == true && hesloSpravne == true)
                {
                    //Správně přihlášen
                    labelSpatnePrihlaseni.Visible = false;

                    if (jeAdmin)
                    {
                        //Otevře formAdmin
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.Show();
                    }
                    else
                    {
                        //Otevře formUser
                        FormUser formUser = new FormUser();
                        formUser.Show();
                    }

                    textBoxJmeno.ResetText();
                    textBoxPrijmeni.ResetText();
                    textBoxHeslo.ResetText();

                    break;
                }
                else
                {
                    labelSpatnePrihlaseni.Visible = true;
                }
            }
        }
    }
}
