using Andran.RetainedAvailability.DAL.Mappings;
using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL
{
    public class RetainedAvailabilityContext : DbContext
    {
        public RetainedAvailabilityContext()
            : base("Andran.RetainedAvailability")
        {

        }

        // Entity Tables
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Appliance> Appliances { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<SkillType> SkillTypes { get; set; }
        public DbSet<Watch> Watches { get; set; }
        public DbSet<ApplianceOfflinePeriod> ApplianceOfflinePeriods { get; set; }

        //Data Tables
        public DbSet<Unavailability> Unavailability { get; set; }

        // Link Tables
        public DbSet<Skill> Skills { get; set; }

        // Lookup Tables
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<UnavailabilityReason> UnavailabilityReasons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Add Mapping configurations here

            modelBuilder.Configurations.Add(new ApplianceMapping());
            modelBuilder.Configurations.Add(new CrewMemberMapping());
            modelBuilder.Configurations.Add(new SkillMapping());
            modelBuilder.Configurations.Add(new SkillTypeMapping());
            modelBuilder.Configurations.Add(new StationMapping());
            modelBuilder.Configurations.Add(new UserProfileMapping());
            modelBuilder.Configurations.Add(new WatchMapping());
            modelBuilder.Configurations.Add(new UnavailabilityMapping());
            modelBuilder.Configurations.Add(new UnavailabilityReasonMapping());
            modelBuilder.Configurations.Add(new ApplianceOfflinePeriodMapping());
            modelBuilder.Configurations.Add(new RankMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
