﻿using App.Model;
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
    public partial class Form1 : Form
    {
        private AccountProvider _accountProvider;
        public Form1()
        {
            InitializeComponent();

            _accountProvider = SteamClient.accauntProvider;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginingBtn_Click(object sender, EventArgs e)
        {
            Account tempAccount = _accountProvider.TryLogining(LoginTB.Text, PasswordTB.Text);
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
    }
}
