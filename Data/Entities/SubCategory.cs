using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Data
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public SubCategory()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        public SubCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
