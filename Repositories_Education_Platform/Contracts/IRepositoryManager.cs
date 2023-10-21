using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Education_Platform.Contracts
{
    public interface IRepositoryManager
    {
        IRepositoryStudent student { get; }
        IRepositoryTeacher teacher { get; }
        void Save();
    }
}
