using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class SkillTypeMapping : EntityTypeConfiguration<SkillType>
    {
        public SkillTypeMapping()
        {
            HasKey(s => s.SkillTypeID);

            Property(st => st.Name)
                .IsRequired()
                .HasMaxLength(20);

            Property(st => st.Description)
                .HasMaxLength(100);
        }
    }
}
