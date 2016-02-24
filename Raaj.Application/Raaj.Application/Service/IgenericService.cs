using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raaj.Application.Service
{
    public interface IgenericService<Student>
    {
        int Insert(Student s);
        int Delete(int id);
        int Update(Student);
        List<Student> GetAll();
        Student GetById(int id);
    }
}
