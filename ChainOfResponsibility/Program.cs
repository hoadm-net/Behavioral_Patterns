namespace ChainOfResponsibility;

class Program
{
    static void Main(string[] args)
    {
        string document = "  Hello,    World! This is   a test document...  ";

        // Create handlers
        TextHandler lowercaseHandler = new LowercaseHandler();
        TextHandler punctuationHandler = new RemovePunctuationHandler();
        TextHandler whiteSpaceHandler = new RemoveMultiWhiteSpacesHandler();

        // Chain handlers
        lowercaseHandler.SetNextHandler(punctuationHandler);
        punctuationHandler.SetNextHandler(whiteSpaceHandler);

        // Process document
        string processedDocument = lowercaseHandler.Handle(document);

        Console.WriteLine("Original Document:");
        Console.WriteLine(document);

        Console.WriteLine("\nProcessed Document:");
        Console.WriteLine(processedDocument);
    }
}