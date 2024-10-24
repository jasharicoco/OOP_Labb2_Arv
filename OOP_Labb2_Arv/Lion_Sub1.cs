namespace OOP_Labb2_Arv
{
    internal class Lion_Sub1 : Lion
    {
        public string Area { get; set; }
        public Lion_Sub1(string name, string scientificName, bool hasLegs, bool canFly, bool livesInSweden, bool winsFight, int speed, string area) : base(name, scientificName, hasLegs, canFly, livesInSweden, winsFight, speed)
        {
            Area = area;
        }

        public override void Present()
        {
            base.Present();
            Console.WriteLine($"The Lion sub-species '{Name}' lives in {Area}.");
        }
    }
}
