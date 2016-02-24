using Raaj.Application.Models;
using Raaj.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raaj.Application.Service
{
    public interface IStudentService
    {
        int insert(Student s);
        List<Student> GetAll();
        int Update(Student s);
        int Delete(int id);
        Student GetById(int id);

    }
    public class StudentService : IStudentService
    {
        private StudentRepository sRepo = new StudentRepository();

        public int Delete(int id)
        {
            sRepo.Delete(id);
            return 1;

        }

        public List<Student> GetAll()
        {
            return sRepo.GetAll();  
        }

        public Student GetById(int id)
        {
           return sRepo.GetById(id);
            
        }

        public int insert(Student s)
        {
            sRepo.insert(s);
            return 1;
        }

        public int Update(Student s)
        {
            return sRepo.Update(s);
                 
        }
    }
}