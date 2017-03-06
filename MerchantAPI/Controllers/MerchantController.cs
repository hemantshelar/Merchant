using MerchantDAL;
using MerchantDAL.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MerchantAPI.Controllers
{
    public class MerchantController : ApiController
    {
        UnitOfWork uow = null;

        public MerchantController()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            uow = new UnitOfWork(connectionString);
        }

        public IHttpActionResult Get(string id)
        {
            var result = uow.MerchantRepository.Get(m => m._id == id);
            if (result == null)
                return NotFound();

            return Ok(result.FirstOrDefault());
        }

        public IHttpActionResult Get()
        {
            var result = uow.MerchantRepository.Get();
            return Ok(result);
        }

        [Route("api/Merchant/active")]
        [HttpGet]
        public IHttpActionResult GetAllActive()
        {
            var result = uow.MerchantRepository.Get(m => m.status.ToUpper() == "active".ToUpper());
            if (result == null)
                return NotFound();

            return Ok(result.ToList());
        }

        public IHttpActionResult Post([FromBody] Merchant objMerchant)
        {
            try
            {
                uow.MerchantRepository.Add(objMerchant);
                uow.SaveChanges();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            return Created("api/Merchant/" + objMerchant._id, objMerchant);
        }

        public IHttpActionResult Put([FromBody] Merchant objMerchant)
        {
            try
            {
                uow.MerchantRepository.Update(objMerchant);
                uow.SaveChanges();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok();
        }

        public IHttpActionResult Delete(string id)
        {
            try
            {
                uow.MerchantRepository.Delete( e => e._id.ToUpper() == id.ToUpper());
                uow.SaveChanges();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok();
        }

    }
}
