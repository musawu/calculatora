namespace Calculatora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-addition");
            Console.WriteLine("2-substraction");
            Console.WriteLine("3-multiplication");
            Console.WriteLine("4-division");
            Console.Write("Choice");

            //int result = 0;
            int option = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Please enter your first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your second number");
            int num2 = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Console.WriteLine(  num1 + num2);
                    break;
                case 2: Console.Write(num1 - num2);
                    break;
                case 3:Console.WriteLine(num1 * num2);
                    break;
                case 4:Console.WriteLine( num1 / num2);
                    break;
                default:Console.WriteLine("Error");
                    break;
            }
        
        }
    }
}