using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckBehaviour
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            setFlyBehaviour(new FlyNoWay());
            setQuackBehaviour(new Squeak());
        }
        public override string Display()
        {
            return "I am a rubber Duck";
        }
    }
}