using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
   interface ISeries
    {
        void setStart(int x);
           int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int startValue;
        int step;
        int currentValue;
        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
            //return;
        }
        public void setStep(int s)
        {
            step = s;
        }
        public int getNext()
        {
            currentValue += step;
            return currentValue;
        }
        public void reset()
        {
            currentValue = startValue;
        }
    }
    class GeomProgression : ISeries
    {
        int startValue;
        int step;
        int currentValue;
        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }
        public void reset()
        {
            currentValue = startValue;
        }
    }

}
