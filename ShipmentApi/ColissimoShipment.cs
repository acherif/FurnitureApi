using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentApi
{
    public class ColissimoShipment : IShipment
    {
        private const double heightFactor = 0.001;
        private const double weightFactor = 0.55;

        public int Compute(int weight, int height)
        {
            return (int) (weight * weightFactor + height * heightFactor);
        }
    }
}
