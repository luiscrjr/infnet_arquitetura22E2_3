﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SpotifyLite.Infrastructure.Database
{
    public interface IRepository<T> where T : class
    {
        Task Save(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        Task<IEnumerable<T>> FindAllByCriteria(Expression<Func<T, bool>> expression);
        Task<T> FindOneByCriteria(Expression<Func<T, bool>> expression);
        void Detach(T entity);
    }
}
