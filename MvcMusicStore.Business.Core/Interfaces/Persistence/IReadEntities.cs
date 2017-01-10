using MvcMusicStore.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Business.Core.Interfaces.Persistence
{
    public interface IReadEntities
    {
        IQueryable<TEntity> Query<TEntity>() where TEntity : Entity;
    }
}
