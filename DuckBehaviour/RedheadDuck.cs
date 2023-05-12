using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckBehaviour
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            setFlyBehaviour(new FlyWithWings());
            setQuackBehaviour(new QuackSound());
        }
        public override string Display()
        {
            return "I am a Readhead Duck";
        }
    }
}