using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240033
{
    public class Player : Character
    {
        public int AttackPower { get; set; }

        // Memanggil Constructor
        public Player(string name, int initialHealth, int attackPower)
            : base(name, initialHealth)
        {
            this.AttackPower = attackPower;
            Console.WriteLine($"...dan dia adalah seorang Player.");
        }

        // Implementasi Metode Attack
        public override void Attack(Character target)
        {
            Console.WriteLine($"\n{this.Name} (Player) menyerang {target.Name}!");
            target.TakeDamage(this.AttackPower);
        }
    }
}
