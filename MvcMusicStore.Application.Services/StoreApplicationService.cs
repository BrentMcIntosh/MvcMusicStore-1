using MvcMusicStore.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcMusicStore.Application.ViewModels;

namespace MvcMusicStore.Application.Services
{
    public class StoreApplicationService : IStoreApplicationService
    {
        public AlbumViewModel GetAlbum(int albumId)
        {
            return new AlbumViewModel
            {
                Title = "Coloring Book",
                GenreName = "Christian hip hop",
                ArtistName = "Chance The Rapper",
                AlbumArtUrl = "http://chanceraps.com/",
                Price = 15
            };
        }

        public IEnumerable<AlbumViewModel> GetAlbums(int genreId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenreViewModel> GetAllGenre()
        {
            var genres = new List<GenreViewModel>()
            {
                new GenreViewModel { Name="Bluegrass", Description="Country Music", GenreId= 1 },
                new GenreViewModel { Name="Hardcore", Description="Dance", GenreId= 2 },
            };

            return genres;
        }

        public GenreViewModel GetGenre(int genreId)
        {
            throw new NotImplementedException();
        }
    }
}
