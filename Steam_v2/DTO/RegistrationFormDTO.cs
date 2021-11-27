using Steam_v2.Enums;
using System;

namespace App.Model
{
    public class RegistrationFormDTO
    {
        /// <summary>
        /// имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Ник
        /// </summary>
        public string NicName { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public Sex Sex { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        public RegistrationFormDTO(string name, string patronymic, string surname, string nicName, 
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
