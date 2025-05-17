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

        public void CheckIfTCNoIsUnique(string Tc)
        {
            var existingApplicant = _applicantRepository.Get(b => b.TC == Tc);
            if (existingApplicant != null)
                throw new BusinessException($"{Tc} tc numaralı biri mevcut");
        }
        public void CheckIfApplicantExists(string Tc)
        {
            var applicant = _applicantRepository.Get(a => a.TC == Tc);
            if (applicant == null)
                throw new BusinessException($"{Tc} numaralı başvuru sahibi sistemde kayıtlı değil.");
        }
        public void CheckIfApplicantIsBlacklisted(string Tc)
        {
            var applicant = _applicantRepository.Get(a => a.TC == Tc);

            if (applicant == null)
                throw new BusinessException($"{Tc} numaralı başvuru sahibi sistemde kayıtlı değil.");

            if (applicant.IsBlacklisted)
                throw new BusinessException($"{Tc} numaralı başvuru sahibi kara listededir. Başvuru yapamaz.");
        }

    }
}
