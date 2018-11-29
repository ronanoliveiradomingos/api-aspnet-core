using Common;
using Model.DTO;
using System;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPartner : IPartner
    {
        public async Task<PartnerOut> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PartnerOut> Get()
        {
            var parter = new PartnerOut
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

        public async Task<PartnerOut> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PartnerOut> Post(PartnerIn value)
        {
            throw new NotImplementedException();
        }

        public async Task<PartnerOut> Put(int id, PartnerIn value)
        {
            throw new NotImplementedException();
        }
    }
}
