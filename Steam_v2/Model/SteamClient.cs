using System;

namespace App.Model
{
    public static class SteamClient
    {
        public static Account CurrentAccaunt { get; set; } = null;

        public static AccountProvider accauntProvider = new AccountProvider();

        public static GameShop gameShop = new GameShop();

    }
}
