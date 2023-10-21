using Entities_Education_Platform.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Repositories_Education_Platform.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Education_Platform.EFCore
{ 
    public class RepositoryStudent : RepositoryBase<Student>, IRepositoryStudent
    {
        
        public RepositoryStudent(RepositoryContext context) : base(context) 
        {
        }
        public IQueryable<Student> GetStudent(int id, bool trackChanges) => GenericReadExpression(trackChanges,x => x.StudentId == id);
        
    }
}
