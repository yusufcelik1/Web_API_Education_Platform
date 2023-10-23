using Repositories_Education_Platform.Contracts;
using Repositories_Education_Platform.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Education_Platform
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IRepositoryStudent> _studentRepository;
        private readonly Lazy<IRepositoryTeacher> _teacherRepository;
        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _studentRepository = new Lazy<IRepositoryStudent>(() => new RepositoryStudent(_context));
            _teacherRepository = new Lazy<IRepositoryTeacher>(() => new RepositoryTeacher(_context));
        }
        
        public IRepositoryStudent student => _studentRepository.Value; //Lazy loading Usage

        public IRepositoryTeacher teacher => _teacherRepository.Value;

        public void Save()
        { 
            _context.SaveChanges();
        }
    }
}
