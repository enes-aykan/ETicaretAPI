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
    public class CustomerWriteRepository : WriteRepository<Customer>,//Doğrulayıcı : Interface ile çağırıldığında bu repository üzerinden Customer classı çağırılacak.
        ICustomerWriteRepository //Uygulayıcı : Uygularken bu Interface çağırılacak.
    {
        public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context)//CTORDA db context gönderilmeli. Buradan gönderiyoruz.
        {
        }
    }
}
