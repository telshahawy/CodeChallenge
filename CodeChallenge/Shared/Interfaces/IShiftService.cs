using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge.Shared.Dtos;

namespace CodeChallenge.Shared.Interfaces
{
    public interface IShiftService
    {
        int AddShift(AddShiftDto dto);
        List<ShiftTypeDto> GetShiftTypes();
        List<ShiftDto> GetShifts();
    }
}
