using GameQuest.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameQuest.Data
{
    public class Order : BaseEntity
    {

        public string Status { get; set; }

        public string CustomerName { get; set; }

        public string Address { get; set; }

        public string Address2 { get; set; }

        public string District { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public bool Finished { get; set; }

        public string PaymentMethod { get; set; }

        public virtual List<OrderProduct> Products { get; set; }


        [ForeignKey("Id")]
        public virtual Guid UserId { get; set; }
        public virtual User User { get; set; }

    }
    
}
