using Steam_v2.Enums;
using System;
using System.Collections.Generic;

namespace App.Model
{
    public class Account
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public string NicName { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }
        //private static long AccauntCount
        //{ set; get; }
        public string Id { get; private set; }
        public decimal Balance { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAuthorized { get; set; }
        public string Fio { get; set; }

        public List<Game> Games = new List<Game>();

        public Basket Basket = new Basket();

        public Account()
        { 
        }

        public Account(RegistrationFormDTO accountData)
        {
            Id = Guid.NewGuid().ToString();
            Name = accountData.Name;
            Patronymic = accountData.Patronymic;
            Surname = accountData.Surname;
            NicName = accountData.NicName;
            Sex = accountData.Sex;
            Age = accountData.Age;
            Password = accountData.Password;
            Login = accountData.Login;
        }

        public string AccauntData
        {
            get
            {
                return $"{Id} {Balance} {Login}";
            }
            set { }
        }

        public bool GameAddToBasket(Game game)
        {
            if (Games.Exists(x => x.Name == game.Name))
            {
                return false;
            }
            else
            {
                if (true)
                {

                }
                return Basket.AddGameToBasket(game);
            }
        }


        public string[] GamesNames
        {
            get
            {
                string[] tempSting = new string[Games.Count];

                for (int i = 0; i < Games.Count; i++)
                {
                    tempSting[i] = Games[i].Name;
                }
                return tempSting;
            }
        }

        public bool AddMoney(decimal money)
        {
            if (money > 0)
            {
                Balance += money;

                SteamClient.dataStorage.Save(SteamClient.accauntProvider.accounts);

                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal RemoveMoney(decimal money)
        {
            if (money < 0)
            {
                return 0;
            }
            if (Balance > money)
            {
                Balance -= money;

                SteamClient.dataStorage.Save(SteamClient.accauntProvider.accounts);

                return money;
            }
            else
            {
                decimal tempMoney = Balance;
                Balance = 0;
                return tempMoney;
            }
        }

        private void ParsingFio(string fio)
        {
            string[] tempFio = fio.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Surname = tempFio[0];
            Name = tempFio[1];
            Patronymic = tempFio.Length > 2 ? tempFio[2] : "";
        }

        public bool Authorization(string login, string password)
        {
            if (Login == login && Password == password)
            {
                return true;
            }

            return false;
        }

        public void AddGame(Game game)
        {
            Games.Add(game);

            SteamClient.dataStorage.Save(SteamClient.accauntProvider.accounts);
        }

        public string GetAccauntData()
        {
            return $"ID: {Id}\n" +
                   $"NicName: {NicName} \n" +
                   $"Surname: {Surname} \n" +
                   $"Name: {Name} \n" +
                   $"Patronymic: {Patronymic} \n" +
                   $"Age: {Age} \n" +
                   $"Login: {Login}\n" +
                   $"Password: {Password} \n" +
                   $"Balance: {Balance}\n" +
                   $"IsAuthorized: {IsAuthorized} \n";
        }

        public Game[] RemoveGame(string nameGame, Game[] games)
        {
            Game[] tempArraay = new Game[games.Length - 1];

            bool gameHasBeenDeleted = false;

            for (int i = 0; i < games.Length; i++)
            {
                if (i == games.Length - 1 || !gameHasBeenDeleted)
                {
                    return games;
                }

                if (nameGame == games[i].Name)
                {
                    gameHasBeenDeleted = true;

                    continue;
                }

                tempArraay[i] = games[i];
            }


            return tempArraay;
        }
    }
}
