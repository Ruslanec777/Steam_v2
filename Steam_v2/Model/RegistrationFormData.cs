using Steam_v2.Enums;
using System;

namespace App.Model
{
    public class RegistrationFormData
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public string NicName { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public RegistrationFormData(string name, string patronymic, string surname, string nicName, 
            Sex sex, int age, string login, string password)
        {
            Name = name;
            Patronymic = patronymic;
            Surname = surname;
            NicName = nicName;
            Sex = sex;
            Age = age;     
            Login = login;
            Password = password;
        }
    }
}
