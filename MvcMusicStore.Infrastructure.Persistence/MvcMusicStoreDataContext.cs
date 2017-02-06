using MvcMusicStore.Business.Core.Interfaces.Persistence;
using MvcMusicStore.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Infrastructure.Persistence
{
    public class MvcMusicStoreDataContext : DbContext, IWriteEntities
    {
        public MvcMusicStoreDataContext()
        {

        }
        public MvcMusicStoreDataContext(string connectionStringOrName): base(connectionStringOrName)
        {
            
        }

        public void Create<TEntity>(TEntity entity) where TEntity : Entity
        {
            this.Set<TEntity>().Add(entity);
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : Entity
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Load<TEntity>() where TEntity : Entity
        {
            return this.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> Query<TEntity>(params Expression<Func<TEntity, object>>[] includeExpressions) where TEntity:Entity
        {
            var rootEntity = this.Set<TEntity>().AsNoTracking().AsQueryable();
            foreach (var includeExpression in includeExpressions)
            {
                rootEntity = rootEntity.Include(includeExpression);
            }
            return rootEntity;
        }

        public void Update<TEntity>(TEntity entity) where TEntity : Entity
        {
            throw new NotImplementedException();
        }

        public override int SaveChanges()
        {
            var entries = this.ChangeTracker.Entries();
            foreach(var entry in entries)
            {
                var entity = ((Entity)entry.Entity);
                entity.CreatedOn = entity.CreatedOn.HasValue ? entity.CreatedOn : DateTime.Now.ToUniversalTime();
                entity.UpdatedOn = entry.State == EntityState.Modified ? DateTime.Now : entity.CreatedOn;                    
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>();
            modelBuilder.Entity<Album>();
            modelBuilder.Entity<Artist>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
