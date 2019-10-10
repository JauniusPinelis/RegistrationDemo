using Registration.Core;
using Registration.Core.Models;
using System.Collections.Generic;

namespace Registration.Infrastructure.Repositories
{
    public interface IRegistrationRepository
    {

        IEnumerable<QuestionDto> GetQuestions();
        void SubmitAnswers(IEnumerable<QuestionDto> answers);
        void SaveChanges();
       
    }
}