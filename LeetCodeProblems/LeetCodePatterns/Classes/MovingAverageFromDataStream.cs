using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Classes
{
    //346. Moving Average from Data Stream
    // Given a stream of integers and a window size, calculate the moving average of all integers in the sliding window.
    //Implement the MovingAverage class:
    //MovingAverage(int size) Initializes the object with the size of the window size.
    //double next(int val) Returns the moving average of the last size values of the stream.
    class MovingAverageFromDataStream
    {

        private int _maxSize;
        private int _currentSum;
        IList<int> _list = new List<int>();

        public MovingAverageFromDataStream(int size)
        {
            this._maxSize = size;
            this._currentSum = 0;
            this._list = new List<int>();

        }

        public double Next(int val)
        {
            if (_list.Count < _maxSize)
            {
                _currentSum += val;
                _list.Add(val);
            }
            else
            {
                _currentSum = _currentSum - this._list[0] + val;
                this._list.RemoveAt(0);
                this._list.Insert(_list.Count, val);
            }
            return (double)_currentSum / _list.Count;
        }
        /**
         * Your MovingAverage object will be instantiated and called as such:
         * MovingAverage obj = new MovingAverage(size);
         * double param_1 = obj.Next(val);
         */
    }
}
