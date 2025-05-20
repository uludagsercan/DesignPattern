

namespace DesignPattern.Command.Concretes.Receivers
{
    public class PdfFileAction
    {
        public Task CreatePdfFile()
        {
            Console.WriteLine("PDF file created.");
            return Task.CompletedTask;
        }
    }
}