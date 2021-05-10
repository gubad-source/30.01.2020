using System;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.Test("voooooshhhhhhhhh");

            Fish[] fishes = new Fish[10];
            for(int i = 0; i < fishes.Length; i++)
            {
                Fish fish = new Fish();
                fish.name = $"Cichlid: {i + 1}";
                fishes[i] = fish;
            }
            foreach(var item in fishes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
