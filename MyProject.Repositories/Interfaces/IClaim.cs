using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
   public interface IClaim
    {
        List<Claim> GetAll();
        Claim GetById(int id);
        Claim Add(int id, Role role, Permission permission, Policy policy);
        Claim Update(Claim role);
        void Delete(int id);
    }
}
