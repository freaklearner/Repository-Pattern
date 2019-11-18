using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Interfaces;
using RepositoryPattern.Model;

namespace RepositoryPattern.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProduct Products;
        public ProductController(IProduct product)
        {
            Products = product;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = Products.Get();
            if(data!=null && data.Any())
            {
                return StatusCode(StatusCodes.Status200OK, data);
            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var product = Products.Get(Id);
            if (product != null)
            {
                return StatusCode(StatusCodes.Status200OK, product);
            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            Products.Post(product);
            return StatusCode(StatusCodes.Status201Created);

        }

        [HttpPut("{Id}")]
        public IActionResult Put(int Id,[FromBody] Product product)
        {
            if (product!=null && product.Id == Id)
            {
                Products.Put(product);
                return StatusCode(StatusCodes.Status202Accepted, Id);
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }
        
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            if (Products.Delete(Id))
            {
                return StatusCode(StatusCodes.Status200OK);
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }




    }
}