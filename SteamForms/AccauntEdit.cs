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
        public List<Control> NotValidList { get; set; }

        public bool IsValidLogin { get; set; }
        public string CurrentLogin { get; set; }
        public RegistrationFormDTO RegFormDTO
        {
            get
            {
                Sex sex = (editSexCBox.Text == "Мужской") ? Sex.Man : Sex.Woman;

                int age;
                int.TryParse(editAgeTB.Text, out age);

                RegistrationFormDTO accountData = new RegistrationFormDTO(editNameTB.Text, editPatronymicTB.Text, editSurnameTB.Text, editNicNameTb.Text,
                    sex, age, editLoginTB.Text, editPasswordTB.Text ,SteamClient.CurrentAccaunt.Id);

                return accountData;
            }
        }

        public bool IsClosingThisForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AccauntEdit(AccountProvider accountProvider, Form parent)
        {
            InitializeComponent();

            AccountProvider = accountProvider;
            LocalParentForm = parent;
            Form tempForm = ParentForm;
            editNameTB.Text = CurrentAccaunt.Name;
            editPatronymicTB.Text = CurrentAccaunt.Patronymic;
            editSurnameTB.Text = CurrentAccaunt.Surname;
            editNicNameTb.Text = CurrentAccaunt.NicName;
            editSexCBox.Text = (CurrentAccaunt.Sex == Sex.Man) ? "Мужской" : "Женский";
            editAgeTB.Text = CurrentAccaunt.Age.ToString();
            editLoginTB.Text = CurrentAccaunt.Login;
            editPasswordTB.Text = CurrentAccaunt.Password;
            editNameTB.Text = CurrentAccaunt.Name;
            LoginPictureBox1.Image = global::SteamForms.Properties.Resources._true;
        }

        private void AccauntEdit_Load(object sender, EventArgs e)
        {
            LocalParentForm.Hide();
        }

        private void AccauntEdit_Closed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            LocalParentForm.Show();
        }

        private void editSaveBtn_Click(object sender, EventArgs e)
        {
            NotValidList = new List<Control>();

            foreach (Control c in this.Controls)
            {
                if (c.Name == "LoginPictureBox1")
                {
                    continue;
                }

                if (c.Text.Length == 0)
                {
                    NotValidList.Add(c);
                    c.BackColor = Color.Red;
                    continue;
                }
                else
                {
                    c.BackColor = Color.White;
                }

                switch (c.Name)
                {
                    case "editAgeTB":
                        int age;

                        if ((int.TryParse(editAgeTB.Text, out age) && age > 6 && age < 130) == false)
                        {
                            editAgeTB.BackColor = Color.Red;
                            NotValidList.Add(c);
                        }
                        else
                        {
                            editAgeTB.BackColor = Color.White;
                        }
                        break;
                    default:
                        break;
                }
            }

            if (NotValidList.Count > 0)
            {
                MessageBox.Show("Введите корректные значения");
                return;
            }


            Account tempAccount = AccountProvider.EditAccaunt(RegFormDTO);
            if (tempAccount != null)
            {
                MessageBox.Show("Данные аккааунта отредактированы");
                LocalParentForm.Show();

                this.Close();
            }else
            {
                MessageBox.Show("Не удалось совершить редактирование");
            }
        }

        private void editLoginTB_TextChanged(object sender, EventArgs e)
        {
            if (editLoginTB.Text.Length!=0 && (editLoginTB.Text==CurrentAccaunt.Login || (AccountProvider.FindAccountToLigin(editLoginTB.Text) == null)))
            {
                editLoginTB.BackColor = Color.White;
                LoginPictureBox1.Image = global::SteamForms.Properties.Resources._true;
                IsValidLogin = true;
            }
            else
            {
                LoginPictureBox1.Image = global::SteamForms.Properties.Resources._false;
                IsValidLogin = false;
            }
        }
    }
}
