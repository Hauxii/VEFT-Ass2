using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("/api/courses")]
    public class CoursesController : Controller
    {
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok();
        }    

        [HttpPost]
        public IActionResult AddCourse()
        {
            return StatusCode(201);
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetCourseByID")]
        public IActionResult GetCourseByID()
        {
            return Ok();
        }
        
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult EditCourse()
        {
            return Ok();
        }

        
    
    
    }


}