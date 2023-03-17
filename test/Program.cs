// See https://aka.ms/new-console-template for more information
//  variables
using System;

class Program {


    static void Main() {

        int Ax, Ay, Bx, By, Cx, Cy = 0;
        double AB, BC, AC, perimeter = 0;

        Console.WriteLine("Test\n");
        //Ask the coodinates to the user
        Console.WriteLine("Enter a coordinate x of dot A");
        Ax = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a coordinate y of dot A");
        Ay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a coordinate x of dot B");
        Bx = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a coordinate y of dot B");
        By = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a coordinate x of dot C");
        Cx = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a coordinate y of dot C");
        Cy = Convert.ToInt32(Console.ReadLine());

        //Give the length from the coodinates given 
        Console.WriteLine("The length of triangle sides\n");
        AB = DotDistance(Ax, Ay, Bx, By);
        Console.WriteLine("Length of side AB is: {0:0.##}", AB);
        BC = DotDistance(Bx, By, Cx, Cy);
        Console.WriteLine("Length of side BC is: {0:0.##}", BC);
        AC = DotDistance(Ax, Ay, Cx, Cy);
        Console.WriteLine("Length of side CA is: {0:0.##}\n", AC);

        //Check if the triangle is Equilateral
        CheckEquilateral(AB, BC, AC);
        // Calculate the perimeter to the triangle
        perimeter=CalculatePerimeter(AB, BC, AC);
        // Check if the triangle is Isosceles
        CheckIsosceles(AB, BC, AC);
        // Check if the triangle is right
        CheckRight(AB, BC, AC);
        //even numbers from 0 to perimeter value
        EvenNumbers(perimeter);
    }

    static double DotDistance(double x1, double y1, double x2, double y2)
    {
        double distance = 0;
        distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        //distance = Convert.ToInt32(distance);
        return (distance);
    }

    static void CheckEquilateral(double AB, double BC, double AC)
    {
        // bool flag = false;
        if ((AB == BC) && (BC == AC))
        {
            Console.WriteLine("The triangle is Equilateral \n");
        }
        else
            Console.WriteLine("The triangle is NOT Equilateral \n");

    }

    static double CalculatePerimeter(double AB, double BC, double AC)
    {
      
        double perimeter = AB + BC + AC;
        Console.WriteLine("The perimeter of this triangle is: {0:0.##}\n", perimeter);
        return perimeter;
    }

    static void CheckIsosceles(double AB, double BC, double AC)
    {

        if (AB == BC || AB == AC)
        {
            Console.WriteLine("The triangle is Isosceles\n");
        }
        else
            Console.WriteLine("The triangle is NOT Isosceles \n");

    }

    static void CheckRight(double AB, double BC, double AC)
    {
        if (Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2)) <= 0.9)
        {
            Console.WriteLine("The triangle is Rigth \n");
        }
        else
            Console.WriteLine("The triangle is NOT Rigth \n");
    }

    static void EvenNumbers(double num)
    {
        Convert.ToInt32(num);
        for (int i = 0; i <= num; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}

