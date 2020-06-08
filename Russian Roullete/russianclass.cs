using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete
{
    class russianclass
    {
        // data types described and filled with information
        public int loadchamber;
        public int bulletemiss = 2;
        public int shoot = 6;
        public int bulleteload = 1;

        // chmber with 1 bullets in 6 slots 
        public int chamberspin(int s)
        {
            if (s == 6)
            {
                s = 1;

            }
            else
            {
                s++;
            }

            return s;
        }
        public int Shooter()
        {
            //shoot button property, how it works
            int score = 0;
            if (shoot > 0 && bulleteload == loadchamber)
            {
                score = 1;
            }
            else if (shoot > 0 && loadchamber != bulleteload)
            {
                score = 2;
                shoot = shoot - 1;
                loadchamber = chamberspin(loadchamber);
            }
            return score;
        }
    }
}

