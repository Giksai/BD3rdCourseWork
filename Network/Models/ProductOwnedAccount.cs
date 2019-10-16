using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Network.Models
{
    public class ProductOwnedAccount
    {
        public int ProductOwnedAccountId { get; set; }
        public int Amount { get; set; }

        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        public int ProductStorageId { get; set; }
        [ForeignKey("ProductStorageId")]
        public virtual ProductStorage ProductStorage { get; set; }

    }
}
