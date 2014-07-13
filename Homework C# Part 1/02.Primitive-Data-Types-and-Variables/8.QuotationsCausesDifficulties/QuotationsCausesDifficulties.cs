using System;

class QuotationsCausesDifficulties
{
    static void Main()
    {
        Console.WriteLine("@-quoted string literals:");
        string @Quoting=@"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(@Quoting);

        Console.WriteLine("Escape sequence \\\":");
        string escapeSequence = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(escapeSequence);
    }
}
