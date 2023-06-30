using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryClown 
{
    class FunnyFunny : IClown
    {
        private readonly string funnyThingIHave;

        public string FunnyThingIHave { get { return funnyThingIHave; } }

        public void Honk()
        {
            Console.WriteLine($"Hi Kids! I have {FunnyThingIHave}.");
        }

        public FunnyFunny (string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
    }
}
