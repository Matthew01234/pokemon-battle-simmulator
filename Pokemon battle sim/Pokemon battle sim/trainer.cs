using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class trainer
    {
        
        List <pokeballs> riem = new List<pokeballs>();

        private string name;
        public trainer(string name)
        {
            this.name = name;
            riem.Add(new pokeballs(new Pokemon("charmander1", "water", "fire")));
            riem.Add(new pokeballs(new Pokemon("charmander2", "water", "fire")));
            riem.Add(new pokeballs(new Pokemon("charmander3", "water", "fire")));
            riem.Add(new pokeballs(new Pokemon("charmander4", "water", "fire")));
            riem.Add(new pokeballs(new Pokemon("charmander5", "water", "fire")));
            riem.Add(new pokeballs(new Pokemon("charmander6", "water", "fire")));

        }

        public string getName()
        {
            return name;
        }
    } 
}
