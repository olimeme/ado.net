using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirst.Tables;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var model = new GameModel())
            {
                var hero = new Character() { Name = "Kirei", Ability = "Speed", Class = "Assassin", Strength = 100 };
                var blades = new Weapon() { Name = "Dragontooth", Class = "Assassin", Damage = 50 };
                var sword = new Weapon() { Name = "Copperjoint", Class = "Archer", Damage = 76 };
                model.Characters.Add(hero);
                model.Weapons.Add(blades);
                model.Weapons.Add(sword);
                model.SaveChanges();
            }
        }
    }
}
