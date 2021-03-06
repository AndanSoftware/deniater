namespace Andran.RetainedAvailability.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Andran.RetainedAvailability.DAL.RetainedAvailabilityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Andran.RetainedAvailability.DAL.RetainedAvailabilityContext context)
        {

            context.UnavailabilityReasons.Add(
                        new Data.Entities.UnavailabilityReason() {
                                Symbol = "W", ColourHex = "00000", Description = "At work", UnavailabilityReasonID = Guid.NewGuid() });


            context.SkillTypes.Add(
                new Data.Entities.SkillType() 
                { Name = "S10 Respirator", Description = "Can operate the s10", SkillTypeID = Guid.NewGuid() });

            var ranks = new Dictionary<string, string> { { "CM", "CrewMember" }};

            foreach (var r in ranks)
            {
                context.Ranks.Add(new Data.Entities.Rank() { Abbreviation = r.Key, Name = r.Value, RankID = Guid.NewGuid() });
            }



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
