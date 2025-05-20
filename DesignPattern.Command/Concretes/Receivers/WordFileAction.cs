

namespace DesignPattern.Command.Concretes.Receivers
{
    public class WordFileAction
    {

        public Task CreateWordFile()
        {
            Console.WriteLine("Word file created.");
            return Task.CompletedTask;
        }
    }
}