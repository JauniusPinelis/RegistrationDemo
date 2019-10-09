using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Registration.Core.Models;
using Registration.Infrastructure.Repositories;

namespace Registration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationsController : ControllerBase
    {
        private IRegistrationRepository _registrationRepository;

        public RegistrationsController( IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<QuestionModel>> GetQuestions()
        {
            var output = _registrationRepository.GetQuestions();
            return Ok(output);
        }

        [HttpPost]
        public ActionResult SubmitAnswers([FromBody] IEnumerable<QuestionModel> answers)
        {
            _registrationRepository.SubmitAnswers(answers);
            _registrationRepository.SaveChanges();
            return Ok();
        }
    }
}
