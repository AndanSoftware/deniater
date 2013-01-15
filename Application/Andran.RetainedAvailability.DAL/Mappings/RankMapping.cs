using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class RankMapping : EntityTypeConfiguration<Rank>
    {
        public RankMapping()
        {
            HasKey(r => r.RankID);

            ToTable("LT_Rank");

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.Abbreviation)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
