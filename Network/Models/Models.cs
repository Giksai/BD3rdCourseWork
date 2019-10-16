using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Network.Models
{
    //[Table("Accounts")]
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        //Personal Info
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //
        public double Money { get; set; }
        public int Points { get; set; }

        //public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }

    }

    //[Table("Purchases")]
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }
        public DateTime PurchaseDat { get; set; }

        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    //[Table("Products")]
    public class Product //Нельзя удалить продукт, так как на него ссылаются
    {
        [Key]
        public int ProductId { get; set; }
        public int Amount { get; set; }

        //public int AccountId { get; set; }
        //public Account Account { get; set; }
        
        public int PurchaseId { get; set; }
        [ForeignKey("PurchaseId")]
        public virtual Purchase Purchase { get; set; }

        public int ProductDId { get; set; }
        [ForeignKey("ProductDId")]
        public virtual ProductD ProductD { get; set; }
    }

    public class ProductD
    {
        [Key]
        public int ProductDId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }

    //[Table("ItemsStorages")]
    public class ItemsStorage //Вот этот ссылается
    {
        [Key]
        public int ItemsStorageId { get; set; }
        public bool OnSale { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }


}
