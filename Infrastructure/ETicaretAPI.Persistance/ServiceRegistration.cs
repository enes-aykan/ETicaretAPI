using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistance.Concretes;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService,ProductService>();
            //SORU-IOC Container ne ?, 2 kez IProductService tanımladık bu sadece bunu kullan mı diyor ? düzeltti x
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseSqlServer("Data Source=(localdb)\\Local;Initial Catalog=ETicaretAPIDb;User ID=AppUser;Password=1q2w3e4r*;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
        }
    }
}