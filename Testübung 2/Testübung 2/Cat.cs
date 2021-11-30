using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testübung_2
{
    class Cat:Animal
    {
        public override string MakeSound()
        {
            return "Miau";
        }

        public override string ToString()
        {
            return "A cat sounds like " + MakeSound();
        }
    }
}
