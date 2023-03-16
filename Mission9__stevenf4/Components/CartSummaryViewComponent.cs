using Microsoft.AspNetCore.Mvc;
using Mission9__stevenf4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Mission9__stevenf4.Components

//Receiving the cart object as a constructor argument
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private ShoppingCart cart;
        public CartSummaryViewComponent(ShoppingCart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}