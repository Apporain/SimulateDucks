using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehaviour
{
    public abstract class Duck
    {

        private FlyBehaviour flyBehaviour;
        private QuackBehaviour quackBehaviour;

        public FlyBehaviour FlyBehaviour
        {
            get
            {
                return flyBehaviour;
            }
        }

        public QuackBehaviour QuackBehaviour
        {
            get
            {
                return quackBehaviour;
            }
        }

        public string Swim()
        {
            return "I Can Swim";
        }

        public abstract string Display();


        public string performQuack()
        {
            return quackBehaviour.Quack();
        }

        public string performFly()
        {
            return flyBehaviour.Fly();
        }

        public void setFlyBehaviour(FlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void setQuackBehaviour(QuackBehaviour qb)
        {
            quackBehaviour = qb;
        }
    }
}
