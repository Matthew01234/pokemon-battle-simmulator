using Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle_sim
{
    class charmander : Pokemon
    {
        private string name = "";
        public charmander(string name) : base(name, "water", "ground")
        {
            this.name = name;
        }
        public override void battlecry(string cry)
        {
            Console.WriteLine($" {name}:{cry}!");
        }

    }
}
