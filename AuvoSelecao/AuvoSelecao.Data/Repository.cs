using AuvoSelecao.Core.Base;
using AuvoSelecao.Core.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AuvoSelecao.Data
{
    public class Repository
    {
        public class BaseRepository<T>
        : IDisposable, IBaseRepository<T> where T : BaseEntity
        {
            private DataContext _context;

            #region Ctor
            public BaseRepository(IUnitOfWork unitOfWork)//, string connString)
            {
                if (unitOfWork == null)
                    throw new ArgumentNullException("unitOfWork");

                Database.SetInitializer<DataContext>(null);
                _context = unitOfWork as DataContext;
                //_context.Database.Connection.ConnectionString = connString;
            }
            #endregion

            public T Find(int id)
            {
                return _context.Set<T>().Find(id);
            }

            public IQueryable<T> List()
            {
                try
                {
                    return _context.Set<T>().AsNoTracking().AsQueryable();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }

            public void Add(T item)
            {
                _context.Set<T>().Add(item);
            }

            public void Remove(T item)
            {
                _context.Set<T>().Remove(item);
            }

            public void Edit(T item)
            {
                _context.Entry(item).State = EntityState.Modified;
            }

            public void Dispose()
            {
                _context.Dispose();
            }

            public IQueryable<T> List(Expression<Func<T, bool>> filter)
            {
                try
                {
                    return _context.Set<T>().Where(filter).AsNoTracking();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
