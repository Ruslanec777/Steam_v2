using App.Model;
using SteamForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SteamForms
{
    public partial class BasketForm : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }
        public bool IsClosingThisForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private decimal _costOfSelectedGames;

        private List<CheckBox> _checkBoxesText = new List<CheckBox>();

        private List<Game> _chousenGames = new List<Game>();

        public BasketForm(AccountProvider accountProvider, Form parentForm)
        {
            InitializeComponent();
            AccountProvider = accountProvider;
            LocalParentForm = parentForm;

            this.WindowState = FormWindowState.Maximized;
            //ImageTabl(SteamClient.CurrentAccaunt.Basket.Games, 40, 12);
            checkedListBox.CheckOnClick = true;
            ReloadItemsText();
            ReloadConrols();
        }
        /// <summary>
        /// Не включает в себя перезагрузку элементов ЧекЛиста
        /// </summary>
        private void ReloadConrols()
        {          
            ReLoadBalancLabel();
            UpdateTheCostOfGames();
            AllowButtonBy();
        }



        // private void BattonsRow( List<object> list, int topParam =40, int leftParam =12 ) - не срабатывает почему то 


        private void ByGamesBtn_Click(object sender, EventArgs e)
        {
            foreach (string currentGameName in checkedListBox.CheckedItems)
            {
                GameShop.BuyingGame(currentGameName);
            }
            DeleteChousenItems();
            ReloadConrols();     
            
        }
        private void deleteChosenBtn_Click(object sender, EventArgs e)
        {
            DeleteChousenItems();
            ReloadItemsText();
            ReloadConrols();
        }
        private void DeleteChousenItems()
        {
           List<string> listItemsText= new List<string>();

            // непонятное действие , подсказано VS
            //listItemsText.AddRange((IEnumerable<string>)checkedListBox.CheckedItems);
            // не могу перебирать лист inems и изменять список игр в корзине , как то этот список связан с items чек листа , хотя нет перезаписи

            //взято https://coderoad.ru/37748051/%D0%9A%D0%B0%D0%BA-%D0%BF%D0%BE%D0%BB%D1%83%D1%87%D0%B8%D1%82%D1%8C-%D1%82%D0%B5%D0%BA%D1%81%D1%82%D1%8B-%D0%B4%D0%BB%D1%8F-CheckedItems-%D0%B2-CheckedListBox
            //принцип работы не ясен
            var texts = this.checkedListBox.CheckedItems.Cast<object>().Select(x => this.checkedListBox.GetItemText(x));

            foreach (string nameGame in texts)
            {
                SteamClient.CurrentAccaunt.Basket.RemoveGameByName(nameGame);
            }

            ReloadItemsText();
        }
        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadConrols();
        }
        private void UpdateTheCostOfGames()
        {
            decimal sum = 0;

            foreach (string nameGame in checkedListBox.CheckedItems)
            {
                sum += GameShop.GetGameByName(nameGame).Price;
            }
            _costOfSelectedGames = sum;

            BasketActionLbl.Text = $"Стоимость выбранных игр {sum }";
        }
        /// <summary>
        /// Нельзя выполнять если зачеканные элементы не удаляются
        /// </summary>
        private void ReloadItemsText()
        {
            checkedListBox.Items.Clear();

            foreach (var item in SteamClient.CurrentAccaunt.Basket.Games)
            {
                checkedListBox.Items.Add(item.Name);
            }
        }
        private void AllowButtonBy()
        {
            if (SteamClient.CurrentAccaunt.Balance >= _costOfSelectedGames)
            {
                ByGamesBtn.Enabled = true;
            }
            else
            {
                ByGamesBtn.Enabled = false;
            }
        }
        private void ReLoadBalancLabel()
        {
            balanceLbl.Text = $"Ваш баланс: {SteamClient.CurrentAccaunt.Balance}";
        }
    }
}
