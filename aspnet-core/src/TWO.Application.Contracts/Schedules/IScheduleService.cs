using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace TWO.Schedules
{
    public interface IScheduleService : ICrudAppService<ScheduleDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateScheduleDto,
        CreateUpdateScheduleDto>   
    {

    }
}
