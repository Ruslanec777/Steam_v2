using Steam_v2.Enums;
using System;

namespace App.Model
{
    public class AccountData
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public string NicName { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }
        public long Id { get; private set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public AccountData(string name, string patronymic, string surname, string nicName, 
            Sex sex, int age, long id, string login, string password)
        {
            Name = name;
            Patronymic = patronymic;
            Surname = surname;
            NicName = nicName;
            Sex = sex;
            Age = age;
            Id = id;
            Login = login;
            Password = password;
        }
    }
}
