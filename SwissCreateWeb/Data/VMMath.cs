﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public static class VMMath
    {
        public static double Round(double number)
        {
            return Math.Round(number, 2);
        }
    }

}