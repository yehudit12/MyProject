using MyProject.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Interfaces
{
   public interface IPermissionService
    {
        List<PermissionDTO> GetAll();
        PermissionDTO GetById(int id);
        PermissionDTO Add(int id, string name);
        PermissionDTO Update(PermissionDTO permission);
        void Delete(int id);
    }
}
