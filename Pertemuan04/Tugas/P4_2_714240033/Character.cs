using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240033
{
    // Kelas abstrak
    public abstract class Character
    {
        // Field private, hanya bisa diakses lewat properti
        private int health;

        // Properti Publik untuk Nama
        public string Name { get; set; }

        // Properti Publik untuk Health
        public int Health
        {
            get { return health; }
            protected set
            {
                if (value < 0)
                    health = 0;
                else
                    health = value;
            }
        }

        // Constructor
        public Character(string name, int initialHealth)
        {
            this.Name = name;
            this.Health = initialHealth;
            Console.WriteLine($"Karakter '{this.Name}' telah dibuat.");
        }

        // Metode abstrak
        public abstract void Attack(Character target);
        public void TakeDamage(int damage)
        {
            this.Health -= damage;
            Console.WriteLine($"-> {this.Name} menerima {damage} damage, sisa HP: {this.Health}");
            if (this.Health == 0)
            {
                Console.WriteLine($"   ** {this.Name} telah dikalahkan! **");
            }
        }
    }
}
