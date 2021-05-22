using System;
using System.Collections.Generic;

namespace Assignment3.Classes
{
    //4-6-2021 Saung NEW 5L :  Generic queue which can be serialized
    [Serializable]
    public class SerializableQueue<T>: Queue<T>
    {
        //4-6-2021 Saung NEW 5L :  Generic method returns item at given index or default if not found
        public T this[int index]
        {
            get
            {
                int count = 0;
                foreach (T o in this)
                {
                    if (count == index)
                        return o;
                    count++;
                }
                return default;
            }
        }

        // 4-6-2021 Saung NEW 5L :  Generich method adds new item to the queue
        public void Add(T r)
        {
            Enqueue(r);
        }
    }
}
