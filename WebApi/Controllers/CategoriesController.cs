﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController( ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _categoryService.GetList();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int categoryId)
        {
            var result = _categoryService.GetById(categoryId);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("getlistbycategory")]
         public IActionResult GetListByCategory(int categoryId)
        {
            var result = _categoryService.GetListByCategory(categoryId);

            if (result.Success)
            {
                return Ok(result.Data);

            }

            return BadRequest(result.Message);
        }

        [HttpGet("add")]

        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);

            if (result.Success)
            {
                return Ok(result.Message);
            }


            return BadRequest(result.Message);


        }
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);

            if (result.Success)
            {
                return Ok(result.Message);
            }


            return BadRequest(result.Message);


        }
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);

            if (result.Success)
            {
                return Ok(result.Message);
            }


            return BadRequest(result.Message);


        }



    }
}