using System;

namespace _2.operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores Numericos
            //Cambio de signo

            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;

            Console.WriteLine($"{num1} // {num2} // {num3} // {num4}");

            //Operadores Aritmeticos
            int num5 = 3+5;
            int num6 = 100-26;
            int num7 = 4*2;
            float num8 = 5f / 3;
            double num9 = 5d / 3;
            decimal num10 = 5 / 3m;

            Console.WriteLine($"Suma: {num5}, Resta: {num6}, Producto: {num7}, Division: {num8} Division: {num9}, {num10}");

            //Operadores incremento (++), decremento (--)
            num1++;//num1 = num1 + 1;
            num2--;//num2 = num2 - 1;
            num3+= 5;//num3 = num3 + 5;
            num4-= 4;//num4 = num4 - 20;
            num5*= 31;//num1 = num1 * 31;
            num7 /= num1;//num7 = num7 / num1;

            //Orden de evaluacion operadores aritmeticos
            int num11 = 4 * 3 / 2;
            int num12 =4 / 3 * 2;
            int num13 =(4 * 3) / 2;
            int num14 =4 * (3 / 2);
            int num15 =4 + 6 * 3;
            int num16 = 4 + 6 * (2 - 1) / 2;
            Console.WriteLine($"num11: {num11}, num12 {num12}, Producto: {num13}, num: {num14}, num15: {num15},num16: {num16}");

            //operadores logicos 
            // conjuncion - and &&
            Console.WriteLine("Tabla de verdad conjuncion");
            Console.WriteLine($"V && V = {true && false}");
            Console.WriteLine($"V && F = {true && false}");
            Console.WriteLine($"F && V = {false && true}");
            Console.WriteLine($"F && F = {false && false}");

            // conjuncion - or - ||
            Console.WriteLine("Tabla de verdad conjuncion");
            Console.WriteLine($"V || V = {true || false}");
            Console.WriteLine($"V || F = {true || false}");
            Console.WriteLine($"F || V = {false || true}");
            Console.WriteLine($"F || F = {false || false}");
            bool exp1 = true;
            bool exp2 = false;
            bool exp3 = exp1 && exp2;
            bool exp4 = exp1 || exp3;
            bool exp5 = exp4 || exp2;

            Console.WriteLine($"exp1:{exp1}, exp2:{exp2}, exp3:{exp3}, exp4:{exp4}, exp5:{exp5},");
        }
    }
}
