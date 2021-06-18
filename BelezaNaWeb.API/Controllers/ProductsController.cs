using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BelezaNaWeb.Model;
using BelezaNaWeb.Model.Interfaces;
using BelezaNaWeb.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BelezaNaWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new { working = "ok" });
        }


        [HttpPost]
        public ActionResult Create([FromServices] IProdutcsServices service, [FromBody] Products products)
        {
            if (ModelState.IsValid)
            {                 
                return Ok(service.CreateProduct(products));
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
