using System;

class UnicodeCode
{
    static void Main()
    {
        int uniCode = 72;
        Console.WriteLine("The symbole of "+uniCode+" is "+(char)uniCode+".");

        string hexString = uniCode.ToString("X");
        Console.WriteLine("The hexadecimal representation of 72 is "+hexString+".");
    }
}

