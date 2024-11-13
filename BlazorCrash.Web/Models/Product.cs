﻿namespace BlazorCrash.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Image { get; set; }
        public bool isActive { get; set; }

        public IEnumerable<ProductProps> ProductProps { get; set; }
    }
}
