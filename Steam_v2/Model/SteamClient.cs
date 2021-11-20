using System;

namespace App.Model
{
    public class SteamClient
    {
        public static Account CurrentAccaunt { get; set; } = null;

        public static AccountProvider accauntProvider = new AccountProvider();

    }
}
