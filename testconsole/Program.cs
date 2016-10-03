using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole
{
    class Program
    {
        private List<Stock> ListAsset; 
        static void Main(string[] args)
        {
            Program myProgram = new Program(); //laver en instans af sig selv 
            myProgram.Run(); 

        }
        public void Run() //ved at starte den vil den printe det ud. 

        {

            ListAsset = new List<Stock>();
            bool running = true;
            string choice = " ";
            do
            {
                ShowMenu();
                choice = GetUserChoice();
                switch (choice)
                {
                    case "1": OpretStock(); break;
                    case "2": PrintList(); break; 
                    case "9": running = false; break; 
                    default: ShowMenuSelectionError(); break;


                } 


            } while (running);
        }

        private void PrintList()
        {
            foreach (Stock s in ListAsset)
            {
                Console.WriteLine(s); 

            }
            Console.ReadKey();
        }

        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Error prøv igen");
            Console.ReadLine(); 
        }
      
        private void ShowMenu()
        {
            Console.WriteLine ("Indtast:"); 
            Console.WriteLine ("1. Opret stock");
            Console.WriteLine("2. Print List");
            Console.WriteLine("9. Exit");
                


        }

        private void OpretStock()
        {
            Console.WriteLine("Opret en stock");
            Console.Write("Indtast symbol: ");
            string symbol = Console.ReadLine();
            Console.Write("Indtast Number: ");
            int numShares = Int32.Parse (Console.ReadLine());
            Console.Write("Indtast Price: ");
            double pricePerShare = double.Parse(Console.ReadLine()); 

            ListAsset.Add(new Stock(){ Symbol = symbol, NumShares = numShares, PricePerShare = pricePerShare });

         
        }

        private string GetUserChoice()
        {
            Console.WriteLine("Indtast valg: ");
            return Console.ReadLine(); 
        }
    }
}
