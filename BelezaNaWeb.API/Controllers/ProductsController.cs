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

        [HttpGet("{sku}")]
        public ActionResult Get(int sku, [FromServices] IProdutcsServices service)
        {
            return Ok(service.GetProductBySku(sku));
        }

        [HttpPost]
        public ActionResult Create([FromServices] IProdutcsServices service, [FromBody] Products products)
        {
            if (ModelState.IsValid)
            {                 
                return Created("",service.CreateProduct(products));
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpPut("{sku}")]
        public ActionResult Update(int sku,[FromServices] IProdutcsServices service, [FromBody] Products products)
        {
            if (ModelState.IsValid)
            {
                return Ok(service.EditProduct(sku,products));
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpDelete("{sku}")]
        public ActionResult Delete(int sku, [FromServices] IProdutcsServices service)
        {
            return Ok(service.DeleteProductBySku(sku));
        }


    }
}
