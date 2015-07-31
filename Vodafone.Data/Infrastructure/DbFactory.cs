﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vodafone.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        VodafoneEntities dbContext;

        public VodafoneEntities Init()
        {
            return dbContext ?? (dbContext = new VodafoneEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
