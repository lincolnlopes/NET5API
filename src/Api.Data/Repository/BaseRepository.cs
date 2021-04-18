using System;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private readonly DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = context.Set<T>();
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(predicate: p => p.Id.Equals(id))
                                            .ConfigureAwait(false);
                if (result == null) return false;
                _context.Remove(result);
                await _context.SaveChangesAsync().ConfigureAwait(false);
            }
            catch (Exception)
            {
                throw;
            }
            return true; // Task.FromResult(true);
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }
                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);
                await _context
                    .SaveChangesAsync()
                    .ConfigureAwait(false);
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }
        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id)).ConfigureAwait(false);
        }

        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(predicate: p => p.Id.Equals(id)).ConfigureAwait(false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<System.Collections.Generic.IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync().ConfigureAwait(false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(predicate: p => p.Id.Equals(item.Id))
                                            .ConfigureAwait(false);
                if (result == null) return null;

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt;
                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync().ConfigureAwait(false);
            }
            catch (System.Exception)
            {
                throw;
            }
            return null;
        }
    }
}