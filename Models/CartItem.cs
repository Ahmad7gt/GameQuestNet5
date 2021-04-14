using GameQuest.Data;
using System;

namespace GameQuest.Models
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime Added { get; set; }

        public CartItem(Product product)
        {
            Id = new Guid();
            Product = product;
            Quantity = 1;
            Added = DateTime.Now;
        }
    }
}

