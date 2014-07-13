using System;


class InCircleOutRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the x coordinate of the point \"A\":");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the y coordinate of the point \"A\":");
        float y = float.Parse(Console.ReadLine());

        if((Math.Sqrt((x-1)*(x-1)+(y-1)*(y-1)))<3 && y<-1 && y>1 && x<-1 && x>5)
        {
            Console.WriteLine("A is within the circle and outside the rectangle.");
        }
        else
        {
            Console.WriteLine("A is within the rectangle.");
        }
    }
}

//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
