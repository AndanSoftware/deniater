using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPrototype
{
    class Program
    {
        static void Main(string[] args)
        {

            RAEntities r = new RAEntities();

            foreach(var rr in r.LT_UnavailabilityReason)
            {
                Console.WriteLine(rr.Symbol + " = " + rr.Reason);
            }
            Console.ReadKey();
        }
    }
}
