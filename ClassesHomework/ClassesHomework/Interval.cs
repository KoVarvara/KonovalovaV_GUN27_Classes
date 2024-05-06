using System;

namespace ClassesHomework
{
    public struct Interval
    {
        public float Get { get; private set; }
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Average { get; private set; }

        public Interval(int minValue, int maxValue) : this(float.MinValue, float.MaxValue)
        {
          
        }

        public Interval(float minValue, float maxValue)
        {
            var rand = new Random();
            if (minValue > maxValue)
            {
                Min = maxValue;
                Max = minValue;
            }
            else
            {
                Min = minValue;
                Max = maxValue;
            }
            Get = rand.Next((int)minValue, (int)maxValue);
            Average = (maxValue + minValue) / 2;
        }

        public Interval(float value) : this(value, value)
        {
      
        }
    }
}
