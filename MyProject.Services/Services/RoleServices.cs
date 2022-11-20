using AutoMapper;
using MyProject.Common;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Services
{
    public class RoleServices : IRoleService
    {
        private readonly IRole _roleRepository;
        private readonly IMapper _mapper;

        public RoleServices(IRole roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public List<RoleDTO> GetAll()
        {
            var role = _roleRepository.GetAll();
            return _mapper.Map<List<RoleDTO>>(role);
        }
        public RoleDTO GetById(int id)
        {

            var role = _roleRepository.GetById(id);
            return _mapper.Map<RoleDTO>(role);
        }
        public RoleDTO Add(int id, string name)
        {
            var role = _roleRepository.Add(id, name);
            return _mapper.Map<RoleDTO>(role);
        }
        public RoleDTO Update(int id, string name)
        {
            var role = _roleRepository.Update(id, name);
            return _mapper.Map<RoleDTO>(role);
        }
        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }
    }
}
