using System;

namespace BPMCounter
{
    public class BPMCounter
    {
        public static void Main()
        {
            var beatsPerMinute = int.Parse(Console.ReadLine());
            var numberOfBits = int.Parse(Console.ReadLine());
            double bars = Math.Round(numberOfBits / 4.0, 1);
            double lengthInSeconds = numberOfBits * 60.0 / beatsPerMinute;

            var minutes = Math.Floor(lengthInSeconds / 60);
            var seconds = Math.Floor(lengthInSeconds % 60);

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
