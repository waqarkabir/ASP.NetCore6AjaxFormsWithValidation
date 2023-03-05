using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.DbModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
