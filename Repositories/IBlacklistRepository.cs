﻿using Core;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories
{
    public interface IBlacklistRepository : IGenericRepository<Blacklist>
    {
        Task<Blacklist> GetActiveBlacklistByCandidateIdAsync(int candidateId); 

    }

}
