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
    public partial class FormUserAddReservation : Form
    {
        public FormUserAddReservation()
        {
            InitializeComponent();
        }

        private string jmenoSouboruAuta = "cars.txt";
        private string jmenoSouboruRezervace = "reservation.txt";

        private void ZapisDoSouboruRezervace(Guid IDuzivatele, Guid IDautomobilu, DateTime datumACasKonceRezervace)
        {
            DateTime datumACasZacatkuRezervace = DateTime.Now;
            if (File.Exists(jmenoSouboruRezervace))
            {
                string[] novySeznam = new string[FormLogin.seznamRezervaci.Length + 1];

                for (int i = 0; i < FormLogin.seznamRezervaci.Length; i++)
                {
                    novySeznam[i] = FormLogin.seznamRezervaci[i];
                }
                novySeznam[novySeznam.Length - 1] = IDuzivatele + "|" + IDautomobilu + "|" + datumACasZacatkuRezervace + "|" + datumACasKonceRezervace;
                FormLogin.seznamRezervaci = novySeznam;
                File.WriteAllLines(jmenoSouboruRezervace, FormLogin.seznamRezervaci);
            }
            else
            {
                string[] novySeznam = new string[1];
                novySeznam[0] = IDuzivatele + "|" + IDautomobilu + "|" + datumACasZacatkuRezervace + "|" + datumACasKonceRezervace;
                FormLogin.seznamRezervaci = novySeznam;
                File.WriteAllLines(jmenoSouboruRezervace, FormLogin.seznamRezervaci);
            }
        }

        private void buttonRezervovat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Guid IDoznacenehoAuta = Guid.Parse(poleIDzapsanychAutomobilu[listBox1.SelectedIndex]);

                string[] novySeznam = new string[FormLogin.seznamAut.Length];
                for (int i = 0; i < FormLogin.seznamAut.Length; i++)
                {
                    char separator = '|';
                    string[] oddelene = FormLogin.seznamAut[i].Split(separator);

                    
                    if (oddelene[4] == IDoznacenehoAuta.ToString()) //Rezervovaný automobil nastavím na nedostupný
                    {
                        novySeznam[i] = oddelene[0] + "|" + oddelene[1] + "|" + oddelene[2] + "|" + oddelene[3] + "|" + oddelene[4] + "|" + false;
                        MessageBox.Show("Rezervace automobilu " + oddelene[0] + " " + oddelene[1] + " proběhla úspěšně");
                    }
                    else
                    {
                        novySeznam[i] = FormLogin.seznamAut[i];
                    }
                }
                
                FormLogin.seznamAut = novySeznam;
                File.WriteAllLines(jmenoSouboruAuta, FormLogin.seznamAut);
                listBox1.Items.Clear();
                AktualizujListBox1();



                DateTime datumACasKonceRezervace = new DateTime(dateTimePickerRezervovatDo.Value.Year, dateTimePickerRezervovatDo.Value.Month, dateTimePickerRezervovatDo.Value.Day, (int)numericUpDownCasHodiny.Value, (int)numericUpDownCasMinuty.Value, (int)numericUpDownCasVteriny.Value);

                //Je třeba zkontrolovat zda dělá rezervaci admin (přidávání uloženého ID z FormAdminSetUser) či uživatel (přidávání ID přihlášeného uživatele)
                if (FormLogin.jePrihlasenyUzivatelAdmin == true)
                {
                    ZapisDoSouboruRezervace(FormAdminSetUser.IDoznacenehoUzivatele, IDoznacenehoAuta, datumACasKonceRezervace);
                }
                else
                {
                    ZapisDoSouboruRezervace(FormLogin.IDPrihlasenehoUzivatele, IDoznacenehoAuta, datumACasKonceRezervace);
                }
            }
        }

        private string[] poleIDzapsanychAutomobilu;

        private void AktualizujListBox1()
        {
            int pocetZapsanychAut = 0;
            for (int i = 0; i < FormLogin.seznamAut.Length; i++)
            {
                char separator = '|';
                string[] oddelene = FormLogin.seznamAut[i].Split(separator);

                string radek;
                if (bool.Parse(oddelene[5]) == true) //Když je automobil dostupný
                {
                    radek = oddelene[0] + " | " + oddelene[1] + " | " + oddelene[2] + " | " + oddelene[3];
                    listBox1.Items.Add(radek);
                    pocetZapsanychAut++;
                }
            }

            
            string[] poleID = new string[pocetZapsanychAut];
            pocetZapsanychAut = 0;
            for(int j = 0; j < FormLogin.seznamAut.Length; j++)
            {
                char separator = '|';
                string[] oddelene = FormLogin.seznamAut[j].Split(separator);

                if (bool.Parse(oddelene[5]) == true) //Když je automobil dostupný
                {
                    poleID[pocetZapsanychAut] = oddelene[4];
                    pocetZapsanychAut++;
                }
            }
            poleIDzapsanychAutomobilu = poleID;
        }

        private void FormUserAddReservation_Load(object sender, EventArgs e)
        {
            if (File.Exists(jmenoSouboruAuta))
            {
                AktualizujListBox1();
            }
            else
            {
                MessageBox.Show("Soubor " + jmenoSouboruAuta + " nebyl nalezen");
            }
        }

        private void buttonZavrit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
