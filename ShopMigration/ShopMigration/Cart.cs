using System.Collections.Generic;

namespace ShopMigration
{
    public class Cart
    {
        public int Id { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}