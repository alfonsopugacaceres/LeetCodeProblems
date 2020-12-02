using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.MovingAverage
{
    public class MovingAverage
    {

        private int _size;
        private IList<double> _numbers;
        public MovingAverage()
        {
            _size = 1;
            _numbers = new List<double>();
        }

        public MovingAverage(int size)
        {
            _size = size;
            _numbers = new List<double>();
        }

        public double Next(int val)
        {
            if (_numbers == null)
            {
                return 0;
            }
            else if (_numbers.Count == 0)
            {
                _numbers.Add(val);
                return _numbers.ElementAt(0);
            }
            else if (_numbers.Count == _size)
            {
                _numbers.RemoveAt(0);
                _numbers.Add(val);
            }
            else
            {
                _numbers.Add(val);
            }

            double response = 0;
            double currentSize = _numbers.Count;
            foreach (double number in _numbers)
            {
                response += number;
            }

            return response / currentSize;
        }


    }
}
