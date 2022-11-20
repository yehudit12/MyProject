using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Entities
{
  public  class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Permission: id {this.Id}, name {this.Name}";
        }
    }
}
