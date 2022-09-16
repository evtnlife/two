using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace TWO.Schedules
{
    public class ScheduleDto : AuditedEntityDto<Guid>
    {
        public string Description { get; set; }
        public DateTime ScheduleDate { get; set; }
    }
}
