namespace OOP_Labb2_Arv
{
    internal class Fish : Animal
    {
        public bool PartOfHumanDiet { get; set; }
        public Fish(string name, string scientificName, bool hasLegs, bool canFly, bool livesInSweden, bool winsFight, bool partOfHumanDiet) : base(name, scientificName, hasLegs, canFly, livesInSweden, winsFight)
        {
            PartOfHumanDiet = partOfHumanDiet;
        }

        public override void Present()
        {
            base.Present();
            Console.WriteLine($"Part of human diet? {PartOfHumanDiet}");
        }
        public override void Eating()
        {
            base.Eating();
            Console.WriteLine($"When a {Name} eats, it eats other, smaller fish. That's why a fisherman can use a small fish as a bait to catch bigger fish.");
        }

        public void Swimming()
        {
            Console.WriteLine("The fish is swimming around, enjoying life.");
        }
    }
}
