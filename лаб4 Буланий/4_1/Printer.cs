namespace Lab4_Pr;

internal interface IPrinter
{
    void Print(params string[] value);
}

internal class Printer : IPrinter
{
    public virtual void Print(params string[] value)
    {
        foreach (var s in value)
        {
            Console.WriteLine(s);
        }
    }
}

internal sealed class PrinterChild : Printer
{
    #region Overrides of Printer

    /// <inheritdoc />
    public override void Print(params string[] value)
    {
        ConsoleColor[] consoleColors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();
        foreach (var item in value)
        {
            Console.ForegroundColor = consoleColors[new Random().Next(0, consoleColors.Length)];
            Console.WriteLine(item);
        }
    }

    #endregion
}