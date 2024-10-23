namespace OOP_Labb2_Arv
{
    internal class Bird : Animal
    {
        public Bird(string name, string scientificName, bool hasLegs, bool canFly, bool livesInSweden, bool winsFight) : base(name, scientificName, hasLegs, canFly, livesInSweden, winsFight)
        {
            Name = name;
            ScientificName = scientificName;
            HasLegs = hasLegs;
            CanFly = canFly;
            LivesInSweden = livesInSweden;
            WinsFightAgainstHuman = winsFight;
        }
    }
}
