using MvcMusicStore.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Business.Core.Interfaces.Persistence
{
    public interface IWriteEntities :   IReadEntities, IUnitOfWork
    {
        IQueryable<TEntity> Load<TEntity>() where TEntity : Entity;
        void Create<TEntity>(TEntity entity) where TEntity : Entity;
        void Update<TEntity>(TEntity entity) where TEntity : Entity;
        void Delete<TEntity>(TEntity entity) where TEntity : Entity;
    }
}
