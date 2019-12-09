using System;
using System.Collections.Generic;
using System.Text;

namespace VectorMath
{
    public class Vector3
    {
        double X;
        double Y;
        double Z;

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Vector Addition
        //functional way to add that returns the new vector result
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        //OOP way of adding that modifies the existing vector
        public void Add(Vector3 b)
        {
            this.X += b.X;
            this.Y += b.Y;
            this.Z += b.Z;
        }

        //with operator overloading
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        // Vector Subtraction 
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        // Vector Scaling 
        public static Vector3 operator *(Vector3 a, double s)
        {
            return new Vector3(a.X * s, a.Y * s, a.Z * s);
        }

        // Vector Comparison
        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return (a.X == b.X && a.Y == b.Y && a.Z == b.Z);
        }
        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }

        public override string ToString()
        {
            return $"X: {this.X} \n Y: {this.Y} \n Z: {this.Z}";
        }

        //Other operator overloading
        public static readonly Vector3 Zero = new Vector3(0, 0, 0);

        public static bool operator true(Vector3 a)
        {
            return Vector3.Zero != a;
        }
        public static bool operator false(Vector3 a)
        {
            return Vector3.Zero == a;
        }

    }
}
