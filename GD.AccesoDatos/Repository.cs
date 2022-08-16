﻿using GD.AccesoDatos.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GD.AccesoDatos
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Variables
        public readonly DbContext _context;
        internal DbSet<T> _dbSet;
        #endregion

        #region Constructor
        public Repository(DbContext context)
        {
            _context = context;
            this._dbSet = context.Set<T>();
        }
        #endregion


        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);

            }
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);

                }

            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();

            }

            return query.ToList();

        }

        public T GetFirsOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);

            }
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);

                }

            }

            return query.FirstOrDefault();



        }

        public void Remove(int id)
        {
            T entityToRemove = _dbSet.Find(id);
            Remove(entityToRemove);

        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
