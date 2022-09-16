using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TWO.Schedules
{
    public class CreateUpdateScheduleDto
    {
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ScheduleDate { get; set; }
    }
}
