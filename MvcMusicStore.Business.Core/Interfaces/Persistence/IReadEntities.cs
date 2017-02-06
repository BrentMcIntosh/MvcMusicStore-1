using MvcMusicStore.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Business.Core.Interfaces.Persistence
{
    public interface IReadEntities
    {
        IQueryable<TEntity> Query<TEntity>(params Expression<Func<TEntity, object>>[] includeExpressions) where TEntity : Entity;
    }
}
