using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vodafone.Data.Infrastructure;
using Vodafone.Model.Models;

namespace Vodafone.Data.Repositories
{
    public class SubCategoryRepository : RepositoryBase<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
    public interface ISubCategoryRepository : IRepository<SubCategory>
    {

    }
}
