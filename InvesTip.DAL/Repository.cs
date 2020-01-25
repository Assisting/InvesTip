using System;

namespace InvesTip.DAL
{
    public interface IRepository
    {
        // Go ahead and mutate the interface however you need to
        public void RecordSurveyResponse();
    }
    public class Repository : IRepository
    {
        public void RecordSurveyResponse()
        {
            throw new NotImplementedException();
        }
    }
}
