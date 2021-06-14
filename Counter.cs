using System;
using System.Collections.Generic;
using System.Text;

namespace DogsEducation
{
    public class Counter
    {
        public event Action<int> HalfReached;
        public void StartCounting()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i == 50)
                {
                    HalfReached?.Invoke(i);
                }
            }
        }
    }
}
