using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Network.Models
{
    public class ProductBought
    {
        public int ProductBoughtId { get; set; }
        public int Amount { get; set; }

        public int PurchaseId { get; set; }
        [ForeignKey("PurchaseId")]
        public virtual Purchase Purchase { get; set; }

        public int ProductStorageId { get; set; }
        [ForeignKey("ProductStorageId")]
        public virtual ProductStorage ProductStorage { get; set; }

    }
}
