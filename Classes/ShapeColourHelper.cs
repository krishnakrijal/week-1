
using System.Drawing;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {

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

        private static readonly Color[] colors = new Color[] {
            Color.Yellow,
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Orange,
        }
       
        //random instance is used to generate a random index

        private static readonly Random random = new Random();

        public static Color GetRandomColor(Shape s) {
            int randomIndex = random.Next(colors.Length);
            return s.colors[randomIndex];

    }
}
