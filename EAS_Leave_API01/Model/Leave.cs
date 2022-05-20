using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAttendanceSystem.Models
{
    public class Leave
    {
        [Key]
        public string LeaveId { get; set; }

        public string LeaveApplyDate { get; set; }

        public string LeaveStartDate { get; set; }

        public string LeaveEndDate { get; set; }

        public string LeaveReason { get; set; }

        
        

    }
}