using DLL.EF;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repos
{
    internal class StudentRepo : Repo, IStudentRepo
    {
        public void Create(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
        }

        public void Update(Student s)
        {
            var exobj = Get(s.StudentID);
            db.Entry(exobj).CurrentValues.SetValues(s);
            db.SaveChanges();
        }

        public Student Get(int StudentID)
        {
            return db.Students.Find(StudentID);
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public void Delete(int StudentID)
        {
            var exobj = Get(StudentID);
            db.Students.Remove(exobj);
            db.SaveChanges();
        }

        public void Add(Student s)
        {
            throw new NotImplementedException();
        }
    }
}
