

namespace DesignPattern.Command.Abstracts
{
    public interface IFileInvoker
    {
        void SetCommand(ICommand command);
        Task ExecuteFile();
    }
}