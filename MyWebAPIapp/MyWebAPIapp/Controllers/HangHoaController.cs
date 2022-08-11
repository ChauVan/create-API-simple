using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebAPIapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPIapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        public static List<HangHoa> hh = new List<HangHoa>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hh);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id )
        {
            //LINQ[Object] query
            try
            {
                var hanghoa = hh.SingleOrDefault(hh => hh.maHH == Guid.Parse(id));
                if (hanghoa == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(hanghoa);
                }
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
        [HttpPost]
        public IActionResult Create(HangHoaTGDD hangHoaTGDD)
        {
            var hangHoa = new HangHoa
            {
                maHH = Guid.NewGuid(),
                tenHH = hangHoaTGDD.tenHH,
                DonGia = hangHoaTGDD.DonGia
            };
            hh.Add(hangHoa);
            return Ok(new { Success = true, Data = hangHoa });
        }
        [HttpPut("id")]
        public IActionResult update (string id, HangHoa hang)
        {
             try
            {
                var hanghoa = hh.SingleOrDefault(hh => hh.maHH == Guid.Parse(id));
                if (hanghoa == null)
                {
                    return NotFound();
                }
                else
                {
                    if (id != hanghoa.maHH.ToString() )
                    {
                        return BadRequest();
                    }
                    //Update 
                    hanghoa.tenHH = hang.tenHH;
                    hanghoa.DonGia = hang.DonGia;
                    return Ok(hanghoa);
                }
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
        [HttpDelete("id")]
        public IActionResult deleteHH(string id)
        {
            var hanghoa = hh.SingleOrDefault(hh => hh.maHH == Guid.Parse(id));
            hh.Remove(hanghoa);
            return Ok(new { succcess = true } );

        }
    }
    
}
