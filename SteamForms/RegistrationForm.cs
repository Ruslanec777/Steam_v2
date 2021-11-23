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
        public AccountProvider AccountProviderS { get; set; }

        public MainMenuForm MainMenuForm { get; set; }

        public Form LocalParentForm { get ; set ; }



        public RegistrationFormData RegFormData
        {
            get
            {
                Sex sex = (regSexComboBox.Text == "Мужской") ? Sex.Man : Sex.Woman;

                int age;
                int.TryParse(RegAgeTB.Text, out age);

                RegistrationFormData accountData = new RegistrationFormData(RegNameTB.Text, RegPatronymicTB.Text, RegSurnameTB.Text, RegNicNameTB.Text,
                    sex, age, RegLoginTB.Text, RegPasswordTB.Text);

                return accountData;
            }
        }


        public RegistrationForm(AccountProvider accountProvider)
        {
            InitializeComponent();

            AccountProviderS = accountProvider;

            regSexComboBox.Items.Add("Мужской");
            regSexComboBox.Items.Add("Женский");
        }

        public RegistrationForm(AccountProvider accountProvider, MainMenuForm mainMenuForm) : this(accountProvider)
        {
            MainMenuForm = mainMenuForm;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void RegBackBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm.Show();

            this.Close();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            //AuthorizationForm.Show();
        }

        private void regTryRegistrationBtn_Click(object sender, EventArgs e)
        {
            Account tempAccount = AccountProviderS.TryRegistrationAccaunt(RegFormData);
            if (tempAccount != null)
            {
                SteamClient.CurrentAccaunt = tempAccount;
                MainMenuForm.Show();

                this.Close();
            }
        }
    }
}
