using MvcMusicStore.Business.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcMusicStore.Business.Core.Models;
using MvcMusicStore.Business.Core.Interfaces.Persistence;

namespace MvcMusicStore.Business.Services
{
    public class StoreManagerService : IStoreManagerService
    {
        IWriteEntities _writeEntities;

        public StoreManagerService(IWriteEntities writeEntities)
        {
            _writeEntities = writeEntities;
        }
        public void AddAlbum(Album album)
        {
            _writeEntities.Create(album);
        }

        public void AddGenre(Genre genre)
        {
            _writeEntities.Create(genre);
            _writeEntities.SaveChanges();
        }

        public void DeleteAlbum(Album album)
        {
            _writeEntities.Delete(album);
        }

        public void DeleteGenre(Genre genre)
        {
            _writeEntities.Delete(genre);
        }
    }
}
