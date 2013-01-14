using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.TestDataPopulator
{
    class Program
    {
        public static string[] firstNames = { "Andrew", "Jordan", "Sarah", "Frank", "Bob", "Gemma" };

        public static string[] lastNames = { "Critchley", "Turnbull", "Turner", "Beagle", "Smith", "Roberts", "Jones", "Chelsea" };

        public static string[] stations = { "Hull", "Selby", "York", "Beverly", "Leeds" };

        public static string[] appliances = { "Red", "Big", "Quiet", "Noisy", "Old" };

        public static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.Write("Start date: ");
            DateTime startDateTime = DateTime.Parse(Console.ReadLine());
            Console.Write("End date: ");
            DateTime endDateTime = DateTime.Parse(Console.ReadLine());

            foreach (var station in stations)
            {

            }
        }
    }
}
