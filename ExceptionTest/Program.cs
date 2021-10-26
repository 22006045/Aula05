using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insere um inteiro");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero Inserido : {i}");
        }   
    }
}
