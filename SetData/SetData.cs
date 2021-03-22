using System;

namespace SetData
{
    public class SetData
    {
        public int ElementsCount = 0;
        public bool IsEmpty()
        {
            return ElementsCount==0;
        }
        public void Add(object element)
        {
            ElementsCount += 1;
            
        }
        public int Count()
        {
            return ElementsCount;
        }
      
    }
}
