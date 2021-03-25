using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Data
{
    public class Category : BaseEntity
    {
        [ForeignKey("Id")]
        public Guid MainCategoryId { get; set; }
        public virtual MainCategory MainCategory { get; set; }

        [ForeignKey("Id")]
        public Guid SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public Category(MainCategory main, SubCategory sub)
        {
            MainCategoryId = main.Id;
            SubCategoryId = sub.Id;
        }

        public Category(string main, string sub)
        {
            MainCategoryId = new Guid(main);
            SubCategoryId = new Guid(sub);
        }

        public Category()
        {

        }
    }
}
