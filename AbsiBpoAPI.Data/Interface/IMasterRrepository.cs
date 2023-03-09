using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Data.Interface
{
    public interface IMasterRrepository
    {

        IEnumerable<T> GetStaff<T>();
        IEnumerable<T> GetStaffByID<T>(object filter);
        Int64 InsertStaff(object filter);
        Int64 UpdateStaff(object filter);
        Int64 DeleteStaff(object filter);


        IEnumerable<T> GetIncidentMaster<T>();
        IEnumerable<T> GetIncidentMasterByID<T>(object filter);
        Int64 InsertIncidentMaster(object filter);
        Int64 UpdateIncidentMaster(object filter);
        Int64 DeleteIncidentMaster(object filter);



        IEnumerable<T> GetModuleMaster<T>();
        IEnumerable<T> GetQuestionTypeMaster<T>();
        IEnumerable<T> GetRoleMaster<T>();
        IEnumerable<T> GetRoasterMaster<T>();


        IEnumerable<T> GetIncidents<T>();
        IEnumerable<T> GetIncidentsByID<T>(object filter);
        Int64 InsertIncidents(object filter);
        Int64 UpdateIncidents(object filter);
        Int64 DeleteIncidents(object filter);


        IEnumerable<T> GetIncidentStatusMaster<T>();

        IEnumerable<T> ValidateStaffLogin<T>(object filter);
        IEnumerable<T> InsertStaffModuleMapping<T>(object filter);



        
        IEnumerable<T> GetRoasterMasterByID<T>(object filter);
        Int64 InsertRoasterMaster(object filter);
        Int64 UpdateRoasterMaster(object filter);
        Int64 DeleteRoasterMaster(object filter);



        IEnumerable<T> GetAssessment<T>();
        Int64 InsertAssessment(object filter);
        Int64 UpdateAssessment(object filter);
        Int64 DeleteAssessment(object filter);


        IEnumerable<T> GetAssessmentQuestion<T>();
        Int64 InsertAssessmentQuestion(object filter);
        Int64 UpdateAssessmentQuestion(object filter);
        Int64 DeleteAssessmentQuestion(object filter);



        IEnumerable<T> GetAssessmentMaterial<T>();
        IEnumerable<T> GetAssessmentMaterialByID<T>(object filter);
        Int64 InsertAssessmentMaterial(object filter);
        Int64 UpdateAssessmentMaterial(object filter);
        Int64 DeleteAssessmentMaterial(object filter);

        IEnumerable<T> GetShiftTypeMaster<T>();
        IEnumerable<T> GetShiftTypeMasterByID<T>(object filter);
    }
}
