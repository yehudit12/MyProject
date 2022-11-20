using MyProject.Common;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Policy = MyProject.Common.Policy;

namespace MyProject.Services.Interfaces
{
   public interface IClaimService
    {
        List<ClaimDTO> GetAll();
        ClaimDTO GetById(int id);
        ClaimDTO Add(int id, RoleDTO role, PermissionDTO permission, Policy policy);
        ClaimDTO Update(ClaimDTO role);
        void Delete(int id);
    }
}
