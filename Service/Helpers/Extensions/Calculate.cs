﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Helpers.Extensions
{
    public static class Calculate
    {
        public static int CalculateFactorial(this int num)
        {
            int result = 1;

            if (num == 0)
            {
                return result;
            }
            else
            {
                for (int i =num; i > 0; i--)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
}
