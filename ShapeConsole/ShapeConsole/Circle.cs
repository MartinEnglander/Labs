using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ShapeConsole
{
    public class Circle : Shape2D
    {
        private Vector2 circleCenter;
        private float circleArea;
        private float circleCircumference;
        private float circleRadius;

        public Circle(Vector2 center, float radius)
        {
            //center of the circle
            this.circleCenter = center;

            // A = pi x r2
            this.circleArea = (float)Math.PI * (radius * radius);

            //set the radius
            this.circleRadius = radius;
        }

        public override Vector3 Center
        {
            get
            {
                return new Vector3(circleCenter, 0.0f);
            }
        }

        public override float Area
        {
            get
            {
                return circleArea;
            }
        }

        public override float Circumference
        {
            //circumference of the circle (omkrets)
            get
            {
                //calculate circumference according to the formula
                //Ocirkel=2πr=πd
                return ((this.circleRadius * 2) * (float)Math.PI);
            }
        }

        public float Radius
        {
            get
            {
                return circleRadius;
            }
        }

        public override string ToString()
        {
            return "circle @(" + Center.X.ToString("0.0#") + " , " + Center.Y.ToString("0.0#") + "): r = " + Radius.ToString("0.0#");
        }
    }
}
