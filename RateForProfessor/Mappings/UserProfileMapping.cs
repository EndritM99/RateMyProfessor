﻿using AutoMapper;
using RateForProfessor.Entities;
using RateForProfessor.Models;

namespace RateForProfessor.Mappings
{
    public class UserProfileMapping : Profile
    {
        public UserProfileMapping()
        {
            CreateMap<Student, StudentEntity>().ReverseMap();
        }
    }
}