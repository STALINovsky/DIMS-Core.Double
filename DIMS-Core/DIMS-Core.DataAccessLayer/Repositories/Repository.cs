﻿using DIMS_Core.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    /// <summary>
    /// TODO: Task #1
    /// Implement all methods
    /// Generic Repository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        protected readonly DbSet<TEntity> _set;

        public Repository(DbContext context)
        {
            _context = context;
            _set = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(int id)
        {
            if (id == 0)
            {
                // TODO: Task #3
                // Create custom exception for invalid arguments
                // based on abstract class BaseException
                // throw new AnyException(string paramName);
            }

            // TODO: type must be adjusted to entity type accordingly
            object objectFromDB = null;

            if (objectFromDB is null)
            {
                // TODO: Task #4
                // Create custom exception for non existed object in database
                // based on abstract class BaseException
                // throw new AnyException(string methodName, string message);
            }

            // RECOMMEND: It's better to create a helper static class for errors instead of throwing them
            // Ask us if you stucked and it looks ridiculous for you

            throw new NotImplementedException();
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            throw new NotImplementedException();

            // TODO: comment out it when implement other logic
            // await _context.SaveChangesAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();

            // TODO: comment out it when implement other logic
            // await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();

            // TODO: comment out it when implement other logic
            // await _context.SaveChangesAsync();
        }

        #region Disposable
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }

        ~Repository()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion Disposable
    }
}