
using EmployeeAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.Services.LeaveServices
{
    public class LeaveService : ILeaveService
    {
        public static readonly List<Leave> leaves = new List<Leave>()
        {
            new Leave {LeaveId ="L1",LeaveApplyDate="25-04-2022",LeaveStartDate="28-04-2022",LeaveEndDate="03-05-2022", LeaveReason= "OutOfstation" },

            new Leave {LeaveId ="L2",LeaveApplyDate="19-02-2022",LeaveStartDate="21-02-2022",LeaveEndDate ="22-02-2022", LeaveReason="Fever"},
        };


        public async Task<Leave> CreateLeave(Leave leaveObj)
        {
           leaves.Add(leaveObj);
           
            return leaveObj;
        }

        public async Task<Leave> DeleteLeave(string leaveId)
        {
            var result = leaves.SingleOrDefault(a => a.LeaveId == leaveId);
            if (result != null)
            {
                leaves.Remove(result);
                
            }
            return result;
        }

        public async Task<Leave> GetLeaveById(string leaveId)
        {
            return leaves.SingleOrDefault(a => a.LeaveId == leaveId);
        }

        public async Task<IEnumerable<Leave>> GetLeaves()
        {
            return leaves;
        }

        public async Task<Leave> UpdateLeave(Leave leaveObj)
        {
            var result = leaves.SingleOrDefault(a => a.LeaveId == leaveObj.LeaveId);

            if (result != null)
            {
                result.LeaveId = leaveObj.LeaveId;
                result.LeaveReason = leaveObj.LeaveReason;
                result.LeaveApplyDate = leaveObj.LeaveApplyDate;
                result.LeaveStartDate = leaveObj.LeaveStartDate;
                result.LeaveEndDate = leaveObj.LeaveEndDate;

                return result;
            }
            return null;
        }
    }
}
