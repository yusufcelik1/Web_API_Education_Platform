using Entities_Education_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Education_Platform.Contracts
{
    public interface IRepositoryTeacher : IRepositoryBase<Teacher>
    {
        IQueryable<Teacher> GetTeacher(int id, bool trackChanges);
    }
}
