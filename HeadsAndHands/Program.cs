namespace HeadsAndHands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать на арену.");
            Creation p1 = Factory.Create(13, 8, 45, 4, 9, true);
            Creation demon = Factory.CreateDemon();

            Console.WriteLine("Игрок против Демона(один из монстров):");

            while(p1.IsAlive() && demon.IsAlive())
            {
                Console.Write("Бьет игрок: ");
                Console.WriteLine(p1.Hit(demon));
                Console.Write("Бьет демон: ");
                Console.WriteLine(demon.Hit(p1));
                if (p1.CurrentHitPoint <= (p1.HitPoint / 2) && p1.IsHeal())
                {
                    p1.Heal();
                    Console.WriteLine("Игрок использует лечение");
                }
                Console.WriteLine("Здоровье игрока: " + p1.CurrentHitPoint);

                Console.WriteLine("Здоровье демона: " + demon.CurrentHitPoint);
            }

            if(!p1.IsAlive())
                Console.WriteLine("Игрок не справился с демоном и был убит.");
            else
                Console.WriteLine("Ура, он победил демона и мир был спасен.");
        }
    }
}