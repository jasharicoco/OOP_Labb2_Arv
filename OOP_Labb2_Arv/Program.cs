namespace OOP_Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bird1 = new Bird("Hummingbird", "Trochilidae", true, true, false, false);

            bird1.Present();
            bird1.MakeSound("tweet tweet");
        }
    }
}
