using DesignPattern.Command.Abstracts;
using DesignPattern.Command.Concretes.Receivers;

namespace DesignPattern.Command.Concretes.Commands
{
    public class PdfFileActionCommand : ICommand
    {
        private PdfFileAction _pdfFileAction;
        public PdfFileActionCommand(PdfFileAction pdfFileAction)
        {
            _pdfFileAction = pdfFileAction;
        }
        public async Task Execute()
        {
            await _pdfFileAction.CreatePdfFile();
        }
    }

}