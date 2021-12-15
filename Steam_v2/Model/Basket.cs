using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Basket
    {
        public List<Game> Games { get; set; } = new List<Game>();

        internal bool AddGameToBasket(Game game)
        {
            if (Games.Exists(x => x.Name == game.Name))
            {
                return false;
            }
            else
            {
                Games.Add(game);

                return true;
            }
        }

        public bool RemoveGame(Game game)
        {
            if (Games.Remove(game))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
