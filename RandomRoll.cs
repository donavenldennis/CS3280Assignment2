using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This class will return an random number
    /// </summary>
    internal class RandomRoll
    {
        private int face;

        public RandomRoll()
        {
            Random rand = new Random();
            this.face = rand.Next(0,6);
        }

        public int GetFace() { return face; }
    }
}
