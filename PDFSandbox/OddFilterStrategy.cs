using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFSandbox
{
    internal class OddFilterStrategy : IFilterStrategy
    {
        public int[] Filter(int[] input)
        {
            return input.Where(x => x % 2 == 0).ToArray();
        }
    }
}
