using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab3.V3.Lib
{
    public class DataService
    {
        public bool GetPointShape(int x, int y)
        {
            bool res;
            if (
                ((x == 3) && (y >= 3 && y <= 7 || y == 11))

                || ((x == 4) && (y >= 3 && y <= 13))

                || ((x == 5) && (y >= 3 && y <= 13))

                || ((x == 6) && (y >= 5 && y <= 8) || (y >= 12 && y <= 13))

                || ((x == 7) && (y >= 5 && y <= 8))

                || ((x == 8) && (y >= 5 && y <= 8))

                || ((x == 9) && (y >= 3 && y <= 8))

                || ((x == 10) && (y >= 3 && y <= 12))

                || ((x == 11) && (y >= 3 && y <= 11))

                || ((x == 12) && (y >= 3 && y <= 11))

                || ((x == 13) && (y >= 6 && y <= 8))
                
                )
            {
                res = true;
            }

            else
            {
                res = false;
            }

            return res;
        }
    }
}
