using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Shared.Dtos
{
    public class ShiftTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int BreakPerHourInMin { get; set; }
        public int BreakPerFourHoursInMin { get; set; }
    }
}
