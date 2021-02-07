using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ShapeConsole
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
    }

    public abstract class Shape2D:Shape
    {
        public abstract float Circumference
        { 
            get;
        }
    }

    public abstract class Shape3D:Shape
    {
        public abstract float Volume 
        {
            get;
        }
    }

   
}
