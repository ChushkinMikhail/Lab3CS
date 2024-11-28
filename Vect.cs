// See https://aka.ms/new-console-template for more information
using System;
public struct Vector
    {
    public double x;
    public double y;
    public double z;

    public Vector(double x, double y, double z)
        {
        this.x = x;
        this.y = y;
        this.z = z;
        }

    public double Length()
        {
        return Math.Sqrt(x * x + y * y + z * z);
        }

    public static Vector operator +(Vector a, Vector b)
        {
        return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        }

    public static double operator *(Vector a, Vector b)
        {
        return a.x * b.x + a.y * b.y + a.z * b.z;
        }

    public static Vector operator *(Vector v, double scalar)
        {
        return new Vector(v.x * scalar, v.y * scalar, v.z * scalar);
        }

     public static Vector operator *(double scalar, Vector V)
        {
        return V * scalar;
        }

    public static bool operator <(Vector a, Vector b)
        {
        return a.Length() < b.Length();
        }

    public static bool operator >(Vector a, Vector b)
        {
        return a.Length() > b.Length();
        }

    public static bool operator ==(Vector a, Vector b)
        {
        return a.Length() == b.Length();
        }

    public static bool operator !=(Vector a, Vector b)
        {
        return !(a == b);
        }
    }

public class Program
    {
    public static void Main()
        {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(4, 5, 6);
        Vector v3 = new Vector(5.5, 17, 12.4);

        Vector sum = v1 + v3;
        Vector scaled = v1 * 2;
        double sas = v2 * v3;

        /*double a = sum.Length;
        double b = scaled.Length;*/

        Console.WriteLine (sum);
        Console.WriteLine (sas);
        Console.WriteLine (scaled);

        Console.WriteLine(v1 < v2);
        Console.WriteLine(v1 > v2);
        Console.WriteLine(v1 == v2);
        Console.WriteLine(v1 != v2);
        }
    }
