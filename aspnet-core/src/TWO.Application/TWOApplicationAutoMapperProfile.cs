using AutoMapper;
using TWO.Schedules;

namespace TWO;

public class TWOApplicationAutoMapperProfile : Profile
{
    public TWOApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Schedule, ScheduleDto>();
        CreateMap<CreateUpdateScheduleDto, Schedule>();
    }
}
