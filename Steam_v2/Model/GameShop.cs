using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
     public  class GameShop
    {
        public static List<Game> GamesList = new List<Game>();
        //public static List<Game> GamesList;
        public static string[] GamesNames
        {
            get
            {
                string[] tempSting = new string[GamesList.Count];

                for (int i = 0; i < GamesList.Count; i++)
                {
                    tempSting[i] = GamesList[i].Name;
                }
                return tempSting;
            }
        }

        public static Game BuyingGame(int indexGame)
        {
            Game currentGame = GamesList[indexGame];

            Account currentAccaunt = SteamClient.CurrentAccaunt;

            if (currentGame.ByTheGame(currentAccaunt))
            {
                currentAccaunt.AddGame(currentGame);

                return currentGame;
            }
            else
                return null;
        }

        public static Game BuyingGame(string gameName)
        {
            Game currentGame = GetGameByName(gameName);

            if (currentGame==null)
            {
                return null;
            }
            Account currentAccaunt = SteamClient.CurrentAccaunt;

            if (currentGame.ByTheGame(currentAccaunt))
            {
                currentAccaunt.AddGame(currentGame);

                return currentGame;
            }
            else
                return null;
        }

        public static Game GetGameByName(string name)
        {
            return GamesList.FirstOrDefault(x => x.Name == name);
        }
    }
}
