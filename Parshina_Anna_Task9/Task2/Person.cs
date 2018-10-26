using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void Message(Person employee);
    public class Person
    {
        public string Name { get; set; }

        public DateTime TimeCame { get; set; }

        public void Greet(Person employee)
        {
            if (employee.TimeCame.Hour <= 12) Console.WriteLine("'Доброе утро, {0}!' - сказал(а) {1}.", employee.Name, Name);
            if (employee.TimeCame.Hour > 12 && employee.TimeCame.Hour < 17) Console.WriteLine("'Добрый день, {0}!' - сказал(а) {1}.", employee.Name, Name);
            if (employee.TimeCame.Hour >= 17) Console.WriteLine("'Добрый вечер, {0}!' - сказал(а) {1}.", employee.Name, Name);

        }
        public void Bye(Person employee)
        {
            Console.WriteLine("'Пока, {0}!' - сказал(а) {1}.", employee.Name, Name);
        }

        // события
        public event Message Came;
        public event Message BackHome;

        public void OnCame()
        {
            // зачем проверка ?
            if (Came != null)
            {
                Came(this);
            }
        }

        public void Back()
        {
            // зачем проверка ?
            if (BackHome != null)
            {
                BackHome(this);
            }
        }

        public Person(string name)
        {
            Name = name;
            Console.WriteLine(Name + " пришел(а) на работу.");
        }

        public void Remove()
        {
            Console.WriteLine(Name + " ушел(а) на работу.");
            Back();
        }
    }
}
