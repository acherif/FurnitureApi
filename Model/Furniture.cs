using System.Configuration;

namespace Model
{
    public class Furniture
    {
        public string Type { get; set; }
        public string Designer { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

        public Furniture()
        {

        }

        public Furniture(string type, string designer, int height, int weight, int price)
        {
            Type = type;
            Designer = designer;
            Height = height;
            Weight = weight;
            Price = price;
        }

        public override string ToString() {
            return Type + " " + Designer + " " + Height + " cm " + Weight + " Kg " + Price + @" € ";
        }


    }
}
