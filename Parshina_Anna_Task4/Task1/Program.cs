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
        public string Surname;
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
            Console.WriteLine("ФИО: " + Surname + " " + name + " " + SecondName);
            Console.WriteLine("Дата рождения: " + dateborn);
            Console.WriteLine("Возраст: " + Age);
        }
    }
    class Program
    {
        static string Definition(string str)
        {
            if (str == String.Empty) return String.Empty;
            string patterndate = @"([0][1-9]|[1-2][0-9]|[3][0-1])[.]([0][1-9]|[1][0-2])[.]([1][9][0-9][0-9]|[2][0][0-1][0-8])";
            string patternstr = @"([A-Z]|[a-z]|[А-Я]|[а-я]|[Ё,ё,-])+";
            Regex value = new Regex(patterndate);
            if (value.IsMatch(str)) return "date";
            value = new Regex(patternstr);
            if (value.IsMatch(str)) return "str";
            return String.Empty;
        }

        static string Chack(ref string str)
        {
            while (true)
            {
                if (Definition(str) == String.Empty)
                {
                    Console.WriteLine("Некорректный ввод.Попробуйте еще раз");
                    str = Console.ReadLine();
                }
                else break;
            }
            return Definition(str);
        }

        static string Input(string value)
        {
            string temp = Console.ReadLine();
            while (Chack(ref temp) != value)
            {
                Chack(ref temp);
            }
           return temp;
        }


        static void Main(string[] args)
        {
            while (true)
            {
                User user = new User();
                Console.WriteLine("Введите фамилию: ");
                user.Surname = Input("str");
                Console.WriteLine("Введите имя: ");
                user.Name = Input("str");
                Console.WriteLine("Введите отчество: ");
                user.SecondName = Input("str");
                Console.WriteLine("Введите дату рождения: ");
                user.DateBorn = DateTime.Parse(Input("date"));
                user.GetInformation();
                ConsoleKeyInfo end = new ConsoleKeyInfo();
                Console.WriteLine("Для выхода нажмите Esc...");
                end = Console.ReadKey();
                if (end.Key == ConsoleKey.Escape)
                    break;
                Console.WriteLine();
            }
        }
    }
}
