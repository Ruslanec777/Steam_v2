using App.Model;
using SteamForms.Model;
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
    public partial class AuthorizationForm : Form,ImenuForms
    {
        public MainMenuForm MainMenuForm{ get; set; }
        public AccountProvider AccountProviderS { get; set; }
        public Form LocalParentForm { get; set ; }

        public AuthorizationForm(AccountProvider accountProvider ,MainMenuForm mainMenuForm)
        {
            InitializeComponent();
            AccountProviderS = accountProvider;
            MainMenuForm = mainMenuForm;
        }

        private void LoginingBtn_Click(object sender, EventArgs e)
        {
            Account tempAccount = AccountProviderS.TryLogining(LoginTB.Text, PasswordTB.Text);
            if (tempAccount!=null)
            {
                SteamClient.CurrentAccaunt = tempAccount;
                // запускаем форму MainMenu
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
            RegistrationForm regForm = new RegistrationForm(AccountProviderS ,MainMenuForm);
            regForm.Show();

            this.Close();
        }
    }
}
