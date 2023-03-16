using Microsoft.AspNetCore.Mvc;
using Mission9__stevenf4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9__stevenf4.Controllers
{
    public class PurchaseController : Controller
    {
        private IPurchaseRepository repo { get; set; }
        private ShoppingCart cart { get; set; }
        public PurchaseController(IPurchaseRepository temp, ShoppingCart sc)
        {
            repo = temp;
            cart = sc;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }

        [HttpPost]
        public IActionResult Checkout(Purchase purchase)
        {
            if (cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty.");
            }

            if (ModelState.IsValid)
            {
                purchase.Lines = cart.Items.ToArray();
                repo.SavePurchase(purchase);
                cart.ClearCart();

                return RedirectToPage("/CheckoutSuccess");
            }
            else
            {
                return View();
            }
        }
    }
}
