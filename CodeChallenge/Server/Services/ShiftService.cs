using CodeChallenge.Server.Models;
using CodeChallenge.Shared.Dtos;
using CodeChallenge.Shared.Interfaces;

namespace CodeChallenge.Server.Services
{
    public class ShiftService : IShiftService
    {
        private readonly DataContext _dataContext;

        public ShiftService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int AddShift(AddShiftDto dto)
        {
            var shift = new Shift()
            {
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                EmployeeId = dto.EmployeeId,
                ShiftTypeId = dto.ShiftTypeId
            };
            _dataContext.Add(shift);
            _dataContext.SaveChanges();
            return shift.Id;
        }

        public List<ShiftTypeDto> GetShiftTypes()
        {
            return _dataContext.ShiftTypes.Select(c => new ShiftTypeDto()
            {
                Id = c.Id,
                Name = c.Name,
                StartTime = c.StartTime,
                EndTime = c.EndTime,
                BreakPerHourInMin = c.BreakPerHourInMin,
                BreakPerFourHoursInMin = c.BreakPerFourHoursInMin,
            }).ToList();
        }

        public List<ShiftDto> GetShifts()
        {
            return _dataContext.Shifts.Select(c => new ShiftDto()
            {
                Id = c.Id,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                ShiftTypeId = c.ShiftTypeId,
                EmployeeId = c.EmployeeId,
                Employee = new EmployeeDto()
                {
                    Id = c.Employee.Id,
                    Name = c.Employee.Name,
                    CreationDate = c.Employee.CreationDate
                },
                ShiftType = new ShiftTypeDto()
                {
                    Id = c.ShiftType.Id,
                    Name = c.ShiftType.Name,
                    StartTime = c.ShiftType.StartTime,
                    EndTime = c.ShiftType.EndTime,
                    BreakPerHourInMin = c.ShiftType.BreakPerHourInMin,
                    BreakPerFourHoursInMin = c.ShiftType.BreakPerFourHoursInMin,
                },
                TotalBreakMins = 0
            }).ToList();
        }
    }
}
