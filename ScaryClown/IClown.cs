using System;

namespace ScaryClown
{
    interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();

        //protected static int Random random = new Random();

        //private static int carCapacity = 12;

        //public static int CarCapacity
        //{
        //    get { return carCapacity; }
        //    set
        //    {
        //        if (value > 10) carCapacity = value;
        //        else Console.Error.WriteLine($"Warning: Car capacity {value} is too small");
        //    }
        //}

        //public static string ClownCarDescription()
        //{
        //    return $"A clown car with {random.Next(carCapacity / 2, carCapacity)} clowns";
        //}
    }
}
