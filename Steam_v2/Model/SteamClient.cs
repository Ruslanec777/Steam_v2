using System;

namespace App.Model
{
    public static class SteamClient
    {
        public static Account CurrentAccaunt { get; set; } = null;

        public static AccountProvider accauntProvider = new AccountProvider();

        public static DataStorage dataStorage = new DataStorage(System.IO.Directory.GetCurrentDirectory());

        public static GameShop gameShop = new GameShop();

        public static bool EditAccaunt(RegistrationFormDTO accountData)
        {
            //Account tempAccaunt = FindAccountToId(accountData.Id);
            if (CurrentAccaunt != null)
            {
                CurrentAccaunt.Name = accountData.Name;
                CurrentAccaunt.Patronymic = accountData.Patronymic;
                CurrentAccaunt.Surname = accountData.Surname;
                CurrentAccaunt.NicName = accountData.NicName;
                CurrentAccaunt.Sex = accountData.Sex;
                CurrentAccaunt.Age = accountData.Age;
                CurrentAccaunt.Login = accountData.Login;
                CurrentAccaunt.Password = accountData.Password;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
