﻿using System.Xml.Linq;

namespace OOP_Labb2_Arv
{
    internal class Animal
    {
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public bool HasLegs { get; set; }
        public bool CanFly { get; set; }
        public bool LivesInSweden { get; set; }
        public bool WinsFightAgainstHuman { get; set; }

        public Animal(string name, string scientificName, bool hasLegs, bool canFly, bool livesInSweden, bool winsFight)
        {
            Name = name;
            ScientificName = scientificName;
            HasLegs = hasLegs;
            CanFly = canFly;
            LivesInSweden = livesInSweden;
            WinsFightAgainstHuman = winsFight;
        }

        public virtual void Present()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Scientific Name: {ScientificName}\n" +
                $"Does it have legs? {HasLegs}\n" +
                $"Can it fly? {CanFly}\n" +
                $"Does it live in Sweden? {LivesInSweden}\n" +
                $"Does it win a fight against a human? {WinsFightAgainstHuman}");
        }
        public virtual void Accelerate()
        {
            Console.WriteLine($"{Name} is accelerating.");
        }

        public virtual void Resting()
        {
            Console.WriteLine($"{Name} is resting.");
        }

        public virtual void Eating()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void MakeSound(string SpeechToText)
        {
            Console.WriteLine($"A {Name} sounds like this: {SpeechToText}.");
        }

    }
}
