using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240033
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Membuat Karakter ---");
            // Membuat objek dari kelas turunan
            Player hero = new Player("Kesatria Hitam", 100, 25);
            Enemy goblin = new Enemy("Goblin Kecil", 50, 10);

            Console.WriteLine("\n--- Pertarungan Dimulai! ---");

            // Metode Attack() dari 'hero' (Player) yang dipanggil
            hero.Attack(goblin);

            // Metode Attack() dari 'goblin' (Enemy) yang dipanggil
            goblin.Attack(hero);

            // Serangan kedua dari hero
            hero.Attack(goblin);

            // Cek status setelah pertarungan
            Console.WriteLine($"\n--- Status Akhir ---");
            Console.WriteLine($"Nama: {hero.Name}, HP: {hero.Health}");
            Console.WriteLine($"Nama: {goblin.Name}, HP: {goblin.Health}");
        }
    }
}
