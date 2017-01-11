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
    [RoutePrefix("api/Store")]
    public class StoreApiController : ApiController
    {
        private IStoreApplicationService _storeService;

        public StoreApiController(IStoreApplicationService storeService)
        {
            _storeService = storeService;
        }

        [Route("genre")]
        public IEnumerable<GenreViewModel> Get()
        {
            return _storeService.GetAllGenre();
        }
    }
}
