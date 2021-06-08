using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace PhonebookManagenment
{
    class MyGeneric<T,Q> : IEnumerable
    {
        public int Count=> data.GetLength(0);
        public int Capacity;
        int size = 1;
        private object[,] data;
        
        
        public MyGeneric()
        {
            data = new object[0,2];
        }
        public object this[int index1, int index2]
        {
            get
            {
                return data[index1,index2];
            }
            set
            {
                data[index1, index2] = value;
            }
        }
        
        private void ResizeArray(ref object[,] Arr, int x)
        {
            object[,] _arr = new object[x, 2];
            int minRows = Math.Min(x, Arr.GetLength(0));
            int minCols = Math.Min(2, Arr.GetLength(1));
            for (int i = 0; i < minRows; i++)
               for (int j = 0; j < minCols; j++)
                   _arr[i, j] = Arr[i, j];
            Arr = _arr;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (object item in data)
            {
                yield return item;
            }

        }
        public void Add(T item1,Q item2)
        {          
            ResizeArray(ref data, size);  
            
            data[size - 1,0] = item1;
            data[size - 1,1] = item2;
            size++;           
        }
        public void Remove(T item)
        {
            int size1 = data.GetLength(0);
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].Equals(item))
                {
                    for (int j = i; j< data.GetLength(0) -1;j++)
                    {
                        data[j, 0] = data[j + 1, 0];
                        data[j, 1] = data[j + 1, 1];
                    }
                    ResizeArray(ref data, size1 - 1);                 
                    break;
                }
            }
            
        }
        public void ShowPhoneBooks()
        {
            Console.WriteLine($"name\t\t\tPhone number");
            for(int i = 0; i < data.GetLength(0);i++)
            {
                Console.WriteLine($"{data[i,0]}\t{data[i,1]}");
            }
        }
        public object ContainsKey(T item)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
               if (data[i,0].Equals(item))
                {
                    return data[i,1];
                }
            }
            return null;
        }
        public void Find(T item)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].Equals(item))
                {
                    Console.WriteLine($"{data[i, 0]}\t{data[i, 1]}");
                }
            }
        }
        public void Sortt()
        {
           
        }
    }
}
