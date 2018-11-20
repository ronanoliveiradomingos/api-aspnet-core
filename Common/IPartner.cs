using Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IPartner
    {
        Task<PartnerOut> Get();

        Task<PartnerOut> Get(int id);

        Task<PartnerOut> Post(PartnerIn value);

        Task<PartnerOut> Put(int id, PartnerIn value);

        Task<PartnerOut> Delete(int id);
    }
}
