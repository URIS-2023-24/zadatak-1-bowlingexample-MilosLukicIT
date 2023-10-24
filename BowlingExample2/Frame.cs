using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingExample2
{
    internal class Frame
    {
        private int firstThrow;
        private int secondThrow;
        private bool spare;
        private bool strike;

        public Frame(int first, int second)
        {
            this.firstThrow = first;
            this.secondThrow = second;
        }

        public Frame (int first, int second, bool spare, bool strike)
        {
            this.firstThrow = first;
            this.secondThrow = second;
            this.spare = spare;
            this.strike = strike;
        }


        public int getFirstThrow()
        {
            return firstThrow;
        }

        public int getSecondThrow()
        {
            return secondThrow;
        }

        public void setFirstThrow(int first)
        {
            this.firstThrow = first;
        }

        public void setSecondThrow(int second)
        {
            this.secondThrow = second;
        }

        public bool isSpare()
        {
            return spare;
        }

        public bool isStrike()
        {
            return strike;
        }
    }
}
