using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.EntityFramework
{
    public class EfEntityFramework<TEntity,TContext> : IEntityFramework<TEntity> where TEntity : class,IEntity, new() where TContext : DbContext,new()
    {
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext ErpDB = new TContext())
            {
                return filter == null ? ErpDB.Set<TEntity>().ToList() : ErpDB.Set<TEntity>().Where(filter).ToList();

            }
        }


        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
