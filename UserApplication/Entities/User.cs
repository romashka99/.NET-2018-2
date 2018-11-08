using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        private int id;

        private string firstname;
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("Пользователь должен иметь имя");
                }
                if (value.Length > 50)
                {
                    throw new Exception("Имя пользователя не должно превышать 50 символов");
                }
                firstname = value;
            }
        }
        private string lastname;
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("Пользователь должен иметь фамилию");
                }
                if (value.Length > 50)
                {
                    throw new Exception("Фамилия пользователя не должна превышать 50 символов");
                }
                lastname = value;
            }
        }
        private DateTime birthdate;
        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new Exception("Дата рождения не может быть больше нынешней даты");
                }
                if (Age > 150)
                {
                    throw new Exception("Возраст не может быть выше 150 лет");
                }
                birthdate = value;
            }
        }
        private int Age
        {
            get
            {
                int age;
                DateTime date = DateTime.Today;
                if (date.Month < Birthdate.Month && date.Day < Birthdate.Day)
                    age = date.Year - Birthdate.Year;
                else age = date.Year - Birthdate.Year - 1;
                return age;
            }
        }

        public User(int id, string firstname, string lastname, string birthdate)
        {
            this.id = id;
            FirstName = firstname;
            LastName = lastname;
            DateTime date = DateTime.Parse(birthdate);
            Birthdate = date;
        }
    }
}
