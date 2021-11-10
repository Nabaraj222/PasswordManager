using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Models
{
    public class ProductInfo
    {
        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
