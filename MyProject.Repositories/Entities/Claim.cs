using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Entities
{
   public enum Policy { Allow,Deny}
    public class Claim
    {
        public int Id { get; set; }
        public Role RoleId { get; set; }
        public Permission PermissionId { get; set; }
        public  Policy policy{ get; set; }
    }
}
