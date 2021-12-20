﻿using App.Model;
using SteamForms.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SteamForms
{
    public partial class BuyingGame : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }
        public bool IsClosingThisForm { get; set; }
        public Game Game { get; set; }

        public BuyingGame(AccountProvider accountProvider, Form parentForm, Game game)
        {
            InitializeComponent();

            AccountProvider = accountProvider;

            LocalParentForm = parentForm;

            GamePictureBox.Image = Image.FromFile(game.ImgPath);
            GamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            GameNamelabel.Text = game.Name;

            Pricelabel.Text = "Цена " + game.Price.ToString();

            Game = game;
            // какой из способов предподчтительней ?
            if (SteamClient.CurrentAccaunt.IsGameInAccount(Game.Name))
            {
                GameAddBasketBtn.Enabled = false;
                GameNamelabel.Text += " : уже куплена";
            }
            // мне нравится этот
            if (SteamClient.CurrentAccaunt.Basket.Games.Exists(x=>x.Name==Game.Name))
            {
                GameAddBasketBtn.Enabled = false;
                GameNamelabel.Text += " : уже в корзине";
            }

        }

        private void GameAddBasketBtn_Click(object sender, EventArgs e)
        {
            if (SteamClient.CurrentAccaunt.Basket.Games.Exists(x => x.Name == Game.Name))
            {
                MessageBox.Show("Игра уже добавлена в корзину");
                GameAddBasketBtn.Enabled = false;
            }
            else
            {
                SteamClient.CurrentAccaunt.GameAddToBasket(Game);
                GameAddBasketBtn.Enabled = false;
                GameAddBasketBtn.Text = "Игра добавлена в корзину";
                LocalParentForm.Show();
                this.Close();
            }
        }
    }
}