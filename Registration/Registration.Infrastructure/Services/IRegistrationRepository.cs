using Registration.Core;
using Registration.Core.Models;
using System.Collections.Generic;

namespace Registration.Infrastructure.Repositories
{
    public interface IRegistrationRepository
    {
        IEnumerable<QuestionModel> GetQuestions();
        void SubmitAnswers(IEnumerable<QuestionModel> answers);
        void SaveChanges();
       
    }
}