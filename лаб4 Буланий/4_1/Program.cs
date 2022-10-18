namespace Lab4_Pr;

internal static class Program
{
    private static readonly IPrinter Printer = new Printer();
    private static readonly IPrinter Printer2 = new PrinterChild();

    public static void Main(string[] args)
    {
        Printer.Print("Hello");
        Printer2.Print("Hello", "World");
    }
}