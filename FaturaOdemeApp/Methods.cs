using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaOdemeApp
{
    static  class Methods
    {
        public const decimal KDV = 1.08M;
        public static decimal ElektrikFaturası (decimal tutar)
        {
            return KDV * tutar;
        }
        public static decimal SuFaturası  (decimal tutar)
        {
            return KDV * tutar;
        }
        public static decimal DogalGazFaturasi(decimal tutar)
        {
            return KDV * tutar;
        }
    }
}
