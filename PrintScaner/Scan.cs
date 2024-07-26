using ISP.Interfaces;

namespace PrintScaner
{
    public class Scan : IPrint, IScan
    {
        public void Print(Document document)
        {

            Console.WriteLine($"Imprimiento documento: {document.Title} by {document.Author}");
            Console.WriteLine(document.Content);
        }

        public void PrintScan(Document document)
        {
            Console.WriteLine($"Scaneando documento: {document.Title} by {document.Author}");
            Console.WriteLine(document.Content);
        }


    }
}