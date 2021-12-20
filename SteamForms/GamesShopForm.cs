using App.Model;
using SteamForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static App.Model.SteamClient;

namespace SteamForms
{
    public partial class GameShopForm : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }
        public bool IsClosingThisForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public GameShopForm(AccountProvider accountProvider, Form parentForm)
        {

            InitializeComponent();
            AccountProvider = accountProvider;
            LocalParentForm = parentForm;

            this.WindowState = FormWindowState.Maximized;
            //ImageTabl(gameShop.GamesList, 40, 12);
        }

        // private void BattonsRow( List<object> list, int topParam =40, int leftParam =12 ) - не срабатывает почему то 
        private void ImageTabl(List<Game> list, int topParam = 40, int leftParam = 12, int offsetLeft = 20, int offsetTop = 20)
        {
            int top = label1.Top + label1.Height + offsetTop;
            //int left = gameShopActionLabel.Left;

            int _hightPictur = 165;
            int _widthPictur = 318;

            int _hight = this.ClientSize.Height;
            int _width = this.ClientSize.Width;

            int left = (_width - (_width / (_widthPictur + offsetLeft) * (_widthPictur + offsetLeft))) / 2;

            int _startTop = top;
            int _startLeft = left;

            int i = 0;

            for (int k = 0; k < list.Count * 5; k++)
            {
                i = k >= list.Count ? k % list.Count : k;

                PictureBox pictureBox = new PictureBox();

                pictureBox.Name = "pictureBox" + $"_{list[i].Name}";

                if (left + _widthPictur > this.Size.Width)
                {
                    left = _startLeft;

                    top += _hightPictur + offsetTop;
                }
                pictureBox.Top = top;
                pictureBox.Left = left;

                pictureBox.Size = new System.Drawing.Size(_widthPictur, _hightPictur);
                pictureBox.Image = Image.FromFile(Path.Combine(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"),  list[i].ImgPath));
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new System.EventHandler(this.pictureBox1_Click_1);

                this.Controls.Add(pictureBox);

                left += pictureBox.Width + offsetLeft;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            string nameChosenGame = pictureBox.Name.Split('_')[1];

            Game game = GameShop.GetGameByName(nameChosenGame);

            this.Hide();

            new BuyingGame(AccountProvider, this, game).Show();
        }

        private void GameShopForm1_Load(object sender, EventArgs e)
        {
            ImageTabl(GameShop.GamesList, 40, 12);
        }

        private void GameShopForm_SizeChanged(object sender, EventArgs e)
        {
            ImageTabl(GameShop.GamesList, 40, 12);
        }
    }
}
