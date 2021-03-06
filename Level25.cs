using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1Space
{
    class Level25
    {
        public static bool white_walkers(string village)
        {
            if (village.Length < 4)
            {
                return false;
            }
            for (int i = 0; i < village.Length - 4; i++)
            {
                if (char.IsDigit(village[i]) == true)
                {
                    for (int j = i + 4; j < village.Length; j++)
                    {
                        if (char.IsDigit(village[j]) == true)
                        {
                            if ((int.Parse(village[i].ToString()) + int.Parse(village[j].ToString())) >= 10)
                            {
                                for (int h = i + 1; h <= j - 3; h++)
                                {
                                    if (village[h] == '=' && village[h + 1] == '=' && village[h + 2] == '=')
                                    {
                                        return true;
                                    }

                                }
                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}
