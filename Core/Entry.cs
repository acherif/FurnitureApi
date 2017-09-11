using Model;
using ShipmentApi;
using System;
using System.Configuration;
using System.Web.Script.Serialization;
using Util;
using System.Collections.Generic;

namespace Core
{
    public class Entry
    {


        private string fileName = ConfigurationManager.AppSettings["FileName"];

        
        public void Run(string[] args)
        {
            if (args.Length > 0 && args[0].ToLower().Equals("add"))
            {
                var f = ParserHelper.ParseConsoleInput(args);
                JsonHandler.SaveToFile(f, fileName);
                Console.Out.WriteLine("Saved in file " + fileName);
                Console.WriteLine("Press any key...");
                Console.In.ReadLine();
            }
            else
            {
                IShipment shipment = null;


                var listFurniture = JsonHandler.ReadFromFile(fileName);

                Console.WriteLine("Printing with shipment ");
                printWithNewShipment(listFurniture, shipment);

                Console.WriteLine("Printing with classic shipment ");
                shipment = new ClassicShipment();
                printWithNewShipment(listFurniture, shipment);

                Console.WriteLine("Printing with colissimo shipment ");
                shipment = new ColissimoShipment();
                printWithNewShipment(listFurniture, shipment);

                Console.WriteLine("Press any key...");
                Console.In.ReadLine();
            }

            

        }

        private void printWithNewShipment(List<Furniture> listFurniture, IShipment shipment)
        {
            bool newShipment = shipment != null ? true : false;
            foreach (var f in listFurniture)
            {
                if(newShipment)
                f.Price = shipment.Compute(f.Weight, f.Height);
                Console.Out.WriteLine(f);
            }
        }
    }
}
