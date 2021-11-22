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
    public partial class MainMenuForm : Form
    {
        public AccountProvider AccountProviderS { get; set; } = SteamClient.accauntProvider;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {

        }


        private void MainMenuForm_Shown(object sender, EventArgs e)
        {
            if (SteamClient.CurrentAccaunt == null)
            {
                this.Hide();
                new AuthorizationForm(AccountProviderS ,this).Show();
            }

        }

        private void mainAccInfoBtn_Click(object sender, EventArgs e)
        {
            new AccauntInfoForm(AccountProviderS, this).Show();
        }
    }
}
