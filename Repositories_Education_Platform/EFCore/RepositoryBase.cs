using Microsoft.EntityFrameworkCore;
using Repositories_Education_Platform.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Education_Platform.EFCore
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly RepositoryContext _context;
        public RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }
        public void GenericCreate(T entity, bool trackChanges) => _context.Set<T>().Add(entity);
        

        public void GenericDelete(T entity) => _context?.Set<T>().Remove(entity);
       

        public IQueryable<T> GenericRead(T entity, bool trackChanges) =>
        (IQueryable<T>)(!trackChanges ? _context.Set<T>().AsNoTracking().ToList()
            : _context.Set<T>().ToList());
       

        public IQueryable<T> GenericReadExpression(bool trackChanges, Expression<Func<T, bool>> expression) =>
            !trackChanges ? _context.Set<T>().Where(expression).AsNoTracking()
            : _context.Set<T>().Where(expression);

        public void GenericUpdate(T entity, bool trackChanges) => _context.Set<T>().Update(entity);
        
    }
}
