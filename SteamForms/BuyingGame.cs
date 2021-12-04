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

namespace SteamForms
{
    public partial class BuyingGame : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }
        public bool IsClosingThisForm { get; set; }

        public BuyingGame(AccountProvider accountProvider, Form parentForm, Game game)
        {
            InitializeComponent();

            AccountProvider = accountProvider;

            LocalParentForm = parentForm;

            GamePictureBox.Image = Image.FromFile(game.ImgPath);
            GamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            GameNamelabel.Text = game.Name;
        }

    }
}
