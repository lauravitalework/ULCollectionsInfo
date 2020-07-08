using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULCollectionsInfo
{
    class Recording
    {
        public DateTime startTime = new DateTime(4000,1,1);
        public DateTime endTime = new DateTime(1000,1,1);
        public List<String> dataFiles = new List<string>();
        public double ms = 0;
        public int totalLogs = 0;
    }
}
