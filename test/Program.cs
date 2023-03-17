// See https://aka.ms/new-console-template for more information
//  variables
using System;

class Program {


    static void Main() {

        double ax, ay, bx, by, cx, cy;
        double ab, bc, ac, perimeter;

        Console.WriteLine("Test\n");
        //Ask the coodinates to the user
        Console.WriteLine("Enter a coordinate x of dot A");
        ax = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a coordinate y of dot A");
        ay = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a coordinate x of dot B");
        bx = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a coordinate y of dot B");
        by = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a coordinate x of dot C");
        cx = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a coordinate y of dot C");
        cy = Convert.ToDouble(Console.ReadLine());

        //Give the length from the coodinates given 
        Console.WriteLine("The length of triangle sides\n");
        ab = DotDistance(ax, ay, bx, by);
        Console.WriteLine("Length of side AB is: {0:0.##}", ab);
        bc = DotDistance(bx, by, cx, cy);
        Console.WriteLine("Length of side BC is: {0:0.##}", bc);
        ac = DotDistance(ax, ay, cx, cy);
        Console.WriteLine("Length of side CA is: {0:0.##}\n", ac);

        //Check if the triangle is Equilateral
        CheckEquilateral(ab, bc, ac);
        // Calculate the perimeter to the triangle
        perimeter=CalculatePerimeter(ab, bc, ac);
        // Check if the triangle is Isosceles
        CheckIsosceles(ab, bc, ac);
        // Check if the triangle is right
        CheckRight(ab, bc, ac);
        //even numbers from 0 to perimeter value
        EvenNumbers(perimeter);
    }

    static double DotDistance(double x1, double y1, double x2, double y2)
    {
        double distance ;
        distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        return (distance);
    }

    static void CheckEquilateral(double AB, double BC, double AC)
    {
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

