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
        }
    }
}