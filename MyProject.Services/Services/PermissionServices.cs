using AutoMapper;
using MyProject.Common;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Services
{
   public class PermissionServices: IPermissionService
    {
        private readonly IPermission _permissionRepository;
        private readonly IMapper _mapper;
        public PermissionServices(IPermission permissionRepository,IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }
        public List<PermissionDTO> GetAll()
        {
            var permission= _permissionRepository.GetAll();
            return _mapper.Map<List< PermissionDTO>>(permission);
        }
        public PermissionDTO GetById(int id)
        {
            var permission = _permissionRepository.GetById(id);
            return _mapper.Map<PermissionDTO>(permission);
        }
        public PermissionDTO Add(int id, string name)
        {
            var permission = _permissionRepository.Add(id, name);
            return _mapper.Map<PermissionDTO>(permission);
        }
        public PermissionDTO Update(PermissionDTO permission)
        {
            var cPermission=_mapper.Map<Permission>(permission);
            var perm= _permissionRepository.Update(cPermission);
            return _mapper.Map<PermissionDTO>(perm);
        }
        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }
    }
}
