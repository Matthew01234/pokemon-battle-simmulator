using Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle_sim
{
     class bulbasaur : Pokemon 
    {
        private string name = "";
        public bulbasaur(string name) : base(name, "leaf", "fire")
        {
            this.name = name;
        }
        public override void battlecry(string cry)
        {
            Console.WriteLine($" {name}:{cry}!");   
        }
        
    }
}
