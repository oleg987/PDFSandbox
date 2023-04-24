using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFSandbox
{
    internal class NumFilter
    {
        private IFilterStrategy strategy;

        public void SetStrategy(IFilterStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int[] Filter(int[] ints)
        {
            return strategy.Filter(ints);
        }
    }
}
