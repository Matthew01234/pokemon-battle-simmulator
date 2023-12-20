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

                    bool t1win = false;
                    bool t2win = false;


                    //var p1 = trainer1.getBelt()[rInt1].GetPokemon();
                    //Console.WriteLine(p1.IsWeaknessTo(trainer2.getBelt()[rInt2].GetPokemon()));
                    if (trainer1.getBelt()[rInt1].GetPokemon().IsWeaknessTo(trainer2.getBelt()[rInt2].GetPokemon()))
                    {
                        t2win = true;
                    }

                    if (trainer2.getBelt()[rInt2].GetPokemon().IsWeaknessTo(trainer1.getBelt()[rInt1].GetPokemon()))
                    {
                        t1win = true;
                    }

                    // gelijkspel
                    if (t1win == t2win)
                    {
                        trainer1.Return(rInt1);
                        trainer2.Return(rInt2);
                        Console.WriteLine("gelijkspel");
                    }

                    //Player 1 wint
                    if (t1win)
                    {
                        Console.WriteLine("\n" + trainer1.getName() + " heeft gewonnen");
                        trainer2.Return(rInt2);
                    }
                    //Player 1 wint
                    if (t2win)
                    {
                       
                        Console.WriteLine("\n"+trainer2.getName() + " heeft gewonnen");
                        trainer1.Return(rInt1);
                    }
                    Thread.Sleep(1000);
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
