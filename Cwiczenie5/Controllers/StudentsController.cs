using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenie5.DTOs.Requests;
using Cwiczenie5.Models;
using Cwiczenie5.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenie5.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private IStudentsDbService _dbService;

        public StudentsController(IStudentsDbService service)
        {
            _dbService = service;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {

            return Ok(_dbService.GetStudents());

        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(string id)
        {

            return Ok();
        }

    }
}
