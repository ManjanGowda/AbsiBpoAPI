using AbsiBpoAPI.Business.Interface;
using AbsiBpoAPI.Data.Interface;

namespace AbsiBpoAPI.Business.Managers
{
    public class ProgressionTrackingManager : IProgressionTrackingManager
    {
        public IProgressionTrackingRepository IProgressionTrackingRepository;
        public ProgressionTrackingManager(IProgressionTrackingRepository progressionTrackingRepository)
        {
            this.IProgressionTrackingRepository = progressionTrackingRepository;
        }
    }
}


