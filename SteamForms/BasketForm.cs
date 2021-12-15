using App.Model;
using SteamForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SteamForms
{
    public partial class BasketForm : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }
        public bool IsClosingThisForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private int _numberOfChosenGames;

        private int _costOfSelectedGames;

        private List<CheckBox> _checkBoxes = new List<CheckBox>();

        private List<Game> _chousenGames = new List<Game>();

        public BasketForm(AccountProvider accountProvider, Form parentForm)
        {
            InitializeComponent();
            AccountProvider = accountProvider;
            LocalParentForm = parentForm;

            this.WindowState = FormWindowState.Maximized;
            //ImageTabl(SteamClient.CurrentAccaunt.Basket.Games, 40, 12);
            balanceLbl.Text =  $"Ваш баланс: {SteamClient.CurrentAccaunt.Balance}";
            ReloadItemsText();
            checkedListBox.CheckOnClick = true;

            if (SteamClient.CurrentAccaunt.Balance>_costOfSelectedGames)
            {
            ByGamesBtn.Enabled = true;
            }
            else
            {
                ByGamesBtn.Enabled = false;
            }
        }

        // private void BattonsRow( List<object> list, int topParam =40, int leftParam =12 ) - не срабатывает почему то 
        private void ImageTabl(List<Game> list, int topParam = 40, int leftParam = 12, int offsetLeft = 20, int offsetTop = 20)
        {
            int top = BasketActionLbl.Top + BasketActionLbl.Height + offsetTop;
            int left = BasketActionLbl.Left;

            int _startTop = top;
            int _startLeft = left;

            int _hightPictur = 165;
            int _widthPictur = 318;

            int _hightCheckBox = 50;
            int _widthCheckBox = _widthPictur;

            int _hight = this.ClientSize.Height;
            int _width = this.ClientSize.Width;





            for (int i = 0; i < list.Count; i++)
            {
                //i = k >= list.Count ? k % list.Count : k;

                PictureBox pictureBox = new PictureBox();

                pictureBox.Name = "pictureBox" + $"_{list[i].Name}";

                if (left + _widthPictur > this.Size.Width)
                {
                    left = _startLeft;

                    top += _hightPictur + offsetTop * 2 + _hightCheckBox;
                }
                pictureBox.Top = top;
                pictureBox.Left = left;

                pictureBox.Size = new System.Drawing.Size(_widthPictur, _hightPictur);
                pictureBox.Image = Image.FromFile(list[i].ImgPath);
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                this.Controls.Add(pictureBox);

                CheckBox checkBox = new CheckBox();

                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(left, top + _hightPictur + offsetTop);
                checkBox.Name = "checkBox " + $"_{list[i].Name}";
                checkBox.Size = new System.Drawing.Size(_widthPictur, _hightCheckBox);
                checkBox.TabIndex = 2;
                checkBox.Text = "выбрать ";
                checkBox.UseVisualStyleBackColor = true;
                checkBox.BackColor = Color.Red;
                _checkBoxes.Add(checkBox);
                checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
                this.Controls.Add(checkBox);

                left += pictureBox.Width + offsetLeft;
            }
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            //ImageTabl(SteamClient.CurrentAccaunt.Basket.Games, 40, 12);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            _costOfSelectedGames = 0;
            _numberOfChosenGames = 0;
            _chousenGames =new List<Game>();

            foreach (CheckBox locCheckBox in _checkBoxes)
            {
                if (locCheckBox.Checked)
                {
                    Game currentGame = GameShop.GetGameByName(locCheckBox.Name.Split('_')[1]);
                    _chousenGames.Add(currentGame);
                    _costOfSelectedGames += currentGame.Price;

                }
            }
            if (SteamClient.CurrentAccaunt.Balance > _costOfSelectedGames)
            {
                ByGamesBtn.Enabled = true;
            }
            else
            {
                ByGamesBtn.Enabled = false;
            }
        }

        //private void RewriteActionLabel()
        //{
        //    if (_chousenGames.Count==0)
        //    {
        //        BasketActionLbl.Text = "Игр не выбрано";
        //    }
        //    else
        //    {
        //        BasketActionLbl.Text = $"Выбрано {_chousenGames.Count} игр , на сумму {_costOfSelectedGames} $ ";
        //    }
        //}

        private void ByGamesBtn_Click(object sender, EventArgs e)
        {
            foreach (Game currentGame in _chousenGames)
            {
                GameShop.BuyingGame(currentGame.Name);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox.SelectedItems)
            {
                _chousenGames.Add(GameShop.GetGameByName(item.ToString()));
            }
            
        }

        private void ReloadItemsText()
        {
            checkedListBox.Items.Clear();

            foreach (var item in SteamClient.CurrentAccaunt.Basket.Games)
            {
                checkedListBox.Items.Add(item.Name);
            }
        }

        private void deleteChosenBtn_Click(object sender, EventArgs e)
        {
            foreach (Game item in _chousenGames)
            {
                SteamClient.CurrentAccaunt.Basket.RemoveGame(item);
            }
                ReloadItemsText();
        }
    }
}
