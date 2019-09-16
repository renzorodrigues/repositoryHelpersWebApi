using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using repohelp.Services;
//using repohelp.Models;

namespace repohelp.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase {
        private readonly ICategoryService _service;
        public CategoriesController (ICategoryService service) {
            this._service = service;
        }

        // GET api/categories
        [HttpGet]
        public ActionResult<IEnumerable<string>> Gets () {
            return Ok (this._service.getAll ());
        }

        // GET api/categories/5
        [HttpGet ("{id}")]
        public ActionResult<string> GetById (int id) {
            return "value" + id;
        }

        // POST api/categories
        [HttpPost ("")]
        public void Post ([FromBody] string value) { }

        // PUT api/categories/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/categories/5
        [HttpDelete ("{id}")]
        public void DeleteById (int id) { }
    }
}