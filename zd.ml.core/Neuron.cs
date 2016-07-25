using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd.ml.core
{
    public class Neuron
    {
        public double[] Weights { get; set; }
        public double[] PrevWeights { get; set; }
    }
}
