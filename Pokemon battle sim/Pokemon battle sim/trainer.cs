using Pokemon_battle_sim;
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
            riem.Add(new pokeballs(new bulbasaur("Grog de bulbasaur")));
            riem.Add(new pokeballs(new bulbasaur("gerrit de bulbasaur")));
            riem.Add(new pokeballs(new charmander("tommy de charmander")));
            riem.Add(new pokeballs(new charmander("bob de charmander")));
            riem.Add(new pokeballs(new squirtle("greg de squirtle")));
            riem.Add(new pokeballs(new squirtle("dixie de squirtle")));

        }
        public void Throw(int index)
            {
       
            textsettings.SlowWrite("\n"+name+ " gooit ze pokeball nummer: "+ index +" ");
            Thread.Sleep(1000);
             textsettings.SlowWrite("" + name + " Gooit zijn pokemon genaamd:" + riem[index].GetPokemon().getName() + "");
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
