namespace PrintScaner
{

    public class Print : IPrint
    {
        void IPrint.Print(Document document)
        {
            
            Console.WriteLine($"Imprimiento docuemnto: {document.Title} by {document.Author}");

            Console.WriteLine(document.Content);
        }
    }
}