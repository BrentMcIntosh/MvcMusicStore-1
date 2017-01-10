using MvcMusicStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Application.Interfaces
{
    public interface IStoreApplicationService
    {
        IEnumerable<GenreViewModel> GetAllGenre();
        GenreViewModel GetGenre(int genreId);

        IEnumerable<AlbumViewModel> GetAlbums(int genreId);
        AlbumViewModel GetAlbum(int albumId);
    }
}
