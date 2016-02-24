using Raaj.Application.Context;
using Raaj.Application.Models;

using System.Collections.Generic;

using System.Linq;


namespace Raaj.Application.Repository
{
    public interface IStudentRepository
    {
        int Insert(Student s);
        List<Student> GetAll();
        int Update(Student s);
        int Delete(int id);
        Student GetById(int id);
    }
    public class StudentRepository : IStudentRepository
    {
        private RaajDbConnection conn = new RaajDbConnection();

       

        public List<Student> GetAll()
        {
            return conn.Students.ToList();
        }

        

        public int Insert(Student s)
        {
            conn.Students.Add(s);
            return 1;
        }
          public int Update(Student s)
        {
            
            conn.Entry(s).State = EntityState.Modified;
            return 1;

        }
          public int Delete(int id)
        {
            Student student = GetById(id);
            conn.Students.Remove(student);
            return 1;
        }
        public Student GetById(int id)
        {
            return conn.Students.Find(id);
        }
    }
}