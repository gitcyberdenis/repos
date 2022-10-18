namespace Lab4_3;

internal class DocumentWorkerFactory
{
    public DocumentWorker GetDocumentWorker(string key)
    {
        return key switch
        {
            "pro" => new ProDocumentWorker(),
            "expert" => new ExpertDocumentWorker(),
            _ => new DocumentWorker()
        };
    }
}