using Andran.RetainedAvailability.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Andran.RetainedAvailability.Web.Models.ViewModels;
using Andran.RetainedAvailability.Data.Entities;

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
            var viewModel = new AvailabilityTimetableViewModel();

            viewModel.StationID = new Guid();

            using (var cmRepo = new CrewMemberRepository())
            {
                viewModel.CrewMembersForStation = cmRepo.GetCrewMembersByStationID(viewModel.StationID);
            }

            using (var repo = new UnavailabilityRepository())
            {
                //THIS IS HOW WE GET THE UAVS grouped by CM:
                var grouped = repo.GetUnavailabilityForADay(viewModel.StationID, DateTime.Today).GroupBy(x => x.CrewMember);
                foreach (var cm in viewModel.CrewMembersForStation)
                {
                    cm.Unavailabilitys = grouped.Where(p => p.Key == cm).SelectMany(p => p).ToList();
                    
                }
                //THIS IS THE CM: unavailabilityByCrewMember.ElementAt(0).Key;
                //THESE ARE THE UAVS FOR THAT CM: unavailabilityByCrewMember.ElementAt(0)
            }

            return View(viewModel);
        }

    }
}
