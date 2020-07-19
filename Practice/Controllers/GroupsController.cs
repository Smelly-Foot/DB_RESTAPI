using Microsoft.AspNetCore.Mvc;
using Practice.DataAccess;
using Practice.Models;
using System;
using System.Collections.Generic;

namespace Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public GroupsController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Groups> Get()
        {
            return _dataAccessProvider.GetGroupsRecords();
        }



        [HttpPost]
        public IActionResult Create([FromBody] Groups groups)
        {
            if (ModelState.IsValid)
            {

                _dataAccessProvider.AddGroupsRecord(groups);

                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Groups Details(int id)
        {
            return _dataAccessProvider.GetGroupsSingleRecord(id);
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromBody] Groups groups)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateGroupsRecord(groups);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var data = _dataAccessProvider.GetGroupsSingleRecord(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteGroupsRecord(id);
            return Ok();
        }
    }
}
