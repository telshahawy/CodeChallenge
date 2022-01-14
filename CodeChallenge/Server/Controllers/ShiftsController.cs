using CodeChallenge.Shared.Dtos;
using CodeChallenge.Shared.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallenge.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShiftsController : ControllerBase
    {
        private readonly IShiftService _shiftService;

        public ShiftsController(IShiftService shiftService)
        {
            _shiftService = shiftService;
        }

        [HttpGet]
        public List<ShiftDto> Get()
        {
            return _shiftService.GetShifts();
        }
        [HttpPost]
        public int AddShift(AddShiftDto dto)
        {
            return _shiftService.AddShift(dto);
        }

        [HttpGet]
        [Route("GetShiftTypes")]
        public List<ShiftTypeDto> GetShiftTypes()
        {
            return _shiftService.GetShiftTypes();
        }
    }
}
