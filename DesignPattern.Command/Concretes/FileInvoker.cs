

using DesignPattern.Command.Abstracts;

namespace DesignPattern.Command.Concretes
{
    public class FileInvoker : IFileInvoker
    {
        private ICommand _command=null!;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public async Task ExecuteFile()
        {
            await _command.Execute();
        }
    }

}