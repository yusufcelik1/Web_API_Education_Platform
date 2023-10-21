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
        void GenericCreate(T entity, bool trackChanges);
        IQueryable<T> GenericRead(T entity , bool trackChanges);
        void GenericUpdate(T entity, bool trackChanges);
        void GenericDelete(T entity);
        IQueryable<T> GenericReadExpression(bool trackChanges, Expression<Func<T,bool>> expression);
    }
}
