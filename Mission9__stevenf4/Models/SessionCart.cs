using Microsoft.AspNetCore.Http;
using Mission9__stevenf4.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mission9__stevenf4.Models
{
    public class SessionCart : ShoppingCart
    {
        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Book book, int qty)
        {
            base.AddItem(book, qty);
            Session.SetJson("Cart", this);
        }

        public override void RemoveItem(Book book)
        {
            base.RemoveItem(book);
            Session.SetJson("Cart", this);
        }

        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.Remove("Cart");
        }

    }
}
