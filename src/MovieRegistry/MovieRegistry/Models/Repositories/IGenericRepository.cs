﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieRegistry.Models.Repositories
{
    public interface IGenericRepository<T> : IDisposable
    {
        IQueryable<T> All();
        IQueryable<T> Where(Expression<Func<T, bool>> filter);
        T FindById(int id);

        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        void Save();
    }
}
