using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFriend = "Hayri";
            string secondFriend = "Selman";

            Console.WriteLine($"Benim arkadaşlarım {firstFriend} and {secondFriend}");

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"Integer min value {min}, Integer max value : {max}");


            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            dortIslem.Topla(3, 12);
            
        }


    }

}
