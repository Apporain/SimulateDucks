using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckBehaviour
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            setQuackBehaviour(new QuackSound());
            setFlyBehaviour(new FlyWithWings());
        }
        public override string Display()
        {
            return "I am a Mallard Duck";
        }
    }
}