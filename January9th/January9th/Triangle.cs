using System;
using System.Collections.Generic;
using System.Text;

namespace January9th
{
    public class Triangle
    {
        private double _baseLength;
        private double _height;

        public void setBaseLength(double baseLength)
        {
            _baseLength = baseLength;
        }

        public void setHeight(double height)
        {
            _height = height;
        }

        public double getBaseLength()
        {
            return _baseLength;
        }

        public double getHeight()
        {
            return _height;
        }

        public double getArea()
        {
            return .5 * _baseLength * _height;
        }
    }
}
