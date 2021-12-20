using System;
using System.Diagnostics;
using System.IO;



namespace App.Model
{
    public class Game
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string ImgPath { get; set; }


        public string GamePath { get; set; }
       

        private Account[] accounts = new Account[0];
        public Game()
        {
        }

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

        public Game(string name, int price, string imgPath, string gamePath) : this(name, price, imgPath)
        {
            GamePath = gamePath;
        }

        public bool ByTheGame(Account account)
        {
            if (account != null && account.Balance >= Price)
            {
                account.Balance -= Price;
                // account.AddGame(this);//
                return true;
            }

            return false;
        }

        public bool PlayTheGame()
        {
            //string str= this.GamePath;
            string str = "C:\\WINDOWS\\system32\\notepad.exe";
            if (File.Exists(str))
            {
                Process.Start(str, $"{ Path.GetFullPath(Path.Combine(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"),GamePath))}");
                return true;
            }
            else
            {               
                return false;
            }

        }

    }
}
