using Core.Exceptions.Types;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class BlacklistBusinessRules
    {
        private readonly IBlacklistRepository _blacklistRepository;

        public BlacklistBusinessRules(IBlacklistRepository blacklistRepository)
        {
            _blacklistRepository = blacklistRepository;
        }

        public async Task EnsureNoDuplicateActiveBlacklistAsync(int candidateId)
        {
            var existingActive = await _blacklistRepository.GetActiveBlacklistByCandidateIdAsync(candidateId);
            if (existingActive != null)
            {
                throw new BusinessException("Bu aday için zaten aktif bir kara liste kaydı var.");
            }
        }

        public void EnsureReasonIsNotEmpty(string reason)
        {
            if (string.IsNullOrWhiteSpace(reason))
            {
                throw new BusinessException("Sebep alanı boş bırakılamaz.");
            }
        }
    }

}
