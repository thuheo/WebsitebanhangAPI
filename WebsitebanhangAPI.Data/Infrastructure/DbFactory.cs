using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsitebanhangAPI.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private WebsitebanhangAPIDbContext dbContext;

        public WebsitebanhangAPIDbContext Init()
        {
            return dbContext ?? (dbContext = new WebsitebanhangAPIDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
