﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dewei.IDAL
{
    public partial interface IDbSession
    {
        int SaveChanges();
    }
}
