
using System.Collections.Generic;
using System.Linq;

namespace App.Model
{
    public  class AccountProvider
    {

        public List<Account> accounts = new List<Account>();
        public  Account TryLogining(string login, string password)
        {
            Account tempAccaunt = FindAccountToLigin(login);

            if (tempAccaunt != null && tempAccaunt.Password == password)
            {

                tempAccaunt.IsAuthorized = true;

                return tempAccaunt;
            }
            return null;
        }
        public Account TryRegistrationAccaunt(RegistrationFormDTO accountData)
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

        public Account EditAccaunt(RegistrationFormDTO accountData)
        {
            Account tempAccaunt = FindAccountToId(accountData.Id);
            if (tempAccaunt != null)
            {
                tempAccaunt.Name = accountData.Name;
                tempAccaunt.Patronymic = accountData.Patronymic;
                tempAccaunt.Surname = accountData.Surname;
                tempAccaunt.NicName = accountData.NicName;
                tempAccaunt.Sex = accountData.Sex;
                tempAccaunt.Age = accountData.Age;
                tempAccaunt.Login = accountData.Login;
                tempAccaunt.Password = accountData.Password;
                return tempAccaunt;
            }
            else
            {
                return null;
            }
        }

        public Account FindAccountToId(string id)
        {
            Account account = accounts.FirstOrDefault(i => i.Id == id);
            if (account == null)
            {
                return null;
            }
            return account;
        }

        public Account FindAccountToLigin(string login)
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

        private Account CreateAccauntInstance(RegistrationFormDTO accountData)
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
