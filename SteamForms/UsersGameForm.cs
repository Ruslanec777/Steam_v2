using App.Model;
using SteamForms.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamForms
{
    public partial class UsersGameForm : Form, ImenuForms


    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }
        public bool IsClosingThisForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private List<object> _tempObjForPanting = new List<object>();
        public UsersGameForm()
        {
            InitializeComponent();
        }

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


            for (int i = 0; i < list.Count; i++)
            {
                PictureBox pictureBox = new PictureBox();

                _tempObjForPanting.Add(pictureBox);

                pictureBox.Name = "pictureBox" + $"_{list[i].Name}";

                if (left + _widthPictur > this.Size.Width)
                {
                    left = _startLeft;

                    top += _hightPictur + offsetTop;
                }
                pictureBox.Top = top;
                pictureBox.Left = left;

                pictureBox.Size = new System.Drawing.Size(_widthPictur, _hightPictur);
                pictureBox.Image = Image.FromFile(Path.GetFullPath(Path.Combine(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\") ,list[i].ImgPath)));
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new System.EventHandler(this.pictureBox_Click);

                this.Controls.Add(pictureBox);

                left += pictureBox.Width + offsetLeft;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (!GameShop.GetGameByName(pictureBox.Name.Split('_')[1]).PlayTheGame())
            {
                MessageBox.Show("Файл Notepade.exe не найден");
            } 
        }

        private void UsersGameForm_Load(object sender, EventArgs e)
        {
            ImageTabl(SteamClient.CurrentAccaunt.Games);
        }

        private void UsersGameForm_SizeChanged(object sender, EventArgs e)
        {
            ImageTabl(SteamClient.CurrentAccaunt.Games);
        }
    }
}
