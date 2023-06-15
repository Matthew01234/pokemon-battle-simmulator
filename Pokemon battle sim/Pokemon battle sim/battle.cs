using Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle_sim
{
    static class battle
    {

        public static void battlestart(trainer trainer1, trainer trainer2)
        {
            



            while (true)
            {


                for (int i = 0; i < 6; i++)
                {
                    Random r = new Random();
                    int rInt1 = r.Next(0, 5);

                    Random r1 = new Random();
                    int rInt2 = r1.Next(0, 5);

                    trainer1.Throw(rInt1);
                    Thread.Sleep(1000);

                    trainer2.Throw(rInt2);
                    Thread.Sleep(1000);

                    trainer1.Return(rInt1);
                    Thread.Sleep(1000);

                    trainer2.Return(rInt2);

                }
                Console.WriteLine("Wil je opnieuw beginnen of stoppen? (type opnieuw of stoppen )");
                string Qontinue = "" + Console.ReadLine();
                Qontinue = Qontinue.ToLower();
                if (Qontinue == "stoppen")
                {
                    break;
                }


            }
        }
    }
}
