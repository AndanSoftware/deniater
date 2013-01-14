using Andran.RetainedAvailability.DAL.Repositories;
using Andran.RetainedAvailability.Data.Entities;
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

        public static IEnumerable<UnavailabilityReason> unavailabilityReasons;

        public static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.Write("Start date: ");
            DateTime startDateTime = DateTime.Parse(Console.ReadLine());
            Console.Write("End date: ");
            DateTime endDateTime = DateTime.Parse(Console.ReadLine());

            var stationRepo = new StationRepository();

            foreach (var station in stationRepo.GetStations(0, 100))
            {
                stationRepo.DeleteStation(station);
            }

            foreach (var station in stations)
            {
                Console.WriteLine("*****{0}*****", station);
                unavailabilityReasons = new UnavailabilityReasonRepository().GetUnavailabilityReasons(0, 100);

                Station s = new Station();
                s.Name = station;
                s.Postcode = "POST";
                s.Latitude = 100;
                s.Longitude = 100;
                s.StationID = Guid.NewGuid();
                s.CrewMembers = new List<CrewMember>();

                for (int i = 0; i < 10; i++)
                {
                    CrewMember cm = new CrewMember();
                    cm.CrewMemberID = Guid.NewGuid();
                    cm.FirstName = firstNames.ElementAt(rand.Next(0, firstNames.Count()));
                    cm.LastName = lastNames.ElementAt(rand.Next(0, lastNames.Count()));
                    cm.MobileNumber = "0001111";
                    cm.IsDriver = false;
                    cm.StationID = s.StationID;

                    CreateUavForCM(cm, startDateTime, endDateTime);
                    s.CrewMembers.Add(cm);
                    Console.WriteLine("CM {0} for {1}", i, station);
                }
                s.Appliances = new List<Appliance>();
                for (int i = 0; i < 5; i++)
                {
                    var app = new Appliance()
                    {
                        ApplianceID = Guid.NewGuid(),
                        MaximumCrewCapacity = 7,
                        MinimumCrewCount = 3,
                        Name = appliances.ElementAt(rand.Next(0, 4)) + " Truck",
                        StationID = s.StationID
                    };
                    s.Appliances.Add(app);
                }

                stationRepo.InsertStation(s);
            }
            stationRepo.SaveChanges();
        }

        private static void CreateUavForCM(CrewMember cm, DateTime start, DateTime end)
        {
            int hourIncrement = rand.Next(0, 6);
            cm.Unavailabilitys = new List<Unavailability>();
            do
            {
                Unavailability uav = new Unavailability();
                uav.Start = start.AddHours(hourIncrement);
                uav.End = uav.Start.AddHours(rand.Next(0, 6));
                uav.UnavailabilityID = Guid.NewGuid();
                uav.CrewMemberID = cm.CrewMemberID;
                
                uav.UnavailabilityReasonID = unavailabilityReasons.ElementAt(rand.Next(0, unavailabilityReasons.Count())).UnavailabilityReasonID;
                cm.Unavailabilitys.Add(uav);

                hourIncrement += rand.Next(0, 14);
            } while (start.AddHours(hourIncrement) <= end);
        }
    }
}
