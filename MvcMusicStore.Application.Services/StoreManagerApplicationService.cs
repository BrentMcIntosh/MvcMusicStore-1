using MvcMusicStore.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcMusicStore.Application.ViewModels;
using MvcMusicStore.Business.Core.Interfaces.Services;
using MvcMusicStore.Business.Core.Models;

namespace MvcMusicStore.Application.Services
{
    public class StoreManagerApplicationService : IStoreManagerApplicationService
    {
        IStoreManagerService _service;

        public StoreManagerApplicationService(IStoreManagerService service)
        {
            _service = service;
        }

        public StoreManagerApplicationService()
        {

        }
        public void AddAlbum(AlbumViewModel album)
        {
            var album = new Album
            {
                 
            }
        }

        public void AddGenre(GenreViewModel genre)
        {
            throw new NotImplementedException();
        }

        public void DeleteAlbum(AlbumViewModel album)
        {
            throw new NotImplementedException();
        }

        public void DeleteGenre(GenreViewModel genre)
        {
            throw new NotImplementedException();
        }
    }
}
