using System.Collections.Generic;
using System.Linq;
using herokumxnet.Entities;

namespace herokumxnet.Services
{
    public interface IStudentData {
        IEnumerable<Student> GetAll();
    }

    public class StudentData : IStudentData {

         private readonly ApplicationDbContext _context;

        public StudentData(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }
        
    }
}