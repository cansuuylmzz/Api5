using Api5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api5.Controllers
{
    public class ProductController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostProduct(Product data)
        {
            if (true)
            {
                return Ok(data);
            }
            return BadRequest(ModelState);
        }
    }
}
