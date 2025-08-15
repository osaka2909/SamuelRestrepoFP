using System.ComponentModel.Design;

namespace _5.condicional_anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            
            Console.WriteLine("Ingresa numero 1:");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa numero 2:");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa numero 3:");
            num3 = Int32.Parse(Console.ReadLine());

            if(num1>num2)
            {
                if (num1 > num3) 
                {
                    Console.WriteLine($"numero 1: {num1}, es el mayor");
                }
                else
                {
                    Console.WriteLine($"numero 3:{num3}, es el mayor");
                }
            }
            else
            {
                if (num2 > num3) 
                {
                    Console.WriteLine($"numero 2: {num2}, es el mayor");
                }
                else 
                {
                    Console.WriteLine($"numero 3: {num3}, es el mayor");
                }
            }
        }
    }
}
