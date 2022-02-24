using System;

namespace SampleService
{
    public class SampleService
    {
        public int Add(int n1, int n2)
        {
            var result = n1 + n2;
            if (result > 10)
            {
                result = 10;
            }
            return result;
        }
    }
}
