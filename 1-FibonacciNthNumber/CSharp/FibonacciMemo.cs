using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class FibonacciMemo
    {
        public static Dictionary<Int64, Int64> Memo = new Dictionary<long, long>();

        public static Int64 FibMemo(Int64 n) {
            if(Memo.ContainsKey(n)) return Memo[n];
            if(n <= 2) return 1;
            Memo[n] = FibMemo(n-1) + FibMemo(n-2);
            return Memo[n];
        }
    }
    
}