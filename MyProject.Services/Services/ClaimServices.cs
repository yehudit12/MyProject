using AutoMapper;
using MyProject.Common;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Policy = MyProject.Common.Policy;

namespace MyProject.Services.Services{
    class ClaimServices : IClaimService
    { 
        private readonly IClaim _claimRepository;
        private readonly IMapper _mapper;
        public ClaimServices(IClaim claimRepository, IMapper mapper)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
        }
       public List<ClaimDTO> GetAll()
        {
            var claim= _claimRepository.GetAll();
            return _mapper.Map<List<ClaimDTO>>(claim);
        }
        public ClaimDTO GetById(int id)
        {
            var claim = _claimRepository.GetById(id);
            return _mapper.Map<ClaimDTO>(claim);
        }
        public ClaimDTO Add(int id, RoleDTO role, PermissionDTO permission, Policy policy)
        {
           var cRole= _mapper.Map<Role>(role);
            var cPermission = _mapper.Map<Permission>(permission);
            var claim = _claimRepository.Add(id, cRole, cPermission, (Repositories.Entities.Policy)policy);
            return _mapper.Map<ClaimDTO>(claim);
        }
        public ClaimDTO Update(ClaimDTO claim)
        {
            var cClaim = _mapper.Map<Claim>(claim);
            var claimy = _claimRepository.Update(cClaim);
            return _mapper.Map<ClaimDTO>(claimy);
        }
        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }
    }
}
