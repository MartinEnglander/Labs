using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ShapeConsole
{
    public class Triangle:Shape2D
    {
            private Vector2 triangleCenter;
            private float triangleArea;
            private Vector2 triangleP1;
            private Vector2 triangleP2;
            private Vector2 triangleP3;

            public Triangle (Vector2 p1, Vector2 p2, Vector2 p3)
            {

                //calculate the gravity center of the triangle
                //Using Averaged Coordinates

                //1. Determine the coordinates of the three vertices of the triangle
                this.triangleP1 = p1;
                this.triangleP2 = p2;
                this.triangleP3 = p3;

                //2. Add the value of the x-coordinates.
                float xCoords = this.triangleP1.X + this.triangleP2.X + this.triangleP3.X;

                //3. Add the value of the y-coordinates
                float yCoords = this.triangleP1.Y + this.triangleP2.Y + this.triangleP3.Y;

                //4. Find the average of the x- and y-coordinates.
                float avgX = xCoords / 3;
                float avgY = yCoords / 3;

                //5. Use the averaged x and y coordinates as a centroid or center of mass
                this.triangleCenter = new Vector2(avgX, avgY);

                // arean av en triangel = basen · höjden / 2
                this.triangleArea = ((p3.X - p1.X) * p2.Y) / 2;
            }

            public override Vector3 Center
            {
                get
                {
                    return new Vector3(triangleCenter, 0.0f);
                }
            }

            public override float Area
            {
                get
                {
                    return triangleArea;
                }
            }

            public override float Circumference
            {
                //circumference of the triangle (omkrets)
                get
                {
                    //calculate circumference according to the formula
                    //a + b + c

                    //side a, b and c
                    float a = Vector2.Distance(triangleP1, triangleP2);
                    float b = Vector2.Distance(triangleP2, triangleP3);
                    float c = Vector2.Distance(triangleP1, triangleP3);

                    return (a + b + c);
                }
            }


            public override string ToString()
            {
                return "triangle @(" + triangleCenter.X.ToString("0.0#") + " , " + triangleCenter.Y.ToString("0.0#") +"): p1(" + triangleP1.X.ToString("0.0#") +" , " + triangleP1.Y.ToString("0.0#") + "): p2(" + triangleP2.X.ToString("0.0#") + " , " + triangleP2.Y.ToString("0.0#") + "): p3(" + triangleP3.X.ToString("0.0#") + " , " + triangleP3.Y.ToString("0.0#") + ")";
            }
    }
}
