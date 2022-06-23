//using DeliFood.Areas.Admin.Services;
//using DeliFood.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DeliFood.Areas.Admin.Controllers.API
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TestRoleController : ControllerBase
//    {
//        DataContext _context;
//        public TestRoleController(DataContext context)
//        {
//            _context = context;
//        }
//        // GET: api/values
//        [HttpGet]
//        public async Task<IActionResult> GetAll()
//        {
//            return Ok(await _context.Roles.ToListAsync());
//        }
//        //// GET: api/values/{id}
//        //[HttpGet("{id}")]
//        //public Role Get(int id)
//        //{
//        //    return _repository.Get(id);
//        //}

//        //// POST api/values
//        //[HttpPost]
//        //public void Post([FromBody] Role newRole)
//        //{
//        //    _repository.Create(newRole);
//        //}

//        //// PUT api/values/5
//        //[HttpPut("{id}")]
//        //public void Put([FromBody] Role newRole)
//        //{
//        //    _repository.Edit(newRole.RoleId, newRole);
//        //}

//        //// DELETE api/values/5
//        //[HttpDelete("{id}")]
//        //public void Delete(int id)
//        //{
//        //    _repository.Delete(id);
//        //}
//    }
//}
