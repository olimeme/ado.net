using System.Collections.Generic;

namespace OnlineShope
{
    public class Cart
    {
        public int Id { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}