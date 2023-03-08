using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Business.Entities
{
    public class AssessmentEntity
    {

        public Int64 ID { get; set; }
        public string AssessmentName { get; set; }
        public string AssessmentDescription { get; set; }
        public string Duration { get; set; }
        public string PassedPercentage { get; set; }
        public string NumberOfQuestion { get; set; }
        public string NumberOfMaterials { get; set; }

        public Int64 AssessmentID { get; set; }
        public Int64 QuestionTypeID { get; set; }
        public string Question { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        public string OptionFour { get; set; }
        public string CorrectOption { get; set; }
        public string AttachmentURL { get; set; }

        public string Size { get; set; }
        public string MaterialType { get; set; }

        public string Name { get; set; }


    }
}
