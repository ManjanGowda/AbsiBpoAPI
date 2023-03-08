 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Business.Entities
{
    public class MasterEntity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public Int64 RoleID { get; set; }
        public string ModuleID { get; set; }
        public Int64 RoasterID { get; set; }
        public Int64 ManagerID { get; set; }
        public Int64 TeamLeadID { get; set; }
        public Int64 ID { get; set; }


        public string Incident { get; set; }
        public string Description { get; set; }
        public Boolean PerformanceCoaching { get; set; }
        public Boolean ProgressionTracking { get; set; }
        public Boolean Lms { get; set; }

        public Int64 IncidentMasterID { get; set; }
        public string IncidentID { get; set; }

       




    }
}




