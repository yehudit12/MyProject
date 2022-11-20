using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;

namespace MyProject.WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRole _roleRepository;

        public RolesController(IRole roleRepository)
        {
            _roleRepository = roleRepository;
        }
        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _roleRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Role GetById(int id)
        {
            for (int i = 0; i < _roleRepository.GetAll().Count; i++)
            {
                if (_roleRepository.GetAll()[i].Id == id)
                    return _roleRepository.GetAll()[i];
            }
            return new Role();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            // _roleRepository.Delete(role.Id);

            for (int i = 0; i < _roleRepository.GetAll().Count; i++)
            {
                if (_roleRepository.GetAll()[i].Id == id)
                    _roleRepository.Delete(_roleRepository.GetAll()[i].Id);
            }
        }
        [HttpPost]
        public void Post(int id,string name)
        {
         _roleRepository.Add(id,name);
        }
        [HttpPut]
        public void Put(int id,string name)
        {
            _roleRepository.Update(id,name);
        }



    }
}
