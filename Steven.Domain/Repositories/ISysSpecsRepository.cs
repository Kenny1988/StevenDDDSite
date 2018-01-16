﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steven.Domain.Models;
using Steven.Domain.Infrastructure;

namespace Steven.Domain.Repositories
{
    public interface ISysSpecsRepository:IRepository<SysSpecs>
    {
        Pager<SysSpecs> GetPager(string name, PageSearchModel search);

        IEnumerable<string> GetLstName();
    }
}