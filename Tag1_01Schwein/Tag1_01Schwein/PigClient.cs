using de.buba.tiere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_01Schwein
{
    public class PigClient
    {

        public void go()
        {
            Schwein piggy;
            Schwein babe;

            Console.WriteLine(Schwein.Counter);

            piggy = new Schwein();
            

                Console.WriteLine(Schwein.Counter);

                piggy.Name = "Miss Piggy";

                Console.WriteLine(piggy.ToString());

                babe = piggy;

                piggy.fuettern();
                Console.WriteLine(babe.ToString());
                piggy.Dispose();
        }
    }
}
