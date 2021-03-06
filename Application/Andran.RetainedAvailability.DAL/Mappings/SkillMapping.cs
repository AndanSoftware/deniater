﻿using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class SkillMapping : EntityTypeConfiguration<Skill>
    {
        public SkillMapping()
        {
            HasKey(s => s.SkillID);

            ToTable("Link_CrewMember_SkillType");

            HasRequired(s => s.SkillType)
                .WithMany(st => st.Skills)
                .HasForeignKey(s => s.SkillTypeID);

            Property(p => p.ExpiryDate)
                .IsOptional();

            Property(p => p.Reference)
                .IsOptional();
        }
    }
}
