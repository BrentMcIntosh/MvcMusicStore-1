using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcMusicStore.Business.Core.Models;

namespace MvcMusicStore.Business.Core.Interfaces.Services
{
    public interface IStoreService
    {
        IEnumerable<Genre> GetAllGenre();
        Genre GetGenre(int genreId);

        IEnumerable<Album> GetAlbums(int genreId);
        Album GetAlbum(int albumId);

    }
}
