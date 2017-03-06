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
        public IHttpActionResult Get(string id)
        {
            UnitOfWork uow = new UnitOfWork();
            var result = uow.MerchantRepository.Get(m => m._id == id);
            if (result == null)
                return NotFound();

            return Ok(result.FirstOrDefault());
        }

        public IHttpActionResult Get()
        {
            return Ok("test");
        }

    }
}
