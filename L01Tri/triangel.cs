using System;
using System.Linq;
using System.Collections.Generic;

public struct Point//struct. Likt en klass. 
{
    public int x, y;

    public Point(int a, int b)//a och b är koordinater på en punkt
    {
        x = a;
        y = b;
    }
}

public class Triangle
{
    double[] sides;

    public Triangle(double a, double b, double c)
    {
        sides = new double[] { a, b, c };
    }

    public Triangle(double[] s)
    {
        sides = new double[s.Length];
        for (int i = 0; i < s.Length; i++)
            sides[i] = s[i];
    }

    public Triangle(Point a, Point b, Point c) //skapa tre variabler av typen Point. Se till att de har värden. Skicka med dem!
    {
        //Math.Pow tar det ena argumentet ex (double)(b.x - a.x) upphöjt till det andra argumentet (2.0)
        sides = new double[3];
        sides[0] = Math.Sqrt(Math.Pow((double)(b.x - a.x), 2.0) + Math.Pow((double)(b.y - a.y), 2.0));
        sides[1] = Math.Sqrt(Math.Pow((double)(b.x - c.x), 2.0) + Math.Pow((double)(b.y - c.y), 2.0));
        sides[2] = Math.Sqrt(Math.Pow((double)(c.x - a.x), 2.0) + Math.Pow((double)(c.y - a.y), 2.0));
    }

    public Triangle(Point[] s)
    {
        sides = new double[s.Length];
        sides[0] = Math.Sqrt(Math.Pow((double)(s[1].x - s[0].x), 2.0) + Math.Pow((double)(s[1].y - s[0].y), 2.0));
        sides[1] = Math.Sqrt(Math.Pow((double)(s[1].x - s[2].x), 2.0) + Math.Pow((double)(s[1].y - s[2].y), 2.0));
        sides[2] = Math.Sqrt(Math.Pow((double)(s[2].x - s[0].x), 2.0) + Math.Pow((double)(s[2].y - s[0].y), 2.0));
    }

    private int uniqueSides()
    {
        return sides.Distinct<double>().Count();//Kastar bort dubbletter. Hur många unika värden finns?
    }
    //Scalene = inte några lika sidor
    public bool isScalene()
    {
        if (uniqueSides() == 3)
            return true;
        return false;
    }
    //Equilateral = liksidig
    public bool isEquilateral()
    {
        if (uniqueSides() == 1)
            return true;
        return false;
    }
    //Isosceles = likbent
    public bool isIsosceles()
    {
        if (uniqueSides() == 2)
            return true;
        return false;
    }
}

/* Exempel på användning: */
/* class Program { */
/*   static void Main(string[] args) { */
/*     double[] input = new double[3]; */
/*     for(int i=0;i<3;i++) */
/*       input[i]=double.Parse(args[i]); */

/*     Triangle t = new Triangle(input); */

/*     if(t.isScalene()) Console.WriteLine("Triangeln har inga lika sidor"); */
/*     if(t.isEquilateral()) Console.WriteLine("Triangeln är liksidig"); */
/*     if(t.isIsosceles()) Console.WriteLine("Triangeln är likbent"); */
/*  } */
/* } */
