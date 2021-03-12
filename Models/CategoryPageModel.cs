using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Models
{
    public class CategoryPageModel
    {
        public string Id { get; set; }
        public string MainName { get; set; }
        public List<string> SubCategories { get; set; }

        public CategoryPageModel(string id, string mainName, List<string> subCats)
        {
            Id = id;
            MainName = mainName;
            SubCategories = subCats;
        }
    }
}
