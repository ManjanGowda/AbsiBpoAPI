using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Business.Entities
{
    public class PerformanceCoachingEntity
    {
        public Int64 ID { get; set; }
        public Int64 EmployeeID { get; set; }
        public DateTime CoachingDate { get; set; }
        public DateTime CoachingTime { get; set; }
        public Int64 CoachingTemplateID { get; set; }
        public string Status { get; set; }

        public string TemplateID { get; set; }
        public string TemplateLogs { get; set; }
    }
}
