using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class trainer
    {

        List<pokeballs> riem = new List<pokeballs>();

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
        public void Throw(int index)
            {
       
            Console.WriteLine("\n"+name+ " gooit ze pokeball nummer: "+ index +" ");
            Thread.Sleep(1000);
            Console.WriteLine("" + name + " Gooit zijn pokemon genaamd:" + riem[index].GetPokemon().getName() + "");
            Thread.Sleep(1000);
            riem[index].GetPokemon().battlecry(riem[index].GetPokemon().getName());

            }
        public void Return(int index)
        {

            Console.WriteLine("\n" + name + " gooit ze pokeball nummer: " + index + " terug naar ze pokemon");
            Thread.Sleep(1000);
            Console.WriteLine("" + name + " Zijn pokemon genaamd:" + riem[index].GetPokemon().getName() + " Gaat terug in de bal");

        }





        public string getName()
        {
            return name;
        }

    } 
}
