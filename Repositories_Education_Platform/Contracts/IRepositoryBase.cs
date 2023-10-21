using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Education_Platform.Contracts
{
    public interface IRepositoryBase<T>
    {
        void Create(T entity, bool trackChanges);
        IQueryable<T> Read(T entity , bool trackChanges);
        void Update(T entity, bool trackChanges);
        void Delete(T entity);
        IQueryable<T> GenericReadExpression(T entity, bool trackChanges, Expression<Func<T,bool>> expression);
    }
}
