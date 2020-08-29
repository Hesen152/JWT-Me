using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _producService;

        public ProductsController( IProductService productService)
        {
            _producService = productService;
        }

        [HttpGet("getall")]
        [Authorize(Roles ="ProductList")]
        public IActionResult GetList()
        {
            var result = _producService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);

            }

            return BadRequest(result.Message);
        }


        [HttpGet("getlistbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _producService.GetListByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);

            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _producService.GetById(productId);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

         [HttpPost("add")]
         public IActionResult Add(Product product)
        {
         var result= _producService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }


        [HttpPost ("update")]

        public IActionResult Update( Product product)
        {
            var result = _producService.Update(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);

            
        }


        [HttpPost("delete")]

        public IActionResult Delete(Product product)
        {
            var result = _producService.Delete(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);


        }


    }
}