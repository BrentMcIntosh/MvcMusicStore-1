using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Business.Core.Models
{
    public class Genre : Entity
    {
        public string Name{ get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}
