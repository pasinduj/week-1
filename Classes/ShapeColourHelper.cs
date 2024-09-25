
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {

        static string[] RColors = { "Yellow", "Red", "Blue", "Green","Orange" };

        public static Shape AddColour(Shape s)
        {
            s.Colour = "Red";

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = "Blue";

            return s;
        }

        public static Shape RandomColour(Shape s)
        {
            // random number generated and pick Random color here
            var random = new Random();
            int rNumber = random.Next(0, 4);
            s.Colour = RColors[rNumber];
            return s;
        }


    }
}
