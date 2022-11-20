﻿using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
   public interface IContext
    {
        List<Role> Roles { get; set; }

        List<Permission> Permissions { get; set; }
        List<Claim> Claims { get; set; }

    }
}
