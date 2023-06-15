using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons;
using Pokemon_battle_sim;

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

            battle.battlestart(trainer1,trainer2);





        }
    }
}

