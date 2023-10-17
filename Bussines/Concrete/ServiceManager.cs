using Bussines.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _service;

        public ServiceManager(IServiceDal service)
        {
            _service = service;
        }

        public void TDelete(Service t)
        {
           _service.Delete(t);
        }

        public Service TGetById(int id)
        {
         return _service.GetById(id);   
        }

        public List<Service> TGetList()
        {
          return _service.GetList();    
        }

        public void TInsert(Service t)
        {
         _service.Insert(t);
        }

        public void TUpdate(Service t)
        {
          _service.Update(t);   
        }
    }
}
