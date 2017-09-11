using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class ParserHelper
    {

        //input in the form : Add type designer heigth weigt price
        public static Furniture ParseConsoleInput(string[] input)
        {
            Furniture m = new Furniture();
            m.Type = input[1];
            m.Designer = input[2];
            m.Height = int.Parse(input[3]);
            m.Weight = int.Parse(input[4]);
            m.Price = int.Parse(input[5]);

            return m;
        }
    }
}
