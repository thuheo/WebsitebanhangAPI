using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsitebanhangAPI.Data.Infrastructure;
using WebsitebanhangAPI.Model.Models;

namespace WebsitebanhangAPI.Data.Repositories
{
    public interface IProductRepository
    {

    }
    public  class ProductRepository :RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
