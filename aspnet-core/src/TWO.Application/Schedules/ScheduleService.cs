using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TWO.Schedules
{
    public class ScheduleService : CrudAppService<Schedule,
        ScheduleDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateScheduleDto, 
        CreateUpdateScheduleDto>, IScheduleService
    {
        public ScheduleService(IRepository<Schedule, Guid> repository) : base(repository)
        {
        }
    }
}
