using System;

namespace Task2
{
    class User
    {
        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("User должен иметь фамилию");
                }

            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("User должен иметь имя");
                }
                else name = value;
            }
        }
        public string SecondName;
        private DateTime dateborn;
        public DateTime DateBorn
        {
            get
            {
                return dateborn;
            }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new Exception("Дата рождения не может быть больше нынешней даты");
                }
                else dateborn = value;
            }
        }
        private int Age
        {
            get
            {
                int age;
                DateTime date = DateTime.Today;
                if (date.Month < DateBorn.Month && date.Day < DateBorn.Day)
                    age = date.Year - DateBorn.Year;
                else age = date.Year - DateBorn.Year - 1;
                return age;
            }
        }

        public void GetInformation()
        {
            Console.WriteLine("ФИО: " + surname + " " + name + " " + SecondName);
            Console.WriteLine("Дата рождения: " + dateborn);
            Console.WriteLine("Возраст: " + Age);
        }
        public User(string surname, string name, DateTime dateborn)
        {
            Surname = surname;
            Name = name;
            DateBorn = dateborn;
        }
    }
}
