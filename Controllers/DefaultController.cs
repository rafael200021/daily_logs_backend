using daily_log_api.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace daily_log_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController<T> : ControllerBase where T: class
    {

        public readonly IDefaultService<T> _service;

        public DefaultController(IDefaultService<T> service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet] 
        public async Task<ActionResult> GetAll()
        {

            var entities = await _service.GetAll(); 

            return Ok(entities);

        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var entity = await _service.GetById(id);

            if(entity  == null)
            {
                return NotFound();
            }

            return Ok(entity);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] T entity)
        {

            if(entity == null)
            {
                return BadRequest();
            }

            await _service.Create(entity);


            return CreatedAtAction(nameof(GetById), new { id = entity }, entity);

        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] T entity)
        {
            if (entity == null || id == 0)
            {
                return BadRequest();
            }

            await _service.Update(entity, id);
            return NoContent();
        }
        
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }

    }
}
