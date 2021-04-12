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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private string jmenoSouboru = "users.txt";
        private string jmenoSouboruRezervace = "reservation.txt";

        private void buttonSpravaUzivatelu_Click(object sender, EventArgs e)
        {
            FormAdminSetUser formAdminSetUser = new FormAdminSetUser();
            formAdminSetUser.Show();
        }

        private void buttonSpravaAutomobilu_Click(object sender, EventArgs e)
        {
            FormAdminSetCar formAdminSetCar = new FormAdminSetCar();
            formAdminSetCar.Show();
        }

        private void buttonZmenitHeslo_Click(object sender, EventArgs e)
        {
            FormUserChangePassword formUserChangePassword = new FormUserChangePassword();
            formUserChangePassword.ShowDialog();
        }

        private void buttonOdhlasitSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Vložím nynější datum do data posledního přihlášení, aby mohl být při příštím přihlášení vypsán
            FormLogin.datumPoslednihoPrihlaseniUzivatele = FormLogin.datumNynejsihoPrihlaseniUzivatele;

            //Provedení zmíněných změn v souboru
            string[] novySeznam = new string[FormLogin.seznamUzivatelu.Length];
            for (int i = 0; i < FormLogin.seznamUzivatelu.Length; i++)
            {
                char separator = '|';
                string[] oddelene = FormLogin.seznamUzivatelu[i].Split(separator);

                if (FormLogin.IDPrihlasenehoUzivatele.ToString() == oddelene[4])
                {
                    novySeznam[i] = oddelene[0] + "|" + oddelene[1] + "|" + oddelene[2] + "|" + oddelene[3] + "|" + oddelene[4] + "|" + FormLogin.datumPoslednihoPrihlaseniUzivatele;
                }
                else
                {
                    novySeznam[i] = FormLogin.seznamUzivatelu[i];
                }
            }
            FormLogin.seznamUzivatelu = novySeznam;
            File.WriteAllLines(jmenoSouboru, FormLogin.seznamUzivatelu);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            //V případě, že je vyžádána změna hesla
            if (FormLogin.zmenitHeslo == true)
            {
                FormUserChangePassword formUserChangePassword = new FormUserChangePassword();
                formUserChangePassword.ShowDialog();
            }

            //Načtení a vypsání informace o posledním přihlášení
            if (FormLogin.datumPoslednihoPrihlaseniUzivatele == new DateTime(1, 1, 1, 1, 1, 1))
            {
                labelPosledniPrihlaseni.Text += "toto je Vaše první přihlášení";
            }
            else
            {
                labelPosledniPrihlaseni.Text += FormLogin.datumPoslednihoPrihlaseniUzivatele;
            }

            //Načtení potřebných informací do listBoxů
            AktualizujSeznamyRezervaci();
        }


        private void AktualizujSeznamyRezervaci()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            if (File.Exists(jmenoSouboruRezervace))
            {
                for (int i = 0; i < FormLogin.seznamRezervaci.Length; i++)
                {
                    char separator = '|';
                    string[] oddelene = FormLogin.seznamRezervaci[i].Split(separator);

                    string IdAktualnihoUzivatele = oddelene[0];
                    string IdAktualnihoAuta = oddelene[1];

                    string jmenoAktualnihoUzivatele = null;
                    string prijmeniAktualnihoUzivatele = null;

                    for (int j = 0; j < FormLogin.seznamAut.Length; j++)
                    {
                        string[] oddelene2 = FormLogin.seznamAut[j].Split(separator);

                        for (int k = 0; k < FormLogin.seznamUzivatelu.Length; k++)
                        {
                            string[] oddelene3 = FormLogin.seznamUzivatelu[k].Split(separator);

                            if (oddelene3[4] == IdAktualnihoUzivatele)
                            {
                                jmenoAktualnihoUzivatele = oddelene3[0];
                                prijmeniAktualnihoUzivatele = oddelene3[1];
                                break;
                            }
                        }


                        if (oddelene2[4] == IdAktualnihoAuta)
                        {
                            //do listBox1:  znaška model - jméno příjmení - od datum čas do datum čas
                            //Přidání informací do listBoxu1
                            string radek = oddelene2[0] + " " + oddelene2[1] + " - " + jmenoAktualnihoUzivatele + " " + prijmeniAktualnihoUzivatele + " - od " + oddelene[2] + " do " + oddelene[3];
                            listBox1.Items.Add(radek);

                            //do listBox2:  jméno příjmení - zmačka model typ spotřeba - od datum čas do datum čas
                            //Přidání informací do listBoxu2
                            radek = jmenoAktualnihoUzivatele + " " + prijmeniAktualnihoUzivatele + " - " + oddelene2[0] + " " + oddelene2[1] + " " + oddelene2[2] + " " + oddelene2[3] + " - od " + oddelene[2] + " do " + oddelene[3];
                            listBox2.Items.Add(radek);
                            break;
                        }
                    }
                }
            }
            else
            {
                listBox1.Items.Add("Zatím nebyli udělány žádné rezervace");
                listBox2.Items.Add("Zatím nebyli udělány žádné rezervace");
            }
        }


        private void buttonAktualizovatSeznamyRezervaci_Click(object sender, EventArgs e)
        {
            AktualizujSeznamyRezervaci();
        }
    }
}
