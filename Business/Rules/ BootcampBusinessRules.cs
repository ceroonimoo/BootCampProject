using Core.Exceptions.Types;
using Core.Rules;
using Entities.Enums;
using Repositories;
using System;

namespace Business.Rules
{
    public class BootcampBusinessRules : BaseBusinessRules
    {
        private readonly IBootcampRepository _bootcampRepository;
        private readonly IInstructorRepository _instructorRepository;

        public BootcampBusinessRules(
            IBootcampRepository bootcampRepository,
            IInstructorRepository instructorRepository)
        {
            _bootcampRepository = bootcampRepository;
            _instructorRepository = instructorRepository;
        }

        public void CheckIfStartDateBeforeEndDate(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate)
                throw new BusinessException("Bootcamp başlangıç tarihi, bitiş tarihinden önce olmalıdır.");
        }

        public void CheckIfBootcampNameIsUnique(string name)
        {
            var existingBootcamp = _bootcampRepository.Get(b => b.Name == _
