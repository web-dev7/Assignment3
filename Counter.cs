using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Counter
    {
        public static int countValue;
        private Counter()
        {
            countValue = 0;
        }


        public static Counter instance = null;
        public static Counter getInstance
        {
            get
            {
                if (instance == null)
                    instance = new Counter();
                return instance;
            }
        }
        public int count
        {
            get
            {
                return countValue;
            }
        }

        public void Increment()
        {
            countValue++;
        }
        public void Decrement()
        {
            countValue--;
        }
    }
}
