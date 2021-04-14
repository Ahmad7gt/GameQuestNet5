using GameQuest.Data;
using GameQuest.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class CartService
{
    private readonly Context _context;

    private static List<CartItem> cartItems = new List<CartItem>();

    public CartService(Context context)
    {
        _context = context;
    }

    public void DecrementItem(string productId)
    {
        CartItem item = cartItems.Where(x => x.Product.Id == new Guid(productId)).FirstOrDefault();

        if (item is not null)
        {

            if (item.Quantity > 1)
            {
                cartItems.Where(x => x.Product.Id == new Guid(productId)).FirstOrDefault().Quantity--;
            }
            else
            {
                cartItems.Remove(item);
            }
            
        }

    }
    public void RemoveFromCart(string productId)
    {
        CartItem item = cartItems.Where(x => x.Product.Id == new Guid(productId)).FirstOrDefault();

        if (item is not null)
        {
            cartItems.Remove(item);
        }
    
    }
    public void AddToCart(string productId)
    {
        Product product = _context.Products.Where(x => x.Id == new Guid(productId)).FirstOrDefault();

        if (product is not null)
        { 
        
            CartItem item = cartItems.Where(x => x.Product.Id == new Guid(productId)).FirstOrDefault();

            if (item is not null)
            {
                cartItems.Where(x => x.Product.Id == new Guid(productId)).FirstOrDefault().Quantity++;

            }
            else
            {
                item = new CartItem(product);
                cartItems.Add(item);
            }
        }
 
    }
    public int CartCount()
    {
        return cartItems.Count();
    }
    public List<CartItem> GetCart()
    {
        return cartItems;
    }

}

