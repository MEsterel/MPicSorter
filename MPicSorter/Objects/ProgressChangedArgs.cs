using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPicSorter.Objects
{
    public class ProgressChangedArgs
    {
        public string State { get; private set; }
        public string ProcessingPath { get; private set; }

        public ProgressChangedArgs(string state, string processingPath = "")
        {
            State = state;
            ProcessingPath = processingPath;
        }
    }
}
