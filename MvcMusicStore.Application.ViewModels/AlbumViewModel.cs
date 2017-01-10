using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Application.ViewModels
{
    public class AlbumViewModel
    {
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public string Title { get; set; }
        public string  GenreName { get; set; }
        public string  ArtistName { get; set; }
    }
}
