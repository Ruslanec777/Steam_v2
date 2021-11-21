using App.Model;
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
    public partial class RegistrationForm : Form
    {
        private AuthorizationForm _authorizationForm;

        private AccountProvider _accountProvider;


        public AccountData AccountData
        {
            get {
                AccountData accountData = new AccountData(RegNameTB.Text,RegPatronymicTB,RegSurnameTB,RegNicNameTB.Text,
                    );

                
                return accountData; }
            
        }


        public RegistrationForm(AccountProvider accountProvider )
        {
            InitializeComponent();

           _accountProvider=accountProvider;
        }

        public RegistrationForm(AccountProvider accountProvider, AuthorizationForm authorizationForm) : this(accountProvider)
        {
            _authorizationForm = authorizationForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void RegBackBtn_Click(object sender, EventArgs e)
        {
            _authorizationForm.Show();

            this.Close();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            _authorizationForm.Show();
        }

        private void RegRegistrationBtn_Click(object sender, EventArgs e)
        {
            AccountData accountData = new AccountData();
            _accountProvider.TryRegistrationAccaunt();
        }
    }
}
