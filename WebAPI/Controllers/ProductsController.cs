using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//--> Attribute --> Bir class ile ilgili bilgi verme imzalama yöntemidir.
    public class ProductsController : ControllerBase
    {
        //Loosely coupled
        //naming convention
        //IoC Container -- Inversion of Control

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependency chain -- 
            var result = _productService.GetAll();
            if (result.Success==true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
