using AuvoSelecao.Core.Base;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AuvoSelecao.Core.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T Find(int id);
        IQueryable<T> List();
        IQueryable<T> List(Expression<Func<T, bool>> filter);
        void Add(T item);
        void Remove(T item);
        void Edit(T item);
    }
}
