using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShope
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ShopContext())
            {
                Item bread = new Item()
                {
                    Name = "Хлеб Цесна",
                    Price = 80
                };

                Item wine = new Item()
                {
                    Name = "Wine",
                    Price = 7000
                };

                Item eggs = new Item()
                {
                    Name = "Eggs",
                    Price = 200
                };

                ICollection<Item> items = new List<Item>();

                items.Add(bread);
                items.Add(wine);
                items.Add(eggs);

                Cart cart = new Cart()
                {
                    Items = items
                };

                User user = new User()
                {
                    Login = "admin",
                    Password = "admin",
                    Cart = cart
                };

                context.Items.Add(bread);
                context.Items.Add(wine);
                context.Items.Add(eggs);
                context.Carts.Add(cart);
                context.Users.Add(user);

                context.SaveChanges();
            }

        }
    }
}
