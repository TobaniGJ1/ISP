using Interfaces;
using PrintScaner;

public class Document
{
    public string Title { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }

    public Document(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Document doc1 = new Document("Se esta usando la impresora SimplePrinter", "Imprimiendo", "Tobani Gonzalez");

        Document doc2 = new Document("Se esta usando la impresora MultiFunctionPrinter", "Escaneando", "Diego Gonzalez");

        Document doc3 = new Document("Se esta usando la impresora MultiFunctionPrinter", "Imprimiendo", "Camila Gonzalez");

        IPrint simplePrinter = new Print();
        simplePrinter.Print(doc1);

        Scan multiFunctionPrinter = new Scan();
        multiFunctionPrinter.Print(doc3);
        multiFunctionPrinter.PrintScan(doc2);

    }
}