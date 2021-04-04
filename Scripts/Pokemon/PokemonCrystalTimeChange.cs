//This code has been adapted from the formula located at
//https://gamefaqs.gamespot.com/gbc/198308-pokemon-gold-version/faqs/12550

using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGen2TimeChange
{
    public static class PokemonCrystal
    {
        public static int ConvertNameToNumber(string name)
        {
            int value = 0;
            for (int i = 0; i < name.Length && i < 5; i++)
            {
                if (name[i] >= 'A' && name[i] <= 'Z')
                {
                    //Ascii A = 65, Z = 90
                    //game A = 128, Z = 153
                    int tmp = (128 - 65) + name[i];
                    value += tmp;
                }
                else if (name[i] >= 'a' && name[i] <= 'z')
                {
                    //Ascii a = 97, z = 122
                    //game a = 160, z = 185
                    int tmp = (160 - 97) + name[i];
                    value += tmp;
                }
            }

            return value;
        }

        public static int ConvertMoneyToNumber(int money)
        {
            int whole = money / 256;
            int remain = money % 256;
            return whole + remain;
        }

        public static int ConvertIDToNumber(int id)
        {
            int whole = id / 256;
            int remainder = id % 256;
            return  whole + remainder;
        }

        public static int GetPassword(string name, int money, int id)
        {
            int res1 = ConvertNameToNumber(name);
            int res2 = ConvertMoneyToNumber(money);
            int res3 = ConvertIDToNumber(id);
            return res1 + res2 + res3;
        }
    }
}
