using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Dto;
using BL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Filters;

namespace TestApp.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ISomeDataService _someDataService;
        public HomeController(ISomeDataService someDataService)
        {
            _someDataService = someDataService;
        }

        [HttpGet("get-all")]
        public ActionResult<List<SomeDataDto>> GetAll()
        {
            try
            {
               return Ok(_someDataService.GetAll());
            }
            catch(Exception ex)
            {
                return BadRequest(new {message = ex.Message});
            }
        }

        [HttpDelete("remove/{id}")]
        public ActionResult Remove([FromRoute] int id)
        {
            try
            {
                _someDataService.Remove(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("update/{id}")]
        public ActionResult Update([FromRoute] int id, SomeDataUpdateDto model)
        {
            try
            {
                _someDataService.Update(model);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("add")]
        public ActionResult Add(SomeDataAddDto model)
        {
            try
            {
                _someDataService.Add(model);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}