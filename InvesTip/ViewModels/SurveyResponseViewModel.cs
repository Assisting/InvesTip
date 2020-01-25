using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvesTip.Web.ViewModels
{
    public class SurveyResponseViewModel
    {
        public int YearsToRetirement { get; set; }
        public List<string> Interests { get; set; }
        public int RiskTolerance { get; set; }
    }
}
