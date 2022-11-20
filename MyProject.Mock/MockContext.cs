using System;
using System.Collections.Generic;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Mock
{
    public class MockContext : IContext
    {
        public List<Role> Roles { get; set; }
        public List<Permission> Permissions { get; set; }
        public List<Claim> Claims { get; set; }
        public MockContext()
        {
            this.Roles = new List<Role>();
            this.Permissions = new List<Permission>();
            this.Claims = new List<Claim>();

            this.Roles.Add(new Role { Id = 1, Name = "principal" });
            this.Roles.Add(new Role { Id = 2, Name = "teacher" });
            this.Roles.Add(new Role { Id = 3, Name = "pupil" });

            this.Permissions.Add(new Permission { Id = 1, Name = "see all the pupils' marks" });
            this.Permissions.Add(new Permission { Id = 2, Name = "see all her pupils' marks " });
            this.Permissions.Add(new Permission { Id = 3, Name = "see her mark" });

            this.Claims.Add(new Claim { Id = 1, RoleId = Roles[0], PermissionId = Permissions[0], policy = Policy.Allow });
        }
    }
}

