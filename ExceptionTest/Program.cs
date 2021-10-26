using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
           try
           {
                Console.WriteLine("Insere um inteiro");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero Inserido : {i}");
           } 
           catch(OverflowException)
           {
                throw new Exception($"Que burro isso é muito grande ou muito pequeno");
           }
           catch(FormatException)
           {
                throw new Exception($"Achas que isso é um inteiro?");
           }
           catch(Exception e)
           {
                throw new Exception($"Error => {e.Message}");
           }
           

        }   
    }
}
