﻿using System;

namespace AoC2019.Common
{
    public static class IntExtensions
    {
        public static int GetNthDigit(this int value, int n)
        {
            return value / (int)Math.Pow(10, n) % 10;
        }

        public static int DigitCount(this int value)
        {
            if (value >= 0)
            {
                if (value < 10) return 1;
                if (value < 100) return 2;
                if (value < 1000) return 3;
                if (value < 10000) return 4;
                if (value < 100000) return 5;
                if (value < 1000000) return 6;
                if (value < 10000000) return 7;
                if (value < 100000000) return 8;
                if (value < 1000000000) return 9;
                return 10;
            }
            else
            {
                if (value > -10) return 2;
                if (value > -100) return 3;
                if (value > -1000) return 4;
                if (value > -10000) return 5;
                if (value > -100000) return 6;
                if (value > -1000000) return 7;
                if (value > -10000000) return 8;
                if (value > -100000000) return 9;
                if (value > -1000000000) return 10;
                return 11;
            }
        }
    }
}
