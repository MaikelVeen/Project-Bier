using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Bier.Models
{
    public enum OrderStatus
    {
        Received = 0,
        OnRoute = 1,
        Delivered = 2
    }

    public class Order
    {
        [Key] public Guid Guid { get; set; }
        public bool Paid { get; set; }
        public bool Shipped { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public DateTime OrderCreated { get; set; }
        public DateTime OrderPaid { get; set; }
        public DateTime OrderShipped { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice { get; set; }
        public string CouponCode { get; set; }

        public ICollection<ProductOrder> OrderedProducts { get; set; }

        public Guid AssociatedUserGuid { get; set; }
        public bool OrderedFromGuestAccount { get; set; }
        public bool EmailConfirmationSent { get; set; }
    }
}