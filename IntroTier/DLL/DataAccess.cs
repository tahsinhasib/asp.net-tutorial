﻿using DLL.Interfaces;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DataAccess
    {
        public static IStudentRepo StudentData()
        {
            return new StudentRepoV2();
        }
    }
}
