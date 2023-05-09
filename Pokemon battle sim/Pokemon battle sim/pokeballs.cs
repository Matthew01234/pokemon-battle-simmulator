using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class pokeballs
    {
        private Pokemon pokemon;
        public pokeballs(Pokemon pokemon) 
        {
            this.pokemon = pokemon;
        }
        public Pokemon GetPokemon()
        {
            return pokemon;
        }
    }
}
