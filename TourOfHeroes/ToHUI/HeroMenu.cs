using System;
using ToHModels;
using ToHBL;
namespace ToHUI
{
    public class HeroMenu : IMenu
    {   
        private IHeroBL _heroBL;
        public HeroMenu(IHeroBL heroBL)
        {
            _heroBL = heroBL;
        }
        public void Start()
        {   Boolean stay = true;
            do{
                // Menu options
            Console.WriteLine("Welcome to my Tour of Heroes application. What would you like to do?");
            Console.WriteLine("[0] Create a hero");
            Console.WriteLine("[1] Get all my heroes");
            Console.WriteLine("[2] Exit");

            // get user input
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "0":
                    try
                    {CreateHero();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Invalid input" + e.Message);
                        continue;
                    }
                    break;
                case "1":
                    GetHeroes();
                    break;
                case "2":
                    stay = false;
                    ExitRemarks();
                    break;
                default:
                    Console.WriteLine("Invalid input, please enter a proper value.");
                    break;
            }
            
            }while (stay);

        }
        public void CreateHero()
        {
             // Create hero method/logic
            Hero newHero = new Hero();
            Console.WriteLine("Enter Hero Name: ");
            newHero.HeroName = Console.ReadLine();
            Console.WriteLine("Enter HP value: ");
            newHero.HP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SuperPower details");
            SuperPower newSuperPower = new SuperPower();
            Console.WriteLine("Enter SuperPower name:");
            newSuperPower.Name = Console.ReadLine();
            Console.WriteLine("Enter SuperPower description");
            newSuperPower.Description = Console.ReadLine();
            Console.WriteLine("Enter SuperPower damage");
            newSuperPower.Damage = int.Parse(Console.ReadLine());
            newHero.SuperPower = newSuperPower;
            Console.WriteLine("Set the element of the hero: ");
            newHero.ElementType = Enum.Parse<Element>(Console.ReadLine());

            _heroBL.AddHero(newHero);
            Console.WriteLine("Hero created successfully.");
        }
        public void GetHeroes()
        {
            foreach(var item in _heroBL.GetHeroes())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public void ExitRemarks()
        {
            Console.WriteLine("Thank you for visiting");
        }
    }
}