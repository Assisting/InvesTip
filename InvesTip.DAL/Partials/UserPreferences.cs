using System;
using System.Collections.Generic;
using System.Text;

namespace InvesTip.DAL.Partials
{
    partial class UserPreferences
    {
        public int ID;
        public int UserID;
        public string Question1Answer;
        public string Question2Answer;
        public string Question3Answer;
        public string Question4Answer;

        public int RiskTolerance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<string> IndustryInterstests
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string AgeGroup
        {
            get
            {
                throw new NotImplementedException();
            }
        }

    }
}
