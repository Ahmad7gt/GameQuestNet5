using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Data
{
    public class OrderProduct : BaseEntity
    {

        [ForeignKey("Id")]
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
