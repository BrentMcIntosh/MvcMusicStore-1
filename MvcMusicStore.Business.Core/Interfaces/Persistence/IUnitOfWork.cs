using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Business.Core.Interfaces.Persistence
{
    public interface IUnitOfWork
    {
        int SaveChanges();
    }
}
