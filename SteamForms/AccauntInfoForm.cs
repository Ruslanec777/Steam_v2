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
    public partial class AccauntInfoForm : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public  Form LocalParentForm { get; set; }

        public AccauntInfoForm(AccountProvider accountProvider, Form parent)
        {
            InitializeComponent();

            AccountProvider = accountProvider;
            LocalParentForm = parent;
            Form tempForm = ParentForm;

            regIdTB.Text = CurrentAccaunt.Id.ToString();
            regNameTB.Text = CurrentAccaunt.Name;
            regPatronymicTB.Text = CurrentAccaunt.Patronymic;
            RegSurnameTB.Text = CurrentAccaunt.Surname;
            RegNicNameTB.Text = CurrentAccaunt.NicName;
            regSexComboBox.Text = (CurrentAccaunt.Sex == Sex.Man) ? "Мужской" : "Женский";
            RegAgeTB.Text = CurrentAccaunt.Age.ToString();
            RegLoginTB.Text = CurrentAccaunt.Login;
            RegPasswordTB.Text = CurrentAccaunt.Password;
            regNameTB.Text = CurrentAccaunt.Name;
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
