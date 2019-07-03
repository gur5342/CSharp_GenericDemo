using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class MarineStack
    {
        private List<Marine> _List = new List<Marine>();

        private int _index;
        public void Push(Marine x)
        {
            _List.Add(x);
            _index++;
        }
        public Marine Pop()
        {
            _index--;
            return _List[_index];

        }

    }
}
