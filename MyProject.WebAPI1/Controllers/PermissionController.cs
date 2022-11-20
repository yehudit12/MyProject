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
    public class PermissionController : ControllerBase

    { 
        private readonly IPermission _permissionRepository;

    public PermissionController(IPermission permissionRepository)
    {
            _permissionRepository = permissionRepository;

    }
    [HttpGet]
    public IEnumerable<Permission> Get()
    {
        return _permissionRepository.GetAll();
    }
    [HttpGet("{id}")]
    public Permission GetById(int id)
    {
        for (int i = 0; i < _permissionRepository.GetAll().Count; i++)
        {
            if (_permissionRepository.GetAll()[i].Id == id)
                return _permissionRepository.GetAll()[i];
        }
        return new Permission();
    }
    [HttpDelete]
    public void Delete(Permission permission)
    {
        for (int i = 0; i < _permissionRepository.GetAll().Count; i++)
        {
            if (_permissionRepository.GetAll()[i].Id == permission.Id)
                    _permissionRepository.Delete(_permissionRepository.GetAll()[i].Id);
        }
    }
    [HttpPost]
    public void Post(Permission permission)
    {
            _permissionRepository.Add(permission.Id, permission.Name);
    }
    [HttpPut]
    public void Put(Permission permission)
    {
      _permissionRepository.Update(permission);
    }

}
}
