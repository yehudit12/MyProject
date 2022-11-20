using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Entities
{
   public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Role: id {this.Id} ,name {this.Name}";
        }

    }
}
