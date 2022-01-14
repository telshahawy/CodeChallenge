using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Shared.Dtos
{
    public class ShiftDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ShiftTypeId { get; set; }
        public ShiftTypeDto ShiftType { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeDto Employee { get; set; }
        public int TotalBreakMins { get; set; }

    }
}
