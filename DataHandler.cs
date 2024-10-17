using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_quiz_2
{
    public class DataHandler<T>
    {
        public List<T> data = new List<T>();

        public void AddData(T item)
        {
            data.Add(item);
        }

        public T RetrieveData(int index)
        {
            if (index < 0 || index >= data.Count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return data[index];
        }
    }
}
