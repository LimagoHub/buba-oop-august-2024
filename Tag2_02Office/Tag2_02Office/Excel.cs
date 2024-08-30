using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace office
{
    public class Excel: IDokument
    {
        public virtual void drucken()
        {
            Console.WriteLine("Hier druckt Excel");
        }
    }
}
