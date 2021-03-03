using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameQuest.Data
{
    public class Order : BaseEntity
    {

        public string Status { get; set; }


        [ForeignKey("Id")]
        public virtual Guid ProductId { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey("Id")]
        public virtual Guid UserId { get; set; }
        public virtual User User { get; set; }

    }
    
}
