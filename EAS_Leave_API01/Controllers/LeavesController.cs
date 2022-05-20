using EmployeeAttendanceSystem.Models;
using EmployeeAttendanceSystem.Services.LeaveServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase
    {
        private readonly ILeaveService _leaveService;

        public LeavesController(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }


        [HttpGet]
        [Route("api/[controller]/GetLeaves")]
        public async Task<ActionResult<IEnumerable<Leave>>> GetLeaves()
        {
            return (await _leaveService.GetLeaves()).ToList();
        }

        [HttpGet]
        [Route("api/[controller]/GetLeave/{id}")]
        public async Task<ActionResult<Leave>> GetLeaveById(string id)
        {
            var result = await _leaveService.GetLeaveById(id);
            return result;
        }

        [HttpPost]
        [Route("api/[controller]/CreateLeave")]
        public async Task<ActionResult<Leave>> CreateLeave(Leave leaveObj)
        {
            var leaveCreate = await _leaveService.CreateLeave(leaveObj);
            return leaveCreate;
        }

        [HttpPut]
        [Route("api/[controller]/UpdateLeave")]
        public async Task<ActionResult<Leave>> UpdateLeave(Leave leaveObj)
        {
            var leaveUpdate = await _leaveService.UpdateLeave(leaveObj);
            return leaveUpdate;
        }

        [HttpDelete]
        [Route("api/[controller]/DeleteLeave/{id}")]
        public async Task<ActionResult<Leave>> DeleteLeave(string id)
        {
            var leavedelete = await _leaveService.DeleteLeave(id);
            return leavedelete;
        }
    }
}
