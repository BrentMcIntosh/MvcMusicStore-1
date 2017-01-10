using MvcMusicStore.Application.Services;
using MvcMusicStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcMusicStore.Presentation.Web.Controllers
{
    [RoutePrefix("api/Store")]
    public class StoreApiController : ApiController
    {
        private StoreApplicationService _storeService = new StoreApplicationService();
        [Route("genre")]
        public IEnumerable<GenreViewModel> Get()
        {
            return _storeService.GetAllGenre();
        }
    }
}
