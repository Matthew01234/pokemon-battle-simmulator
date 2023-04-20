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
            Console.WriteLine("You caught a wild charmander!");
            Console.WriteLine("How do u want to name it?");
            string name = "" + Console.ReadLine();
            Pokemon charmender = new Pokemon(name, "fire", "water");
            for (int o = 0; o < 2;)
            {
                for (int i = 0; i < 10; i++)
                {
                    charmender.battlecry(name);
                }
                Console.WriteLine("Do u want to rename it?");
                string antwoord = "" + Console.ReadLine();
                if (antwoord == "yes")
                {
                    Console.WriteLine("'What do u want to name it");
                    name = "" + Console.ReadLine();
                }
                else { break; }
                
            }
        }
    }
}
