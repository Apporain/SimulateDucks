using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckBehaviour
{
    public class MuteQuack : QuackBehaviour
    {
        public string Quack()
        {
            return "I Can't Quack";
        }
    }
}