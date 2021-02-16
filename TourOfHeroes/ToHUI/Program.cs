using System;
using ToHModels;
using ToHBL;
namespace ToHUI
{
    class Program
    {
        private IHeroBL heroBL = new IHeroBL();
        static void Main(string[] args)
        {
            // Create hero method/logic
            Hero newHero = new Hero();
            Console.WriteLine("Enter Hero Name: ");
            newHero.HeroName = Console.ReadLine();
            Console.WriteLine("Enter HP value: ");
            newHero.HP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SuperPower details");
            newHero.SuperPower = new SuperPower();
            Console.WriteLine("Enter SuperPower name: ");
            newHero.SuperPower.Name = Console.ReadLine();
            Console.WriteLine("Enter SuperPower description: ");
            newHero.SuperPower.Description = Console.ReadLine();
            Console.WriteLine("Enter SuperPower damage: ");
            newHero.SuperPower.Damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Set the element type of the hero: ");
            newHero.ElementType = Enum.Parse<Element>(Console.ReadLine());
            heroBL.AddHero(newHero);
            foreach (var item in HeroBL.GetHeroes())
            {
                Console.WriteLine($"Hero created with details: \n\t name: {item.HeroName} \n\t SuperPower: {item.SuperPower.Name}");

            }
            //Console.WriteLine($"Hero created with details: \n\t name: {newHero.HeroName} \n\t SuperPower: {newHero.SuperPower.Name}");

            //Console.WriteLine(newHero.HeroName);
        }
    }
}
