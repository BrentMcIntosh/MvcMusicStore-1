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
        IEnumerable<Genre> GetGenre(int genreId);

        IEnumerable<Genre> GetAlbums(int genreId);
        IEnumerable<Genre> GetAlbum(int albumId);

    }
}
