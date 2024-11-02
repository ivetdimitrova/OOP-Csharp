using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape: IDrawable
    {
       public  abstract double CalculatePerimeter();
       public  abstract double CalculateArea();

       public virtual string Draw()
       {
           return $"Drawing {this.GetType().Name}";
       }

    }
}
