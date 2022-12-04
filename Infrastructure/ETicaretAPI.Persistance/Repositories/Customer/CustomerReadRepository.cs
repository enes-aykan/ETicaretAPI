using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer> //Doğrulayıcı
        , ICustomerReadRepository // (Uygulayıcı)
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context) //CTORDA db context gönderilmeli. Buradan gönderiyoruz.
        {
        }
    }
}
