using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using IPermission = MyProject.Repositories.Interfaces.IPermission;

namespace MyProject.Repositories.Repositories
{
  public  class PermissionRepository : IPermission
    {
        public PermissionRepository(IContext context)
        {
            _context = context;
        }
        private readonly IContext _context;
        public Permission Add(int id, string name)
        {
            Permission permission = new Permission { Id = id, Name = name };
            _context.Permissions.Add(permission);
            return permission;
        }
        public void Delete(int id)
        {
            for (int i = 0; i < _context.Permissions.Count; i++)
            {
                if (_context.Permissions[i].Id == id)
                    _context.Permissions.Remove(_context.Permissions[i]);
            }
        }
        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }
        public Permission GetById(int id)
        {
            Permission permission = new Permission();
            for (int i = 0; i < _context.Permissions.Count; i++)
            {
                if (_context.Permissions[i].Id == id)
                    permission = _context.Permissions[i];
            }
            return permission;
        }
        public Permission Update(Permission permission)
        {
            return permission;
        }
    }   
}
