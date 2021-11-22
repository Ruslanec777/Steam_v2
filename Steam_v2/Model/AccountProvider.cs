
using System.Collections.Generic;
using System.Linq;

namespace App.Model
{
    public class AccountProvider
    {

        public static List<Account> accounts = new List<Account>();
        public Account TryLogining(string login, string password)
        {

            Account tempAccaunt = FindAccountToLigin(login);

            if (tempAccaunt != null && tempAccaunt.Password == password)
            {

                tempAccaunt.IsAuthorized = true;

                return tempAccaunt;
            }

            return null;
        }
        public Account TryRegistrationAccaunt(RegistrationFormData accountData)
        {
            Account tempAccaunt = CreateAccauntInstance(accountData);
            if (tempAccaunt != null)
            {
                return AddNewAccaunt(tempAccaunt);
            }
            else
            {
                return null;
            }

        }

        private Account FindAccountToLigin(string login)
        {
            Account account = accounts.FirstOrDefault(i => i.Login == login);
            if (account == null)
            {
                return null;
            }
            return account;
        }


        private Account AddNewAccaunt(Account account)
        {
            accounts.Add(account);

            return account;
        }

        private Account CreateAccauntInstance(RegistrationFormData accountData)
        {
            if (FindAccountToLigin(accountData.Login) == null)
            {
                return new Account(accountData); // заносим вновь созданный аккаунт в текущий , переделать( несколько действий в методе)
            }

            return null;
        }



        //private static Account AdminAccountInitializer()
        //{
        //    return AddNewAccaunt(new Account("Админ Админович Админовский", Sex.Man, "Admin", 100, 1000000, "admin", "1234"));
        //}

    }
}
