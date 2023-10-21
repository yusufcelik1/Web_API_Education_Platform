using Entities_Education_Platform.Models;
using Repositories_Education_Platform.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Education_Platform.EFCore
{
    public class RepositoryTeacher : RepositoryBase<Teacher>, IRepositoryTeacher
    {
        public RepositoryTeacher(RepositoryContext context) : base(context)
        {
            
        }
        public IQueryable<Teacher> GetTeacher(int id, bool trackChanges) => GenericReadExpression(trackChanges, x => x.TeacherId == id);

    }
}
