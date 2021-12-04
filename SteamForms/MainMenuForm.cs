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
    public partial class MainMenuForm : Form
    {
        public AccountProvider AccountProviderS { get; set; } = SteamClient.accauntProvider;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Shown(object sender, EventArgs e)
        {

        }

        private void mainAccInfoBtn_Click(object sender, EventArgs e)
        {
            new AccountInfo(AccountProviderS, this).Show();
            this.Hide();
        }

        private void mainBalanceBtn_Click(object sender, EventArgs e)
        {
            new BalancForm(AccountProviderS, this).Show();
        }

        private void mainMenuQuitFromAccBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SteamClient.CurrentAccaunt.IsAuthorized = false;
            SteamClient.CurrentAccaunt = null;

            new AuthorizationForm(AccountProviderS, this).Show();
        }

        private void mainMenuGameShopBtn_Click(object sender, EventArgs e)
        {
            Form gameShopForm = new GameShopForm(AccountProviderS, this);
            //gameShopForm.SetDesktopLocation=this.StartPosition
            //gameShopForm.SetDesktopLocation() = this.Location();
            gameShopForm.Show();
        }

        private void MainMenuGameAreaBtn_Click(object sender, EventArgs e)
        {
            new GameImajes().Show();
        }

        private void MainMenuForm_VisibleChanged(object sender, EventArgs e)
        {
            bool b = this.Visible;
            b = this.Visible;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            bool b = this.Visible;
        }

        private void MainMenuForm_Paint(object sender, PaintEventArgs e)
        {
            bool b = this.Visible;
            if (SteamClient.CurrentAccaunt == null && this.Visible)
            {
                this.Hide();
                new AuthorizationForm(AccountProviderS, this).Show();
            }
        }
    }
}
