using App.Model;
using Steam_v2.Enums;
using SteamForms.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamForms
{
    public partial class RegistrationForm : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }

        public MainMenuForm MainMenuForm { get; set; }

        public Form LocalParentForm { get; set; }

        public List<Control> NotValidList { get; set; }

        public bool IsValidLogin { get; set; }

        public RegistrationFormDTO RegFormDTO
        {
            get
            {
                Sex sex = (regSexComboBox.Text == "Мужской") ? Sex.Man : Sex.Woman;

                int age;
                int.TryParse(RegAgeTB.Text, out age);

                RegistrationFormDTO accountData = new RegistrationFormDTO(RegNameTB.Text, RegPatronymicTB.Text, RegSurnameTB.Text, RegNicNameTB.Text,
                    sex, age, RegLoginTB.Text, RegPasswordTB.Text ,String.Empty);

                return accountData;
            }
        }

        public RegistrationForm(AccountProvider accountProvider)
        {
            InitializeComponent();

            AccountProvider = accountProvider;

            regSexComboBox.Items.Add("Мужской");
            regSexComboBox.Items.Add("Женский");
        }

        public RegistrationForm(AccountProvider accountProvider, MainMenuForm mainMenuForm) : this(accountProvider)
        {
            MainMenuForm = mainMenuForm;
        }

        private void RegBackBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm.Show();

            this.Close();
        }

        private void regTryRegistrationBtn_Click(object sender, EventArgs e)
        {
            //_isRegDataValid = true;
            NotValidList = new List<Control>(0);

            foreach (Control c in this.Controls)
            {
                if (c.Name== "LoginPictureBox1")
                {
                    continue;
                }

                if (c.Text.Length == 0)
                {
                    NotValidList.Add(c);
                    c.BackColor = Color.Red;
                    continue;
                }
                else
                {
                    c.BackColor = Color.White;
                }

                switch (c.Name)
                {
                    case "RegAgeTB":
                        int age;

                        if ((int.TryParse(RegAgeTB.Text, out age) && age > 6 && age < 130) == false)
                        {
                            RegAgeTB.BackColor = Color.Red;
                            NotValidList.Add(c);
                        }
                        else
                        {
                            RegAgeTB.BackColor = Color.White;
                        }
                        break;
                    default:
                        break;
                }
            }

            if (NotValidList.Count > 0)
            {
                MessageBox.Show("Введите корректные значения");
                return;
            }


            Account tempAccount = AccountProvider.TryRegistrationAccaunt(RegFormDTO);
            if (tempAccount != null)
            {
                SteamClient.CurrentAccaunt = tempAccount;
                MainMenuForm.Show();

                this.Close();
            }
        }

        private void RegLoginTB_TextChanged(object sender, EventArgs e)
        {
            if (AccountProvider.FindAccountToLigin(RegLoginTB.Text) != null)
            {
                LoginPictureBox1.Image = global::SteamForms.Properties.Resources._false;
                IsValidLogin = false;
            }
            else
            {
                regTryRegistrationBtn.Enabled = true;
                RegLoginTB.BackColor = Color.White;
                LoginPictureBox1.Image = global::SteamForms.Properties.Resources._true;
                IsValidLogin = true;
            }
        }


    }
}
