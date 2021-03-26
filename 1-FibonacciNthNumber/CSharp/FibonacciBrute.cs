using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class FibonacciBrute
    {
        public static Int64 FibBrute(Int64 n) {
            if(n <= 2) return 1;
            return FibBrute(n-1) + FibBrute(n-2);
        }
    }
    
}