using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raaj.Application.Repository
{
    public interface IGenericRepository<Student>
    {
        int Insert(Student s);
        int Update(Student s);
        int Delete(Student s);
        Student GetbyId(int id);
        IEnumerable<Student> getAll();
        
    }
}
