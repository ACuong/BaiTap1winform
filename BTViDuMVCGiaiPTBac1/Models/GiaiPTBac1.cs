using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTViDuMVCGiaiPTBac1.Models
{
    public class GiaiPTBac1
    {
        public double GiaiPTBacMot(double a, double b)
        {
            double x;
            x = -b / a;
            return x;
        }
    }
}