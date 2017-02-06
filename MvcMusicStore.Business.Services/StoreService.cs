using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcMusicStore.Business.Core.Interfaces.Services;
using MvcMusicStore.Business.Core.Models;
using MvcMusicStore.Business.Core.Interfaces.Persistence;

namespace MvcMusicStore.Business.Services
{
    public class StoreService : IStoreService
    {
        IWriteEntities writeEntities;

        public StoreService(IWriteEntities readContext)
        {
            writeEntities = readContext;
        }

        public StoreService()
        {
          
        }
        public Album GetAlbum(int albumId)
        {
            return writeEntities.Query<Album>(x=>x.Artist, x=>x.Genre).Where(x => x.Id == albumId).FirstOrDefault();
        }

        public IEnumerable<Album> GetAlbums(int genreId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAllGenre()
        {
            return writeEntities.Query<Genre>().ToList();
        }

        public Genre GetGenre(int genreId)
        {
            throw new NotImplementedException();
        }
    }
}
