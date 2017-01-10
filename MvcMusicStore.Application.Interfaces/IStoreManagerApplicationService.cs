using MvcMusicStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Application.Interfaces
{
    public interface IStoreManagerApplicationService
    {
        void AddGenre(GenreViewModel genre);
        void DeleteGenre(GenreViewModel genre);
        void AddAlbum(AlbumViewModel album);
        void DeleteAlbum(AlbumViewModel album);
    }
}
