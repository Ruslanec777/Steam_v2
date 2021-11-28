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
using static App.Model.SteamClient;

namespace SteamForms
{
    public partial class BalancForm : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }
        public bool IsClosingThisForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BalancForm(AccountProvider accountProvider, Form parentForm)
        {
            InitializeComponent();

            AccountProvider = accountProvider;
            LocalParentForm = parentForm;

            balancMenuIdNicNamelabel.Text = $"ID: {CurrentAccaunt.Id} , {CurrentAccaunt.NicName}";

            balancMenuBalancLabel.Text = $"{CurrentAccaunt.Balance}";
            balancMenuRemoveManeyBtn.Enabled = false;
            balancMenuAddManeyBtn.Enabled = false;
        }

        private void BalancForm_Load(object sender, EventArgs e)
        {
            LocalParentForm.Hide();
        }

        private void BalancForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LocalParentForm.Show();
        }

        private void balancMenuManeyForAddTB_TextChanged(object sender, EventArgs e)
        {
            decimal tempVar;

            if (!decimal.TryParse(balancMenuMAneyForAddTB.Text, out tempVar) || tempVar < 0)
            {
                balancMenuAddManeyBtn.Enabled = false;
            }
            else
            {
                balancMenuAddManeyBtn.Enabled = true;
            }
        }

        private void balancMenuAddManeyBtn_Click_1(object sender, EventArgs e)
        {
            decimal maneyForAction;

            if (decimal.TryParse(balancMenuMAneyForAddTB.Text, out maneyForAction) && maneyForAction > 0)
            {
                if (!CurrentAccaunt.AddMoney(maneyForAction))
                {
                    MessageBox.Show("Не удалось добавить средства на счет");
                }

                balancMenuBalancLabel.Text = CurrentAccaunt.Balance.ToString();

                balancMenuMAneyForAddTB.Text = "";
            }
        }

        private void balancMenuRemoveManeyBtn_Click(object sender, EventArgs e)
        {
            decimal maneyForAction;

            if (decimal.TryParse(balancMenuMAneyForRemoveTB.Text, out maneyForAction) && maneyForAction > 0)
            {
                MessageBox.Show($"Выведено {CurrentAccaunt.RemoveMoney(maneyForAction).ToString()}");

                balancMenuBalancLabel.Text = CurrentAccaunt.Balance.ToString();

                balancMenuMAneyForRemoveTB.Text = "";
            }
        }

        private void balancMenuMAneyForRemoveTB_TextChanged(object sender, EventArgs e)
        {
            decimal tempVar;

            if (!decimal.TryParse(balancMenuMAneyForRemoveTB.Text, out tempVar) || tempVar < 0)
            {
                balancMenuRemoveManeyBtn.Enabled = false;
            }
            else
            {
                balancMenuRemoveManeyBtn.Enabled = true;
            }
        }
    }
}
