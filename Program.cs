using System;

namespace DogsEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            counter.HalfReached += OnHalfReached;

            counter.HalfReached += delegate (int c)
            {
                Console.WriteLine($"Анонимные делегаты - не очень круто ({c})");
            };

            counter.HalfReached += c =>
            {
                Console.WriteLine($"Лямбды - вот что круто ({c})");
            };
 
            counter.StartCounting();
        } // () => {};
        // x => {};
        // (x, y, z) => {};

        public static void OnHalfReached(int mya)
        {
            Console.WriteLine($"Половина достигнута: {mya}");
        }
    }
}
