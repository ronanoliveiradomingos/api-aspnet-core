using Model;
using Model.DTO;
using System;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPartner
    {
        public async Task<Partner> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Partner> Get()
        {
            var parter = new Partner
            {
                Name = "Microsoft",
                LastName = "Corporate",
                Phone = "55 11 95859695",
                Adress = "Av. Paulista",
                City = "Sao Paulo",
                Country = "Brazil"
            };

            return parter;
        }

        public async Task<Partner> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Partner> Post(Partner value)
        {
            throw new NotImplementedException();
        }

        public async Task<Partner> Put(int id, Partner value)
        {
            throw new NotImplementedException();
        }
    }
}
