using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240033
{
    public class Enemy : Character
    {
        public int AttackPower { get; set; }

        // Constructor
        public Enemy(string name, int initialHealth, int attackPower)
            : base(name, initialHealth)
        {
            this.AttackPower = attackPower;
            Console.WriteLine($"...dan dia adalah seorang Enemy.");
        }

        // Implementasi Metode
        public override void Attack(Character target)
        {
            Console.WriteLine($"\n{this.Name} (Enemy) menyerang {target.Name}!");
            target.TakeDamage(this.AttackPower);
        }
    }
}
