using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle_sim
{
    class textsettings
    {
        static private int multiplier = 1;
        public static void setSpeedMulitplier(int mult)
        {
            multiplier = mult;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"> input van de text die je langzaam getypt wilt</param>
        /// <param name="ms"> wacht tijd tussen de letters</param>
        /// <param name="newLine"> Enter voor nieuwe line </param>
        /// <param name="waitAtEnd"> Hij wacht ff voor dat je meteen door typt</param>
        public static void SlowWrite(string text, int ms = 50, bool newLine = true, bool waitAtEnd = true)
        {
            ms /= multiplier;
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(ms);
            }
            if (newLine)
            {
                Console.Write("\n");

            }
            if (waitAtEnd)
            {
                Thread.Sleep(ms * 5);
            }
        }
    }
}
