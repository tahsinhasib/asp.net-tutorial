﻿using DLL.EF;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repos
{
    internal class StudentRepoV2 : IStudentRepo
    {
        public void Add(Student s)
        {
            throw new NotImplementedException();
        }

        public void CreateStudent() { }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Student s)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent() { }
    }
}
