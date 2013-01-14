using Andran.RetainedAvailability.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andran.RetainedAvailability.Web.Controllers
{
    public class StationController : Controller
    {
        //
        // GET: /Station/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Overview()
        {
            UnavailabilityRepository repo = new UnavailabilityRepository();

            //THIS IS HOW WE GET THE UAVS grouped by CM:
            var unavailabilityByCrewMember = repo.GetUnavailabilityForADay(Guid.Empty, DateTime.Today).GroupBy(u => u.CrewMember);
           //THIS IS THE CM: unavailabilityByCrewMember.ElementAt(0).Key;
           //THESE ARE THE UAVS FOR THAT CM: unavailabilityByCrewMember.ElementAt(0)
            return View();
        }

    }
}
