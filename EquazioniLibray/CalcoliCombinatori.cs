using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibray
{
    public class CalcoliCombinatori
    {
            public static long Fattoriale(long x)
            {
                if (x == 1)
                {
                    return 1;
                }
                else
                {
                    return x * Fattoriale(x - 1);
                }
            }
        }
    }
}
