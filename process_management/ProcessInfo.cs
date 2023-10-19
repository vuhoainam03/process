using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace process_management
{
    internal class ProcessInfo
    {
        public string name { get; set; }
        public int id { get; set; }
        public long memoryusage { get; set; }
        public int sessionId { get; set; }
    }
}
