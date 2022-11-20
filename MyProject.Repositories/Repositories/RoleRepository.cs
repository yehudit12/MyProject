using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
   public  class RoleRepository : IRole
    {
        private readonly IContext _context;
        public RoleRepository(IContext context)
        {
            _context = context;
        }
        public  Role Add(int id, string name)
        {
            Role role = new Role { Id = id, Name = name } ;
            _context.Roles.Add(role);
            return role;
        }
        public void Delete(int id)
        {
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if (_context.Roles[i].Id == id)
                    _context.Roles.Remove(_context.Roles[i]);
            }
        }
        public List<Role> GetAll()
        {
            return _context.Roles; 
        }

        public Role GetById(int id)
        {
            Role role = new Role();
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if (_context.Roles[i].Id == id)
                    role = _context.Roles[i];
            }
            return role;
        }

        public Role Update(int id,string name)
        {
            Role role = new Role();
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if (_context.Roles[i].Id == id)
                {
                    _context.Roles[i].Name = name;
                    break;
                }
            }
            return role;
           
        }
    }
}
