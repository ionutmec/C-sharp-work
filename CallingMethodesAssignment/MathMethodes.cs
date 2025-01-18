using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodesAssignment
{
    public class MathMethodes
    {
        //Create 3 methods that take one integer parameter and return an integer
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }
        public static int Defence(int defence) 
        {
            int enemy_str = 7;
            int weapon_mt = 11;
            int triangle_bonus = -1;
            int crit_coeff = 1;
            int damage = (enemy_str + (weapon_mt + triangle_bonus) - defence) * crit_coeff;
            return damage;
        }
        public static int Attack(int strenght) 
        {
            int enemy_def = 4;
            int weapon_mt = 8;
            int triangle_bonus = 1;
            int crit_coeff = 3;
            int damage = (strenght + (weapon_mt + triangle_bonus) -enemy_def) * crit_coeff;
            return damage;
        }
    }
}
