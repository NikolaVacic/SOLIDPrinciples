using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ovom klasom izvalicmo output iz AreaCalculatora i time ne krsimo SingleResp princip.

namespace SingleResponsiblity
{
    class SumCalculatorOutputter
    {
        private AreaCalculator ac;

        public SumCalculatorOutputter(AreaCalculator other)
        {
            this.ac = other;
        }

        public void JSON() { 
            // implementirati logiku ako zelimo JSON output
        }

        public void HTML() { 
            // implementirati logiku ako zelimo HTML output
        }

    }
}
