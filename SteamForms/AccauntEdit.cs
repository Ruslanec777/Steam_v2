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
using static App.Model.SteamClient;


namespace SteamForms
{
    public partial class AccauntEdit : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public  Form LocalParentForm { get; set; }

        public AccauntEdit(AccountProvider accountProvider, Form parent)
        {
            InitializeComponent();

            AccountProvider = accountProvider;
            LocalParentForm = parent;
            Form tempForm = ParentForm;

            editIdTB.Text = CurrentAccaunt.Id.ToString();
            editNameTB.Text = CurrentAccaunt.Name;
            editPatronymicTB.Text = CurrentAccaunt.Patronymic;
            editSurnameTB.Text = CurrentAccaunt.Surname;
            editNicNameTb.Text = CurrentAccaunt.NicName;
            editSexCBox.Text = (CurrentAccaunt.Sex == Sex.Man) ? "Мужской" : "Женский";
            editAgeTB.Text = CurrentAccaunt.Age.ToString();
            editLoginTB.Text = CurrentAccaunt.Login;
            editPasswordTB.Text = CurrentAccaunt.Password;
            editNameTB.Text = CurrentAccaunt.Name;
        }

        private void AccauntInfoForm_Load(object sender, EventArgs e)
        {
            LocalParentForm.Hide();
        }

        private void AccauntInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            LocalParentForm.Show();
        }

        private void accInfBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
