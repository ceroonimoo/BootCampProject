using Core.Exceptions.Types;
using Core.Rules;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ApplicantBusinessRules : BaseBusinessRules
    {
        private readonly IApplicantRepository _applicantRepository;

        public ApplicantBusinessRules(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }

        public void CheckIfTCNoIsUnique(string TC)
        {
            var existingApplicant = _applicantRepository.Get(b => b.Name == name);
            if (existingApplicant != null)
                throw new BusinessException($"{TC} Aynı tc numaralı biri mevcut");
        }
    }
}
