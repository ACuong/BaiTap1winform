using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTViDuMVCGiaiPTBac1.Models
{
    public class GiaiPTBac1
    {
        public Double GiaiPTBacMot(Double a, Double b)
        {
            Double x;
            x = -b / a;
            return x;
        }
    }
}