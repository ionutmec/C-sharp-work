using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've incountered Groznyi the Brigand and he launches a surprise attack.");
            Console.WriteLine("Input your defence stat:");
            int defence = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethodes.Defence(defence);
            Console.WriteLine("You have taken " + enemy_damage + " HP of damage.");
            Console.WriteLine("Your healer, Sarra is near by. She heals you with her staff.");
            Console.WriteLine("Input your healer's magic stat:");
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethodes.Heal(magic);
            Console.WriteLine("You have been healed for " + hitpoints + " HP.");
            Console.WriteLine("Now it's your turn to counter attack.");
            Console.WriteLine("Input your strength stat:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethodes.Attack(strength);
            Console.WriteLine("You have landed a critical attack and dealt " + damage + " HP worth of damage.");
            Console.ReadLine();
        }
    }
}
