using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcMusicStore.Business.Core.Interfaces.Services;
using MvcMusicStore.Business.Core.Models;

namespace MvcMusicStore.Business.Services
{
    public class StoreService : IStoreService
    {
        IStoreService _service;

        public StoreService()
        {

        }

        public StoreService(IStoreService service)
        {
            _service = service;
        }
        public IEnumerable<Genre> GetAlbum(int albumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAlbums(int genreId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAllGenre()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetGenre(int genreId)
        {
            throw new NotImplementedException();
        }
    }
}
