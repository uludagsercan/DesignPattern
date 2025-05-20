using DesignPattern.Command.Abstracts;
using DesignPattern.Command.Concretes.Receivers;

namespace DesignPattern.Command.Concretes.Commands
{
    public class ExcelFileActionCommand : ICommand
    {
        private ExcelFileAction _excelFileAction;
        public ExcelFileActionCommand(ExcelFileAction excelFileAction)
        {
            _excelFileAction = excelFileAction;
        }
        public async Task Execute()
        {
            await _excelFileAction.CreateExcelFile();
        }
    }
}