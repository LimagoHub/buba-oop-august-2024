using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_01Fehler
{
    public class FehlerKlasse
    {
        public void run()
        {
            try
            {
                runImpl();
            }
            catch (DivideByZeroException fritz)
            {
                Console.WriteLine("yyy"+fritz.Message);
            }
            catch (IndexOutOfRangeException fritz)
            {
                Console.WriteLine("xxx" + fritz.Message);
            }

            Console.WriteLine("Sie haben ein kleines Programm echt glücklich gemacht");

            void runImpl()
            {
                int[] feld = new int [2];
                int a, b, c;

                a = b = 0;

                feld[1000] = 5;
                c = a / b;
            }
        }

       
    }

    
}
