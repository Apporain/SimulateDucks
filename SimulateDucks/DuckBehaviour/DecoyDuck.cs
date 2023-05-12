using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckBehaviour
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            setQuackBehaviour(new MuteQuack());
            setFlyBehaviour(new FlyNoWay());
        }
        public override string Display()
        {
            return "I am a Decoy Duck";
        }
    }
}