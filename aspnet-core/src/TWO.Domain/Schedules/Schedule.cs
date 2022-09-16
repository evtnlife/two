using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TWO.Schedules
{
    public class Schedule : AuditedAggregateRoot<Guid>
    {
        public string Description { get; set; }
        public DateTime ScheduleDate { get; set; }
    }
}
