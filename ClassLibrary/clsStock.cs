using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public int ItemNo { get; set; }
        public DateTime DateAdded { get; set; }
        public string ItemDesc { get; set; }
        public string ItemName { get; set; }
        public bool Avaliable { get; set; }
        public decimal Price { get; set; }
    }
}