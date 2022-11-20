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
    public class ClaimController : ControllerBase
    {

        private readonly IClaim _claimRepository;

        public ClaimController(IClaim claimRepository)
        {
            _claimRepository = claimRepository;

        }
        [HttpGet]
        public IEnumerable<Claim> Get()
        {
            return _claimRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Claim GetById(int id)
        {
            for (int i = 0; i < _claimRepository.GetAll().Count; i++)
            {
                if (_claimRepository.GetAll()[i].Id == id)
                    return _claimRepository.GetAll()[i];
            }
            return new Claim();
        }
        [HttpDelete]
        public void Delete(Claim claim)
        {
            for (int i = 0; i < _claimRepository.GetAll().Count; i++)
            {
                if (_claimRepository.GetAll()[i].Id == claim.Id)
                    _claimRepository.Delete(_claimRepository.GetAll()[i].Id);
            }
        }
        [HttpPost]
        public void Post(Claim claim)
        {
            _claimRepository.Add(claim.Id,claim.RoleId,claim.PermissionId,claim.policy);
        }
        [HttpPut]
        public void Put(Claim claim)
        {
            _claimRepository.Update(claim);
        }

    }
}

