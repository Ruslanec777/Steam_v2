using App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamForms
{
    public partial class Basket : Form
    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }
        public bool IsClosingThisForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Basket(AccountProvider accountProvider, Form parentForm)
        {

            InitializeComponent();
            AccountProvider = accountProvider;
            LocalParentForm = parentForm;

            this.WindowState = FormWindowState.Maximized;
            Thread.Sleep(1000);
            //ImageTabl(gameShop.GamesList, 40, 12);
        }

        // private void BattonsRow( List<object> list, int topParam =40, int leftParam =12 ) - не срабатывает почему то 
        private void ImageTabl(List<Game> list, int topParam = 40, int leftParam = 12, int offsetLeft = 20, int offsetTop = 20)
        {
            int top = gameShopActionLabel.Top + gameShopActionLabel.Height + offsetTop;
            int left = gameShopActionLabel.Left;

            int _startTop = top;
            int _startLeft = left;

            int _hightPictur = 165;
            int _widthPictur = 318;

            int _hight = this.ClientSize.Height;
            int _width = this.ClientSize.Width;

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
                pictureBox.Image = Image.FromFile(list[i].ImgPath);
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new System.EventHandler(this.pictureBox1_Click_1);

                this.Controls.Add(pictureBox);

                left += pictureBox.Width + offsetLeft;
            }
        }
    }
}
