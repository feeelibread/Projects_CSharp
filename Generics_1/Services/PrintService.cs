using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_1.Services
{
    class PrintService
    {
        private int[] _vect = new int[10];
        private int _count = 0;

        public void AddValue(int value)
        {
            if (_count == 10)
            {
                throw new Exception("Oops! The vector is full of values!");
            }
            _vect[_count] = value;
            _count++;
        }

        public int First()
        {
            if (_count == 0)
            {
                throw new Exception("Oops! The vector is null!");
            }
            return _vect[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_vect[i] + ", ");
            }
            if(_count > 0)
            {
                Console.Write(_vect[_count - 1]);
            }
            Console.Write("]");
        }

    }
}
