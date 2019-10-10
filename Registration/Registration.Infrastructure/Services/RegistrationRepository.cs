using Registration.Core;
using Registration.Infrastructure.Db;
using System.Linq;
using AutoMapper;
using Registration.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Registration.Infrastructure.Entities;

namespace Registration.Infrastructure.Repositories
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private RegistrationContext _context;
        private IMapper _mapper;

        public RegistrationRepository(RegistrationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<QuestionDto> GetQuestions()
        {
            var questions = _context.Questions.Include(q => q.Dropdown).ThenInclude(d => d.SelectFields);
            return _mapper.Map<List<QuestionDto>>(questions);
        }

        public void SubmitAnswers(IEnumerable<QuestionDto> answers)
        {
            answers.ToList().ForEach(prop => UpdateAnswer(prop));
            _context.SaveChanges();
        }

        private void UpdateAnswer(QuestionDto question)
        {
            var entity = _context.Questions.SingleOrDefault(q => q.Id == question.Id);
            if (entity != null)
            {
                entity.Value = question.Value;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

       
    }
}
