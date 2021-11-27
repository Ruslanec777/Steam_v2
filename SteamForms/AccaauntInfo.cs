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
    public partial class AccountInfo : Form, ImenuForms
    {

        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }

        public AccountInfo(AccountProvider accountProvider, Form parentForm)
        {
            InitializeComponent();
            AccountProvider = accountProvider;
            LocalParentForm = parentForm;

            infNameLab.Text = CurrentAccaunt.Name;
            infPanronimicLab.Text = CurrentAccaunt.Patronymic;
            infSurnameLab.Text = CurrentAccaunt.Surname;
            infNicNameLab.Text = CurrentAccaunt.NicName;
            infSexLab.Text = CurrentAccaunt.Sex.ToString();
            infAgeLab.Text = CurrentAccaunt.Age.ToString();
            infLoginLab.Text = CurrentAccaunt.Login;
            infPassvordLab.Text = CurrentAccaunt.Password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccauntEdit(AccountProvider, this).Show();
        }

        private void AccountInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            LocalParentForm.Show();
        }
    }
}
