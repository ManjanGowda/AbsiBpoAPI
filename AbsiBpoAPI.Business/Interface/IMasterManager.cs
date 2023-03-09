using AbsiBpoAPI.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Business.Interface
{
    public interface IMasterManager
    {


        
        IEnumerable<dynamic> GetStaff();
        IEnumerable<dynamic> GetStaffByID(object filter);
        Int64 InsertStaff(MasterEntity MasterEntity);
        Int64 UpdateStaff(MasterEntity Entity);
        Int64 DeleteStaff(object filter);


        
        IEnumerable<dynamic> GetIncidentMaster();
        IEnumerable<dynamic> GetIncidentMasterByID(object filter);
        Int64 InsertIncidentMaster(MasterEntity MasterEntity);
        Int64 UpdateIncidentMaster(MasterEntity Entity);
        Int64 DeleteIncidentMaster(object filter);



        IEnumerable<dynamic> GetRoasterMaster();
        IEnumerable<dynamic> GetModuleMaster();
        IEnumerable<dynamic> GetQuestionTypeMaster();
        IEnumerable<dynamic> GetRoleMaster();


        IEnumerable<dynamic> GetIncidents();
        IEnumerable<dynamic> GetIncidentsByID(object filter);
        Int64 InsertIncidents(IncidentEntity IncidentEntity);
        Int64 UpdateIncidents(IncidentEntity IncidentEntity);
        Int64 DeleteIncidents(object filter);


        IEnumerable<dynamic> GetIncidentStatusMaster();

        IEnumerable<dynamic> ValidateStaffLogin(object filter);

        IEnumerable<dynamic> InsertStaffModuleMapping(object filter);



        
        IEnumerable<dynamic> GetRoasterMasterByID(object filter);
        Int64 InsertRoasterMaster(IncidentEntity IncidentEntity);
        Int64 UpdateRoasterMaster(IncidentEntity IncidentEntity);
        Int64 DeleteRoasterMaster(object filter);


        IEnumerable<dynamic> GetAssessment();
        Int64 InsertAssessment(AssessmentEntity AssessmentEntity);
        Int64 UpdateAssessment(AssessmentEntity AssessmentEntity);
        Int64 DeleteAssessment(object filter);


        IEnumerable<dynamic> GetAssessmentQuestion();
        Int64 InsertAssessmentQuestion(AssessmentEntity AssessmentEntity);
        Int64 UpdateAssessmentQuestion(AssessmentEntity AssessmentEntity);
        Int64 DeleteAssessmentQuestion(object filter);


        IEnumerable<dynamic> GetAssessmentMaterial();
        IEnumerable<dynamic> GetAssessmentMaterialByID(object filter);
        Int64 InsertAssessmentMaterial(AssessmentEntity AssessmentEntity);
        Int64 UpdateAssessmentMaterial(AssessmentEntity AssessmentEntity);
        Int64 DeleteAssessmentMaterial(object filter);

        IEnumerable<dynamic> GetAssessmentByID(object filter);


    }
}
