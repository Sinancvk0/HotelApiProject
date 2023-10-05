using Bussines.Abstract;
using Bussines.Concrete;
using DataAccess.Abstract;
using DataAccess.Entity_Framework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Container
{
    public class ExtensionsDb
    {
        public static void ContainerDependecies(IServiceCollection services)
        {
            services.AddScoped<IStaffDal, EfStaff>();
            services.AddScoped<IStaffService, StaffManager>();

            services.AddScoped<IRoomDal, EfRoom>();
            services.AddScoped<IRoomService, RoomManager>();

            services.AddScoped<IServiceDal, EfService>();
            services.AddScoped<IServiceService, ServiceManager>();

            services.AddScoped<ITestimonialDal, EfTestimonial>();
            services.AddScoped<ITestimonialService, TestimonialManager>();

            services.AddScoped<ISubscribeDal, EfSubscribe>();
            services.AddScoped<ISubscribeService, SubscribeManager>();





        }
    }
}
