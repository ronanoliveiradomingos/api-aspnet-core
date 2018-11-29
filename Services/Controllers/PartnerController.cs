using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;

namespace Services.Controllers
{
    [Produces("application/json")]
    [Route("api/partner")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private readonly IPartner _partner;

        public PartnerController(IPartner partner)
        {
            _partner = partner;
        }

        // GET: api/Partner
        [HttpGet]
        public async Task<PartnerOut> Get()
        {
            try
            {
                return await _partner.Get();
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw ex;
            }
        }

        // GET: api/Partner/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<PartnerOut> Get(int id)
        {
            try
            {
                return await _partner.Get(id);
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw ex;
            }
        }

        // POST: api/Partner
        [HttpPost]
        public async Task<PartnerOut> Post([FromBody] PartnerIn value)
        {
            try
            {
                return await _partner.Post(value);
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw ex;
            }
        }

        // PUT: api/Partner/5
        [HttpPut("{id}")]
        public async Task<PartnerOut> Put(int id, [FromBody] PartnerIn value)
        {
            try
            {
                return await _partner.Put(id, value);
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw ex;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<PartnerOut> Delete(int id)
        {
            try
            {
                return await _partner.Delete(id);
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw ex;
            }
        }
    }
}
