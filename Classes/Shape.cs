
namespace Week1ObjectOriented.Classes
{
    public abstract class Shape
    {
        private int area;

        public abstract double GetArea();
       

        public void SetArea(int Area)
        {
            area = Area;
        }

        public string? Colour { get; set; }
    }
}
