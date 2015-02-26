﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class BaseManager
    {
        protected UnitOfWork uof;

        public BaseManager(UnitOfWork uof)
        {
            this.uof = uof;
        }
    }
}
