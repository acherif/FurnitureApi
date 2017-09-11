using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentApi
{
    public interface IShipment
    {
        int Compute(int poids, int hauteur);
    }
}
