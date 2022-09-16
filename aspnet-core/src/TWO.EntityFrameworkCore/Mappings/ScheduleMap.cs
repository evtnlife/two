using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWO.Schedules;

namespace TWO.Mappings
{
    public class ScheduleMap : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.Property(e => e.Description).HasColumnName("description");
            builder.Property(e => e.ScheduleDate).HasColumnName("scheduleDate");
        }
    }
}
