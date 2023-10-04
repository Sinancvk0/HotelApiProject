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
    public class EfSubscribe : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribe(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
