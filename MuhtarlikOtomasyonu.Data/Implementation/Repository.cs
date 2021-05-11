using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MuhtarlikOtomasyonu.Data.Contracts;
using MuhtarlikOtomasyonu.Data.DataContext;

namespace MuhtarlikOtomasyonu.Data.Implementation
{
    public class Repository<T> : IRepositoryBase<T> where T:class,new()
    {

        private readonly MuhtarlikOtomasyonuContext _ctx;
        internal DbSet<T> dbSet;


        public Repository(MuhtarlikOtomasyonuContext ctx)
        {
            _ctx = ctx;
            this.dbSet = ctx.Set<T>();
        }



  
        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }

            return query.FirstOrDefault();

        }

        /// <summary>
        /// Gelen tipte veri ekler
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }

            return query;
        }
    }
}
