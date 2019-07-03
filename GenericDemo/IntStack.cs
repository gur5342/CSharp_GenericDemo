using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class IntStack // class IntStack : List<int>를 사용해도 되지만 권장x
    {
        private List<int> _List = new List<int>();

        private int _index;
        public void Push(int x)
        {
            _List.Add(x);
            _index++;
        }
        public int Pop()
        {
            _index--;
            return _List[_index];
            
        }
    }
}
