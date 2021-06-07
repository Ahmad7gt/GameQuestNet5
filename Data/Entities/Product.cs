using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameQuest.Data
{
    public class Product  :BaseEntity
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
        public double Sale { get; set; }
        public bool IsVisible { get; set; }

        [ForeignKey("Id")]
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public bool Deals { get; set; }
       

        public Product()
        {
            Name = string.Empty;
            Description = string.Empty;
            ImgUrl = string.Empty;
            Price = 0.0;
            Sale = 0.0;
            IsVisible = false;
            Deals = false;
            
        }

    }
}
