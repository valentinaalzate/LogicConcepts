﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class DayUtilitis
    {
        public static bool IsLeapYear(int year) {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                   return false;
                   
                }
                
                    return true;
                
            }
            return false;
            

        }
    }
}
