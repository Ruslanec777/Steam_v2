
namespace App.Model
{
    public class Game
    {
        private static long CountUnicID = 0;
        public string Name { get; private set; }

        public int Price { get; private set; }

        private Account[] accounts = new Account[0];

        // private  Account [] Accounts { get; set; }

        public Game(string name)
        {
            Name = name;
        }

        public Game(string name, int price)
                   : this(name)
        {
            Price = price;
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
