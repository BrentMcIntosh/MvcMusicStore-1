using MvcMusicStore.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Business.Core.Interfaces.Services
{
    public interface IStoreManagerService
    {
        void AddGenre(Genre genre);
        void DeleteGenre(Genre genre);
        void AddAlbum(Album album);
        void DeleteAlbum(Album album);
    }
}
