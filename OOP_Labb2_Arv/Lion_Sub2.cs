namespace OOP_Labb2_Arv
{
    internal class Lion_Sub2 : Lion
    {
        public bool Cool { get; set; }

        public Lion_Sub2(string name, string scientificName, bool hasLegs, bool canFly, bool livesInSweden, bool winsFight, int speed, bool cool) : base(name, scientificName, hasLegs, canFly, livesInSweden, winsFight, speed)
        {
            Cool = cool;
        }

        public override void Present()
        {
            base.Present();
            Console.WriteLine($"Is the Lion sub-species '{Name}' cool? Answer: {Cool}");
        }
    }
}
