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
            : base("Andan.RetainedAvailability")
        {

        }

        // Tables
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Appliance> Appliances { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillType> SkillTypes { get; set; }
        public DbSet<Watch> Watches { get; set; }

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

            base.OnModelCreating(modelBuilder);
        }
    }
}
