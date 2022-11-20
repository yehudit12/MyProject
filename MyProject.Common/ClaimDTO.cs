using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Common
{  public enum Policy { Allow, Deny }
        
   public class ClaimDTO
    {
      
            public int Id { get; set; }
            public RoleDTO RoleId { get; set; }
            public PermissionDTO PermissionId { get; set; }
            public Policy policy { get; set; }
        
    }
}
