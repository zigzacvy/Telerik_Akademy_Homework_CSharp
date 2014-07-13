using System;

class IsoscelesTriangleOf9
{
    static void Main()
    {
        Console.WriteLine("Isosceles triangle of 9:");
        char hexChar = '\u00a9';
                       
        Console.WriteLine(@"
          {0:x}
         {0:x}{0:x}{0:x}
        {0:x}{0:x}{0:x}{0:x}{0:x}", hexChar);
    }                                               
}
