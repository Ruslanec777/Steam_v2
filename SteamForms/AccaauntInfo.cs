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
            WriteAllFields();
        }

        private void WriteAllFields()
        {
            infNameLab.Text = $"Имя: {CurrentAccaunt.Name}";
            infPanronimicLab.Text = $"Отчество {CurrentAccaunt.Patronymic}";
            infSurnameLab.Text = $"Фамилия {CurrentAccaunt.Surname}";
            infNicNameLab.Text = $"Ник {CurrentAccaunt.NicName}";
            infSexLab.Text = $"Пол {CurrentAccaunt.Sex}";
            infAgeLab.Text = $"Возраст {CurrentAccaunt.Age}";
            infLoginLab.Text = $"Логин {CurrentAccaunt.Login}";
            infPassvordLab.Text = $"Пароль {CurrentAccaunt.Password}";
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

        private void AccountInfo_VisibleChanged(object sender, EventArgs e)
        {
            WriteAllFields();
        }
    }
}
