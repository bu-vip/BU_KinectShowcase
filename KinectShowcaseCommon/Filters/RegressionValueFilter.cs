﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinectShowcaseCommon.Filters
{
    public class RegressionValueFilter : ValueFilter
    {
        private double _alpha;

        public RegressionValueFilter(double aAlpha)
        {
            _alpha = aAlpha;
        }

        override public double Next(double aCurrent)
        {
            this.Last = aCurrent * _alpha + this.Last * (1.0f - _alpha);
            return this.Last;
        }
    }
}
