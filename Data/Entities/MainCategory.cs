using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Data
{
    public class MainCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public MainCategory()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        public MainCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}

