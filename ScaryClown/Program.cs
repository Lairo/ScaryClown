namespace ScaryClown
{
    class Program
    {
        static void Main()
        {
            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
            IScaryClown iScaryClownReference = (IScaryClown)fingersTheClown;
            iScaryClownReference.ScareLittleChildren();
        }
    }
}
