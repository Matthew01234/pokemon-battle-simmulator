using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons;

namespace Pokemon_battle_sim
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe wil je trainer nummer 1 noemen?");
            string trainernameeen = "" + Console.ReadLine();
            trainer trainer1 = new trainer(trainernameeen);


            Console.WriteLine("\nHoe wil je trainer nummer 2 noemen?");
            string trainernametwee = "" + Console.ReadLine();
            trainer trainer2 = new trainer(trainernametwee);

            trainer1.Throw(0);
            Thread.Sleep(1000);
            trainer2.Throw(1);
            Thread.Sleep(1000);
            trainer1.Return(0);
            Thread.Sleep(1000);
            trainer2.Return(1);
       
            
                
            
        }
    }
}
