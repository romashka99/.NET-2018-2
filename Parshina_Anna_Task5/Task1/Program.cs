using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
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

    class Employee : User
    {
        public Employee(string surname, string name, DateTime dateborn, string position, DateTime employeymentdate) : base(surname, name, dateborn)
        {
            EmployeymentDate = employeymentdate;
            Position = position;
        }
        private DateTime employeymentdate;
        public DateTime EmployeymentDate
        {
            get
            {
                    return employeymentdate;
            }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new Exception("Дата не может быть больше нынешней даты");
                }
                else employeymentdate = value;
            }
        }
        private int WorkExperience
        {
            get
            {
                int age;
                DateTime date = DateTime.Today;
                if (date.Month < EmployeymentDate.Month && date.Day < EmployeymentDate.Day)
                    age = date.Year - EmployeymentDate.Year;
                else age = date.Year - EmployeymentDate.Year - 1;
                return age;
            }
        }
        private string position;
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("Employee должен иметь должность");
                }
                else position = value;
            }
        }

        public void GetInformation()
        {
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Стаж работы: " + WorkExperience);
        }
    }
 

    class Program
    {
       
        static void Main(string[] args)
        {
            
        }
    }
}
