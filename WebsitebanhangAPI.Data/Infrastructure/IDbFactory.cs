
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsitebanhangAPI.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        WebsitebanhangAPIDbContext Init();
    }
}
