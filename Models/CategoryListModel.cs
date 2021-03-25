using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Models
{
    public class MainCategoryListModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class SubCategoryListModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }


    public class SelectedItem
    {
        public string Value { get; set; }
        public string Name { get; set; }
    }
}
