namespace Lab4_3;

internal static class Program
{
    private static void Main(string[] args)
    {
        DocumentWorkerFactory factory = new();
        Console.WriteLine("Enter the type of document: ");
        Console.WriteLine("1 - Pro");
        Console.WriteLine("2 - Expert");
        Console.WriteLine("3 - Free");

        var type = Console.ReadLine();
        DocumentWorker document = factory.GetDocumentWorker(type);
        document.OpenDocument();
        document.EditDocument();
        document.SaveDocument();
        Console.ReadKey();
    }
}