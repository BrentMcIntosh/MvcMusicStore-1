using MvcMusicStore.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcMusicStore.Application.ViewModels;
using MvcMusicStore.Business.Core.Interfaces.Services;

namespace MvcMusicStore.Application.Services
{
    public class StoreApplicationService : IStoreApplicationService
    {
        private IStoreService storeService;
        public StoreApplicationService(IStoreService service)
        {
            storeService = service;
        }

        public AlbumViewModel GetAlbum(int albumId)
        {
            var album = storeService.GetAlbum(albumId);
            return new AlbumViewModel
            {
                ArtistName = album.Artist.Name,
                AlbumArtUrl = album.AlbumArtUrl,
                GenreName = album.Genre.Name,
                Price = album.Price,
                Title = album.Title
            };
        }

        public IEnumerable<AlbumViewModel> GetAlbums(int genreId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenreViewModel> GetAllGenre()
        {            
            var genresVm = from x in storeService.GetAllGenre().ToList()
                            select new GenreViewModel
                                {
                                    Name = x.Name,
                                    GenreId = x.Id,
                                    Description = x.Description
                                };
            return genresVm.ToList();
        }

        public GenreViewModel GetGenre(int genreId)
        {
            throw new NotImplementedException();
        }
    }
}
