using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Shared.Dtos
{
    public class AddShiftDto
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int ShiftTypeId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
    }
}
