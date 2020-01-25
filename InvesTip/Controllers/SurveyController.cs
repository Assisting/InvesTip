using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvesTip.DAL;
using InvesTip.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

namespace InvesTip.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        IRepository _repo;

        public SurveyController(IRepository repo)
        {
            _repo = repo;
        }

        [SwaggerResponse(System.Net.HttpStatusCode.NoContent)]
        [HttpPost("RecordSurveyResponse")]
        public ActionResult RecordSurveyResponse(SurveyResponseViewModel surveyResponseViewModel)
        {
            try
            {
                _repo.RecordSurveyResponse();
            }
            catch
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}