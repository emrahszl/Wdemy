﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Entities;

namespace Wdemy.Persistence.Interfaces.Repository
{
    public interface IAdminRepository
    {
        Task<Admin?> GetByIdentityAsync(Guid identityId);
    }
}
