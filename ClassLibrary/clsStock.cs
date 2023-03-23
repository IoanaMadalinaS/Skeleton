using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public int ItemN { get; set; }
        public DateTime DateAdded { get; set; }
        public string ItemDesc { get; set; }
        public string ItemName { get; set; }
        public bool ItemAvaliable { get; set; }
        public decimal Price { get; set; }
    }
}