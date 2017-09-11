using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentApi
{
    public class ClassicShipment : IShipment
    {
        private const double heightFactor = 0.001;

        public int Compute(int weight, int height)
        {
            return (int) (weight * height * heightFactor);
        }
    }
}
