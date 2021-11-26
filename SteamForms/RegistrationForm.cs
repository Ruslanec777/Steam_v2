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

        private bool _isRegDataValid = false;



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

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            //AuthorizationForm.Show();
        }

        private void regTryRegistrationBtn_Click(object sender, EventArgs e)
        {
            if (_isRegDataValid == false)
            {
                MessageBox.Show("Введите корректные значения");
                return;
            }
            Account tempAccount = AccountProvider.TryRegistrationAccaunt(RegFormData);
            if (tempAccount != null)
            {
                SteamClient.CurrentAccaunt = tempAccount;
                MainMenuForm.Show();

                this.Close();
            }
        }

        private void regSexComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegAgeTB_TextChanged(object sender, EventArgs e)
        {
            int age;

            if ((int.TryParse(RegAgeTB.Text, out age) && age > 6 && age < 130) == false)
            {
                RegAgeTB.BackColor = Color.Red;
                _isRegDataValid = false;
            }
            else
            {
                _isRegDataValid = true;
                RegAgeTB.BackColor = Color.White;
            }
        }
    }
}
