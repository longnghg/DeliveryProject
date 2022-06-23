using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliFood.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        public static List<HangHoa> hangHoas = new List<HangHoa>();
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var hanghoa = new HangHoa
            {
                MaHH = 2,
                TenHangHoa = "SLog2"
            };
            var hanghoa1 = new HangHoa
            {
                MaHH = 1,
                TenHangHoa = "SLog1"
            };
            hangHoas.Add(hanghoa);
            hangHoas.Add(hanghoa1);
            return Ok(hangHoas);
        }
        // GET: api/values/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            
            return Ok(hangHoas.Where(x=> x.MaHH == id).FirstOrDefault());
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] HangHoaVM hangHoa)
        {
            HangHoa hangHoa1 = new HangHoa
            {
                MaHH = hangHoa.MaHH,
                TenHangHoa = "Longkute"
            };
            hangHoas.Add(hangHoa1);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody]HangHoa newhanghoa)
        {
            var oldHanghoa = hangHoas.Where(x => x.MaHH == newhanghoa.MaHH).FirstOrDefault();
            oldHanghoa.TenHangHoa = newhanghoa.TenHangHoa;
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
