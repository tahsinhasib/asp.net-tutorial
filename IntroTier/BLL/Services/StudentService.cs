﻿using AutoMapper;
using BLL.DTOs;
using DLL.EF;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static List<StudentDTO> Get()
        {
            var repo = new StudentRepo();
            var data = repo.Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<List<StudentDTO>>(data);
            return ret;
        }


        public static void Create(StudentDTO s)
        {
            //convert to EF model
            var config = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<Student>(s);
            var repo = new StudentRepo();
            repo.Create(ret);
        }
    }
}
