using AutoMapper;
using MyProject.Common;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services
{
    class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Role, RoleDTO>().ReverseMap();
        }
        
    }
}
