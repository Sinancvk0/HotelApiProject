using DataAccess.Abstract;
using DataAccess.Repository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity_Framework
{
    public class EfService : GenericRepository<Service>, IServiceDal
    {
        public EfService(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
