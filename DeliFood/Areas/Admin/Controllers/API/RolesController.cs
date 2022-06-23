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
//    public class RolesController : ControllerBase
//    {
//          IRolesRepository _repository;
//        public RolesController(IRolesRepository repo)
//        {
//            _repository = repo;
//        }
//        // GET: api/values
//        [HttpGet]
//        public IList<Role> GetAll()
//        {
//            return _repository.GetAll();
//        }
//        // GET: api/values/{id}
//        [HttpGet("{id}")]
//        public Role Get(int id)
//        {
//            return _repository.Get(id);
//        }

//        // POST api/values
//        [HttpPost]
//        public void Post([FromBody] Role newRole)
//        {
//            _repository.Create(newRole);
//        }

//        // PUT api/values/5
//        [HttpPut("{id}")]
//        public void Put([FromBody] Role newRole)
//        {
//            _repository.Edit(newRole.RoleId, newRole);
//        }

//        // DELETE api/values/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//            _repository.Delete(id);
//        }
//    }
//}
