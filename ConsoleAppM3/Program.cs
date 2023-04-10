namespace ConsoleAppM3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Andrei";

            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет, мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n Andrei");
            Console.WriteLine("\x23");

            string name = "Andrei";
            byte MyAge = 23;
            bool HaveIApet = true;
            double MyShoeSize = 44.5;

            Console.WriteLine("My name is {0}", name);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do i have a pet " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.ReadKey();

            //Можно обратиться к самому типу и получить из него это значение.
            //Например:

            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(decimal.MaxValue);

            //Еще один способ вывод в строку переменной
            
            String MyName1 = "Andrei";
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.WriteLine($"My name is {MyName1}");

            Console.ReadKey();

            //Cпособ вывода в строку нескольких переменных

            String MyName2 = "Andrei";
            double MyAge2 = 23;
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.WriteLine("My name is {0}, I’m {1} years old", MyName2,MyAge2);
            
            Console.ReadKey();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age is {age}");
            Console.ReadKey();

            //Анкета по заданию - "Финальная практика модуля «Анкетируем пользователей»" 

            Console.WriteLine("Как вас зовут?");
            var name3 = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            var age3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваше имя {name3} и вам {age3} года");
            Console.WriteLine("Когда вы родились?");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Вы родились {0}", birthdate);

            Console.ReadKey();
        }
    }
}
//Перечесления (Ключевое слово - Enum.)
enum DaysOfWeek : byte
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
enum Semaphore
{
    Red = 100,
    Yellow = 200,
    Green = 300
}
