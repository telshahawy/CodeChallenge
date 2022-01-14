using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeChallenge.Server.Models
{
    public class ShiftType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int BreakPerHourInMin { get; set; }
        public int BreakPerFourHoursInMin { get; set; }
    }
}
