using DLL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repos
{
    public class CourseRepo : Repo
    {
        public void Create(Course s)
        {
            db.Courses.Add(s);
            db.SaveChanges();
        }

        public void Update(Course s)
        {
            var exobj = Get(s.CourseID);
            db.Entry(exobj).CurrentValues.SetValues(s);
            db.SaveChanges();
        }

        public Course Get(int CourseID)
        {
            return db.Courses.Find(CourseID);
        }

        public List<Course> Get()
        {
            return db.Courses.ToList();
        }

        public void Delete(int CourseID)
        {
            var exobj = Get(CourseID);
            db.Courses.Remove(exobj);
            db.SaveChanges();
        }
    }
}
