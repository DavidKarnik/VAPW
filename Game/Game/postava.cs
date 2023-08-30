using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class postava
    {
        //
        //
        // ----------------------------------------------------------------
        //
        string jmeno;
        int zivoty = 100;
        int umeniBoje = 0;
        Random rnd = new Random();
        Boolean canFight = true;

        public postava(string _jmeno)
            {
                jmeno = _jmeno;
            }
            
        public postava(string _jmeno, int _zivoty, int _umeniBoje)
        {
            jmeno = _jmeno;
            zivoty = _zivoty;
            umeniBoje = _umeniBoje;
        }

        public void attack(postava bb) {
            int down = rnd.Next(1, 10);
            if(zivoty > 0)
            {
                canFight = true;
            }
            if(bb.zivoty > 0)
            {
                bb.canFight = true;
            }
            if (canFight)
            {
                if (down >= bb.zivoty)
                {
                    bb.zivoty = 0;
                    bb.canFight = false;
                } else {
                    bb.zivoty -= (down+umeniBoje);
                }
            }
        }

        public string getHP()
        {
            return zivoty.ToString();
        }

        public void setHP(int _zivoty)
        {
            zivoty = _zivoty;
        }



        public static void main(string[] args)
        {
            postava hrac1 = new postava("hrac1");

            postava hrac2 = new postava("hrac2");

        }
    }
}
