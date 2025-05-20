using DesignPattern.Command.Abstracts;
using DesignPattern.Command.Concretes.Receivers;

namespace DesignPattern.Command.Concretes.Commands
{
    public class WordFileActionCommand : ICommand
    {
        private WordFileAction _wordFileAction;
        public WordFileActionCommand(WordFileAction wordFileAction)
        {
            _wordFileAction = wordFileAction;
        }
        public async Task Execute()
        {
            await _wordFileAction.CreateWordFile();
        }
    }
}