using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Delete(T t)
        {
            _appDbContext.Remove(t);
        }

        public T GetById(int id)
        {
            return _appDbContext.Set<T>().Find(id);  
        }

        public List<T> GetList()
        {
          return _appDbContext.Set<T>().ToList();   
        }

        public void Insert(T t)
        {
         _appDbContext.Add(t);
        }

        public void Update(T t)
        {
           _appDbContext.Update(t);
        }
    }
}
