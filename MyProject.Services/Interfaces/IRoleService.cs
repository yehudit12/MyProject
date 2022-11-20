using MyProject.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Interfaces
{
   public interface IRoleService
    {
        List<RoleDTO> GetAll();
        RoleDTO GetById(int id);
        RoleDTO Add(int id, string name);
        RoleDTO Update(int id, string name);
        void Delete(int id);
    }
}
