using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testübung_2
{
    class Dog:Animal
    {
        public override string MakeSound()
        {
            return "wuff";
        }

        public override string ToString()
        {
            return "A dog sounds like " + MakeSound();
        }
    }
}
