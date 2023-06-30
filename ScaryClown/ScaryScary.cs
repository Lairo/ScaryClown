using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryClown
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int scaryThingCount;
        public int ScaryThingCount { get; set; }
        public string ScaryThingIHave { get { return $"{scaryThingCount} spiders"; } }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave} !");
        }

        public ScaryScary(string funnyThing, int scaryThingCount) :base (funnyThing)
        {
            this.scaryThingCount = scaryThingCount;
        }
    }
}
