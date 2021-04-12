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
    public partial class FormAdminSetUser : Form
    {
        public FormAdminSetUser()
        {
            InitializeComponent();
            AktualizujSeznamUzivatelu();
        }

        private string jmenoSouboru = "users.txt";


        private void AktualizujSeznamUzivatelu()
        {
            for (int i = 0; i < FormLogin.seznamUzivatelu.Length; i++)
            {
                listBox1.Items.Add(FormLogin.seznamUzivatelu[i]);
            }
        }

        private void buttonNovyUzivatel_Click(object sender, EventArgs e)
        {
            FormAdminSetUserNewUser formAdminSetUserNewUser = new FormAdminSetUserNewUser();
            formAdminSetUserNewUser.ShowDialog();
        }

        private void buttonVynutitZmenuHesla_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                char separator = '|';
                string[] oddelene = listBox1.SelectedItem.ToString().Split(separator);

                bool jizVyzadano;
                if (bool.TryParse(oddelene[oddelene.Length - 1], out jizVyzadano))
                {
                    MessageBox.Show("U tohoto uživatele byla již vyžádána změna hesla");
                }
                else
                {
                    int index = listBox1.SelectedIndex;
                    string uzivatel = listBox1.SelectedItem.ToString() + "|" + true;
                    listBox1.Items.RemoveAt(index);
                    listBox1.Items.Insert(index, uzivatel);

                    string[] novySeznam = new string[listBox1.Items.Count];

                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        listBox1.SelectedIndex = i;
                        novySeznam[i] = listBox1.SelectedItem.ToString();
                    }
                    FormLogin.seznamUzivatelu = novySeznam;
                    File.WriteAllLines(jmenoSouboru, FormLogin.seznamUzivatelu);
                }
            }
        }

        private void buttonAktualizovatSeznamUzivatelu_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AktualizujSeznamUzivatelu();
        }

        public static Guid IDoznacenehoUzivatele;

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // Zde se uloží ID uživatele, na kterého bylo dvoj-kliknuto
            char separator = '|';
            string[] oddelene = listBox1.SelectedItem.ToString().Split(separator);

            IDoznacenehoUzivatele = Guid.Parse(oddelene[4]);

            // Otevře se FormUserAddReservation, kde může admin dělat rezervace jménem daného uživatele (za pomoci jeho ID)
            FormUserAddReservation formUserAddReservation = new FormUserAddReservation();
            formUserAddReservation.ShowDialog();
        }

        private void buttonZrusitUzivatele_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tato akce je nevratná!");

            string[] novySeznam = new string[FormLogin.seznamUzivatelu.Length];
            for (int i = 0; i < FormLogin.seznamUzivatelu.Length; i++)
            {
                char separator = '|';
                string[] oddelene = FormLogin.seznamUzivatelu[i].Split(separator);

                string[] oddelene2 = listBox1.SelectedItem.ToString().Split(separator);

                if (oddelene[4] == oddelene2[4])
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
        }
    }
}
