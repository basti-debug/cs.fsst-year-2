using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testübung_2
{
    class Pig:Animal
    {
        public override string MakeSound()
        {
            return "Oink";
        }

        public override string ToString()
        {
            return "A pig sounds like " + MakeSound();
        }
    }
}
