﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAspAngular.Common
{
    public interface IUnitOfWorkTransaction: IDisposable
    {
        void Commit();
        void Rollback();
    }
}
