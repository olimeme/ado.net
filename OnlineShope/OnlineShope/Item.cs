﻿namespace OnlineShope
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Cart Cart { get; set; }
    }
}
