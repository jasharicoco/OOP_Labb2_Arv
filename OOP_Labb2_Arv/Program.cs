namespace OOP_Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bird1 = new Bird("Hummingbird", "Trochilidae", true, true, false, false, false);

            bird1.Present();
            bird1.MakeSound("tweet tweet");
            bird1.Eating();

            var lion1 = new Lion("Lion", "Panthera leo", true, false, false, true, 100);

            lion1.Present();
            lion1.MakeSound("rawwwwwwr");

            var fish1 = new Fish("Salmon", "Salmo salar", false, false, true, false, true);

            fish1.Present();
            fish1.MakeSound("blub...");

            var lionsub1 = new Lion_Sub1("Panthera Leo Leo", "Unknown", true, false, false, true, 120, "West Africa, Northern Central Africa and India");
            
            lionsub1.Present();

            var lionsub2 = new Lion_Sub2("Panthera leo melanochaita", "Unknown", true, false, false, true, 140, true);

            lionsub2.Present();
        }
    }
}
