using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Stack<T> where T : IComparable<T> // T를 쓰는 이유는 그냥 관례
                        // 비교할 수 있는 것만을 조건으로 
    {
        private List<T> _List = new List<T>();

        private int _index;
        public void Push(T x)
        {
            _List.Add(x);
            _index++;

            if(_index > 1)
                if(_List[_index - 1].CompareTo(_List[_index - 2] ) > 0)
                    Console.WriteLine("greater" + _List[_index - 1].ToString());
        }
        public T Pop()
        {
            _index--;
            return _List[_index];

        }
    }
}
