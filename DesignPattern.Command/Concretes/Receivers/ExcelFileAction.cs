

namespace DesignPattern.Command.Concretes.Receivers
{
    public class ExcelFileAction
    {
        
        public Task CreateExcelFile()
        {
            Console.WriteLine("Excel file created.");
            return Task.CompletedTask;
        }
    }
}