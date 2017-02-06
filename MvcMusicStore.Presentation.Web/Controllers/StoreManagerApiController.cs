using MvcMusicStore.Application.Interfaces;
using MvcMusicStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcMusicStore.Presentation.Web.Controllers
{
    [RoutePrefix("api/StoreManager")]
    public class StoreManagerApiController : ApiController
    {
        IStoreManagerApplicationService _service;

       
        public StoreManagerApiController(IStoreManagerApplicationService service)
        {
            _service = service;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("AddGenre")]
        [HttpPost]
        public HttpResponseMessage Genre(GenreViewModel genre)
        {
            if (ModelState.IsValid)
            {
                _service.AddGenre(genre);
                return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
            }
            else
                return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest };

        }
     
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}