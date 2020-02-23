using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTitle.Api.Models;
using WebTitle.Api.Services;


namespace WebTitle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaTitleController : ControllerBase
    {
        private readonly MediaTitleService _titleService;

        public MediaTitleController(MediaTitleService titleService)
        {
            _titleService = titleService;
        }

        // GET: api/MediaTitle
        [HttpGet]
        public ActionResult<List<Title>> Get()
        {
            return _titleService.Get();
        }

        // GET: api/MediaTitle/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        //[HttpGet("{id}", Name = "GetById")]
        [Route("[action]/{id}")]
        [HttpGet]
        public ActionResult<Title> GetById(long id)
        {
            var title = _titleService.GetByTitleId(id);

            if (title == null)
            {
                return NotFound();
            }

            return title;
        }


        [Route("[action]/{name}")]
        [HttpGet]
        public ActionResult<Title> Name(string name)
        {
            var title = _titleService.GetByName(name);

            if (title == null)
            {
                return NotFound();
            }

            return title;
        }

        [Route("[action]/{name}")]
        [HttpGet]
        public ActionResult<List<Title>> Names(string name)
        {
            var titles = _titleService.GetTitlesByName(name);

            if (titles == null || titles.Count == 0)
            {
                return NotFound();
            }

            return titles;
        }

        // POST: api/MediaTitle
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/MediaTitle/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }



    }
}
