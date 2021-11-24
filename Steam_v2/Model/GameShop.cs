﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
     public class GameShop
    {
        public  List<Game> GamesList { get; set; } = new List<Game>() { new Game("Snake game", 100), new Game("Tetris", 200), new Game("CS", 300) };
        public  string[] GamesNames
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

        public  Game BuyingGame(int indexGame)
        {
            Game currentGame = GamesList[indexGame];

            Account currentAccaunt = SteamClient.CurrentAccaunt;

            if (currentGame.SaleGame(currentAccaunt))
            {
                currentAccaunt.AddGame(currentGame);

                return currentGame;
            }
            else
                return null;

        }
    }
}
