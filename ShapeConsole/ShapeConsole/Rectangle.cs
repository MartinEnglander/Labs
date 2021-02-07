using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ShapeConsole
{
    public class Rectangle : Shape2D
    {
        private Vector2 rectangleCenter;
        private Vector2 rectangleSize;
        private float rectangleArea;
        private float rectangleWidth;
        private float rectangleHeight;

        public Rectangle(Vector2 center, Vector2 size)
        {
            //center of the rectangle
            this.rectangleCenter = center;

            //size of the rectangle
            this.rectangleSize = size;

            //area of the rectangle acc. to width x height
            this.rectangleArea = size.X * size.Y;

            //set width and height
            this.rectangleWidth = size.X;
            this.rectangleHeight = size.Y;
        }

        public Rectangle(Vector2 center, float width)
        {
            //center of the circle
            this.rectangleCenter = center;

            //area of the rectangle acc. to width x height
            this.rectangleArea = width * width;

            //set width and height
            this.rectangleWidth = width;
            this.rectangleHeight = width;
        }

        public override Vector3 Center
        {
            get
            {
                return new Vector3(rectangleCenter, 0.0f);
            }
        }

        public override float Area
        {
            get
            {
                return rectangleArea;
            }
        }

        public override float Circumference
        {
            //circumference of the circle (omkrets)
            get
            {
                return 0.0F;
            }
        }


        public override string ToString()
        {
            //alter the output depending on whether it´s a square form or not
            if(!IsSquare(rectangleSize))
            {
                return "rectangle @(" + Center.X.ToString("0.0#") + " , " + Center.Y.ToString("0.0#") + "): w = " + this.rectangleWidth.ToString("0.0#") + " , h = " + this.rectangleHeight.ToString("0.0#");
            }
            else
            {
                return "rectangle @(" + Center.X.ToString("0.0#") + " , " + Center.Y.ToString("0.0#") + "): w = " + this.rectangleWidth.ToString("0.0#") + " , h = " + this.rectangleHeight.ToString("0.0#") + "  square";
            }

        }

        //check if the rectangle is a square
        public bool IsSquare (Vector2 dimension)
        {
            if (dimension.X == dimension.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
