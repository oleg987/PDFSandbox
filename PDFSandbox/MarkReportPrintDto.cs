using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFSandbox
{
    internal class MarkReportPrintDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        // So on...
        public ICollection<MarkPrintDto> Marks { get; set; }
    }
}
