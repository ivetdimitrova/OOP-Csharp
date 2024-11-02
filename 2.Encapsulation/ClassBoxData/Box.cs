using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    public class Box
    {
        
        public Box(double length, double width, double height)
        {
            if (length < 0)
                throw new ArgumentException("Length cannot be zero or negative.");

            this.Length = length;
            
            if(width < 0)
                throw new ArgumentException("Width cannot be zero or negative.");

            this.Width = width;

            if(height < 0)
                throw new ArgumentException("Height cannot be zero or negative.");

            this.Height = height;
        }

        private double Length { get; }
        private double Width { get; }

        private double Height { get; }

        public double LateralSurfaceArea()
        {
            return (2 *this.Length * this.Height) + (2 * this.Height * this.Width);
        }
        public double SurfaceArea()
        {
            return (2 * this.Length * this.Width) + LateralSurfaceArea();
        }

        public double Volume()
        {
            return this.Width * this.Length * this.Height;
        }
    }
}
