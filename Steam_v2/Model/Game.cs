using System;
using System.Drawing;
using System.IO;

namespace App.Model
{
    public class Game
    {
        private static long CountUnicID = 0;
        public string Name { get; private set; }

        public int Price { get; private set; }

        private string imgPath;
        public string ImgPath
        {
            get { return imgPath; }
            //set { imgPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")) + value; }
            set { imgPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\")) + "Steam_v2" + value; }
        }

        private Account[] accounts = new Account[0];

        public Game(string name)
        {
            Name = name;
        }

        public Game(string name, int price)
                   : this(name)
        {
            Price = price;
        }

        public Game(string name, int price, string imgPath) : this(name, price)
        {
            this.ImgPath = imgPath;
        }

        public bool SaleGame(Account account)
        {
            if (account != null && account.Balance > Price)
            {
                account.Balance -= Price;
                // account.AddGame(this);//
                return true;
            }

            return false;
        }

        public void PlayTheGame()
        {
            // вывести форму игры
        }

    }
}
