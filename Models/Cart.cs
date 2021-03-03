using GameQuest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Models
{
    public static class Cart
    {
        private static List<Product> productsInCart;
        public static bool AddToCart(Product product)
        {
            try 
            {
                productsInCart.Add(product);
                return true;
            }
            catch 
            {
                return false;
            } 
        }

        public static bool RemoveFromCart(Product product)
        {
            try
            {
                productsInCart.Remove(product);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static List<Product> GetCart()
        {
            return productsInCart;
        }
    }
}
