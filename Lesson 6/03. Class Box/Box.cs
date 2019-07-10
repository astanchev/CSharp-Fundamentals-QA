using System.Text;

namespace _03._Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
        {
            double area = 2*(length*width) + 2*(length*height) + 2*(height*width);

            return area;
        }
        public double GetLateralSurfaceArea()
        {
            double lateralArea = 2*(length*height) + 2*(height*width);

            return lateralArea;
        }
        public double GetVolume()
        {
            double volume = this.length * this.width * this.height;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Surface Area - {this.GetSurfaceArea():f2}");
            result.AppendLine($"Lateral Surface Area - {this.GetLateralSurfaceArea():f2}");
            result.AppendLine($"Volume - {this.GetVolume():f2}");

            return result.ToString().TrimEnd();
        }
    }
}