using Microsoft.AspNetCore.Mvc;
using Practice.DataAccess;
using Practice.Models;
using System;
using System.Collections.Generic;

namespace Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public StudentsController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Students> Get()
        {
            return _dataAccessProvider.GetStudentsRecords();
        }



        [HttpPost]
        public IActionResult Create([FromBody] Students students)
        {
            if (ModelState.IsValid)
            {

                _dataAccessProvider.AddStudentsRecord(students);

                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Students Details(int id)
        {
            return _dataAccessProvider.GetStudentsSingleRecord(id);
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromBody] Students students)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateStudentsRecord(students);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var data = _dataAccessProvider.GetStudentsSingleRecord(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteStudentsRecord(id);
            return Ok();
        }
    }
}
