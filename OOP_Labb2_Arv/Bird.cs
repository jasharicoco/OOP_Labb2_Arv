﻿namespace OOP_Labb2_Arv
{
    internal class Bird : Animal
    {
        public bool LivesInWater { get; set; }
        public Bird(string name, string scientificName, bool hasLegs, bool canFly, bool livesInSweden, bool winsFight, bool livesInWater) : base(name, scientificName, hasLegs, canFly, livesInSweden, winsFight)
        {
            LivesInWater = livesInWater;
        }

        public override void Present()
        {
            base.Present();
            Console.WriteLine($"Does it live in water? {LivesInWater}");
        }
        public override void Eating()
        {
            base.Eating();
            Console.WriteLine($"When a {Name} eats, it eats worms, seeds and other small things.");
        }

        public int Flying(int value)
        {
            return value;
        }
    }
}
