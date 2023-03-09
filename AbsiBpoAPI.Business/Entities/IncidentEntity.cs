using AbsiBpoAPI.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Business.Entities
{
    public class IncidentEntity
    {


        public Int64 ID { get; set; }
        public string IncidentID { get; set; }
        public Int64 EmployeeID { get; set; }
        public Int64 ManagerID { get; set; }
        public DateTime IncidentDate { get; set; }
        public string Description { get; set; }
        public Int64 StatusID { get; set; }
        public Int64 RoleID { get; set; }
        public string Location { get; set; }
        public string SpecificArea { get; set; }
        public DateTime IncidentTime { get; set; }

        public Int64 IncidentMasterID { get; set; }

        public string Short { get; set; }
        public Int64 ShiftTypeMasterID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}