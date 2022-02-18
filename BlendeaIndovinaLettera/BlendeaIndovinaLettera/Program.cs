using System;

namespace BlendeaIndovinaLettera
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Num = new Random();
            int num = Num.Next(1, 100);
            int tentativi = 0;
            int n;
            int punteggio = 1000;
            
            Console.WriteLine("Srivi un numero compreso tra 1 e 100");
            while (tentativi <= 100)
            {
                n = Convert.ToInt32(Console.ReadLine());
                tentativi++;
                if (num < n)
                {
                  
                    Console.WriteLine("Il numero generato è piu basso");
                }
                else if (num > n)
                {
                    
                    Console.WriteLine("Il numero generato è piu grande");
                }
                else if (num == n)
                {
                    Console.WriteLine($"Bravo hai indovinato il tuo numero è {num}");
                    Console.WriteLine($"Il numero dei tuoi tentativi è: {tentativi}");
                    Console.WriteLine($"Il tuo punteggio è {punteggio - tentativi * 50}");
                 
                }
             
            }
        

            
       }
    }
}
