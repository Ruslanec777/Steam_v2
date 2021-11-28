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
    public partial class GameShopForm1 : Form, ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }
        public bool IsClosingThisForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public GameShopForm1(AccountProvider accountProvider, Form parentForm)
        {

            InitializeComponent();
            AccountProvider = accountProvider;
            LocalParentForm = parentForm;

            BattonsRow(gameShop.GamesList, 40, 12);
        }

        // private void BattonsRow( List<object> list, int topParam =40, int leftParam =12 ) - не срабатывает почему то 
        private void BattonsRow(List<Game> list, int topParam = 40, int leftParam = 12)
        {
            int top = gameShopActionLabel.Top + gameShopActionLabel.Height + 3;
            int left = gameShopActionLabel.Left;


            for (int i = 0; i < list.Count; i++)
            {
                
                Button button = new Button();
                button.AutoSize = true;
                button.Left = left;
                button.Top = top;
                button.Text = list[i].Name;
                button.Size = new Size(gameShopActionLabel.Width, gameShopActionLabel.Height);
                button.Font = new Font(button.Font.Name, 20, button.Font.Style);
                //button.Font = 
                this.Controls.Add(button);

                Label label = new Label();
                label.AutoSize = true;
                label.Left = left + button.Right + 5;
                label.Top = top;
                label.Font = new Font(gameShopActionLabel.Font.Name, 20, gameShopActionLabel.Font.Style);
                label.Size = new Size(gameShopActionLabel.Width / 3, gameShopActionLabel.Height);
                label.Text = $" цена:{ list[i].Price}";
                //button.Font = 
                this.Controls.Add(label);

                top += button.Height + 3;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameShopActionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
