using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class UserProfileRepository
    {
        private RetainedAvailabilityContext _ctx;

        public UserProfileRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }
    }
}
