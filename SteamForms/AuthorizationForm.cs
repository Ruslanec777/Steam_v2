using App.Model;
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
    public partial class AuthorizationForm : Form, ImenuForms
    {
        public MainMenuForm MainMenuForm { get; set; }
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }

        public bool IsClosingThisForm { get; set; } 

        public AuthorizationForm(AccountProvider accountProvider, MainMenuForm mainMenuForm)
        {
            InitializeComponent();
            AccountProvider = accountProvider;
            MainMenuForm = mainMenuForm;
        }

        private void LoginingBtn_Click(object sender, EventArgs e)
        {
            Account tempAccount = AccountProvider.TryLogining(LoginTB.Text, PasswordTB.Text);
            if (tempAccount != null)
            {
                SteamClient.CurrentAccaunt = tempAccount;
                MainMenuForm.Show();
                this.Close();
            }
            else
            {
                LoginTB.BackColor = Color.Red;
                MessageBox.Show("Неверный логин или пароль");
                LoginTB.BackColor = Color.White;
            }
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm(AccountProvider, MainMenuForm);
            regForm.Show();
            IsClosingThisForm = true;
            this.Close();
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsClosingThisForm)
            {
                MainMenuForm.Close();
            }
        }
    }
}
