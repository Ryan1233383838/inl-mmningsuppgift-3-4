using System;
namespace Uppgift_3_4
    {
        class Program
        {
            static void Main(string[] args)
            {
               
                Console.Write("Ange antalet minuter för låten: ");
                int minuter = int.Parse(Console.ReadLine());

                Console.Write("Ange antalet sekunder för låten: ");
                int sekunder = int.Parse(Console.ReadLine());

                
                int totalTidISekunder = minuter * 60 + sekunder;

               
                int minstaTid = 2 * 60 + 45;   
                int maxstaTid = 4 * 60 + 20;    
                
                if (totalTidISekunder >= minstaTid && totalTidISekunder <= maxstaTid)
                {
                    Console.WriteLine("Låten får spelas på radiostationen.");
                }
                else
                {
                    Console.WriteLine("Låten får inte spelas på radiostationen.");
                }
            }
        }
    }
