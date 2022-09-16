using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWO.Schedules;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace TWO.Seeds
{
    public class ScheduleSeeder : IDataSeedContributor, ITransientDependency
    {
        public readonly IRepository<Schedule, Guid> _scheduleRepository;
        public ScheduleSeeder(IRepository<Schedule, Guid> scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(await _scheduleRepository.GetCountAsync() == 0)
            {
                await _scheduleRepository.InsertAsync(new Schedule
                {
                    Description = "Teste 1",
                    ScheduleDate = DateTime.Now
                });
                await _scheduleRepository.InsertAsync(new Schedule
                {
                    Description = "Teste 2",
                    ScheduleDate = DateTime.Now
                });
            }
        }
    }
}
