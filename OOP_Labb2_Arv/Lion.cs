namespace OOP_Labb2_Arv
{
    internal class Lion : Animal
    {
        public int Speed { get; set; }
        public Lion(string name, string scientificName, bool hasLegs, bool canFly, bool livesInSweden, bool winsFight, int speed) : base(name, scientificName, hasLegs, canFly, livesInSweden, winsFight)
        {
            Speed = speed;
        }

        public override void Present()
        {
            base.Present();
            Console.WriteLine($"Top speed: {Speed} km/h.\n");
        }

        public override void Eating()
        {
            base.Eating();
            Console.WriteLine($"When a {Name} eats, it eats other big animals that it has hunted. Such as gazelles.\n");
        }
    }
}
