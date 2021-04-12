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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private string jmenoSouboru = "users.txt";
        private string jmenoSouboruRezervace = "reservation.txt";

        private void FormUser_Load(object sender, EventArgs e)
        {
            //V případě, že je vyžádána změna hesla
            if(FormLogin.zmenitHeslo == true)
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

            //Načtení aktuálních rezervací, pokud nějaké jsou
            AktualizujSeznamRezervaci();

            //V případě, že uživatel nemá doposud žádnou rezervaci nebo neexistuje reservation.txt - listBox1.Text ...


        }

        private void AktualizujSeznamRezervaci()
        {
            listBox1.Items.Clear();

            bool maUzivatelRezervaci = false;

            if (File.Exists(jmenoSouboruRezervace))
            {
                for (int i = 0; i < FormLogin.seznamRezervaci.Length; i++)
                {
                    char separator = '|';
                    string[] oddelene = FormLogin.seznamRezervaci[i].Split(separator);

                    if (FormLogin.IDPrihlasenehoUzivatele.ToString() == oddelene[0])
                    {
                        maUzivatelRezervaci = true;
                        for (int j = 0; j < FormLogin.seznamAut.Length; j++)
                        {
                            string[] oddelene2 = FormLogin.seznamAut[j].Split(separator);


                            if (oddelene2[4] == oddelene[1])
                            {
                                //Přidání informací do listBoxu1 o rezervovaném automobilu
                                string radek = oddelene2[0] + " | " + oddelene2[1] + " | " + oddelene2[2] + " | " + oddelene2[3] + " | od " + oddelene[2] + " do " + oddelene[3];
                                listBox1.Items.Add(radek);
                                break;
                            }
                        }
                    }
                }
            }

            if(maUzivatelRezervaci == false)
            {
                listBox1.Items.Add("Zatím nemáte žádnou rezervaci. Pro rezervování auta klikněte na tlačítko \'Zadat rezervaci\' nebo zkuste aktualizovat seznam rezervací");
            }
        }

        private void buttonZmenitHeslo_Click(object sender, EventArgs e)
        {
            FormUserChangePassword formUserChangePassword = new FormUserChangePassword();
            formUserChangePassword.ShowDialog();
        }

        private void buttonOdhlásitSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZadatRezervaci_Click(object sender, EventArgs e)
        {
            FormUserAddReservation formUserAddReservation = new FormUserAddReservation();
            formUserAddReservation.ShowDialog();
        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
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

        private void buttonAktualizovatSeznamRezervaci_Click(object sender, EventArgs e)
        {
            AktualizujSeznamRezervaci();
        }

        private void buttonZrusitUcet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tato akce je nevratná!");

            string[] novySeznam = new string[FormLogin.seznamUzivatelu.Length];
            for (int i = 0; i < FormLogin.seznamUzivatelu.Length; i++)
            {
                char separator = '|';
                string[] oddelene = FormLogin.seznamUzivatelu[i].Split(separator);

                if (oddelene[4] == FormLogin.IDPrihlasenehoUzivatele.ToString())
                {
                    Guid cisloUzivatele = Guid.NewGuid();
                    novySeznam[i] = "User_" + cisloUzivatele + "|Surname_" + cisloUzivatele + "|" + oddelene[2] + "|" + oddelene[3] + "|" + oddelene[4] + "|" + oddelene[5];
                }
                else
                {
                    novySeznam[i] = FormLogin.seznamUzivatelu[i];
                }
            }

            FormLogin.seznamUzivatelu = novySeznam;     //Aktualizuji seznam uživatelů
            File.WriteAllLines(jmenoSouboru, FormLogin.seznamUzivatelu); //Zapisuji do souboru

            Close();
        }

        private void buttonZrusitRezervaci_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                string[] novySeznam = new string[FormLogin.seznamRezervaci.Length - 1];

                int posun = 0;
                for (int i = 0; i < FormLogin.seznamRezervaci.Length; i++)
                {
                    char separator = '|';
                    string[] oddelene = FormLogin.seznamRezervaci[i].Split(separator);
                    char separator1 = ' ';
                    string[] oddelene1 = oddelene[2].Split(separator1); //0 datum; 1 čas začátku rezervace
                    char separator1_1 = ' ';
                    string[] oddelene1_1 = oddelene[3].Split(separator1_1); //0 datum; 1 čas konce rezervace
                    
                    char separator2 = '|';
                    string[] oddelene2 = listBox1.SelectedItem.ToString().Split(separator2);
                    char separator3 = ' ';
                    string[] oddelene3 = oddelene2[4].Split(separator3); //2 datum; 3 čas začátku rezervace - 5 datum; 6 čas konce rezervace


                    if (oddelene1[0] == oddelene3[2] && oddelene1[1] == oddelene3[3] && oddelene1_1[0] == oddelene3[5] && oddelene1_1[1] == oddelene3[6])
                    {
                        posun = 1;
                    }
                    else
                    {
                        novySeznam[i - posun] = FormLogin.seznamRezervaci[i];
                    }
                }

                FormLogin.seznamRezervaci = novySeznam;
                File.WriteAllLines(jmenoSouboruRezervace, FormLogin.seznamRezervaci);
                AktualizujSeznamRezervaci();
            }
        }
    }
}
