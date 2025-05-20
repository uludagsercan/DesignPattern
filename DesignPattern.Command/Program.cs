
using DesignPattern.Command.Abstracts;
using DesignPattern.Command.Concretes;
using DesignPattern.Command.Concretes.Commands;
using DesignPattern.Command.Concretes.Receivers;

IFileInvoker fileInvoker = new FileInvoker();
ICommand pdfFileActionCommand = new PdfFileActionCommand(new PdfFileAction());
ICommand excelFileActionCommand = new ExcelFileActionCommand(new ExcelFileAction());
ICommand wordFileActionCommand = new WordFileActionCommand(new WordFileAction());
fileInvoker.SetCommand(pdfFileActionCommand);
await fileInvoker.ExecuteFile();
fileInvoker.SetCommand(excelFileActionCommand);
await fileInvoker.ExecuteFile();
fileInvoker.SetCommand(wordFileActionCommand);
await fileInvoker.ExecuteFile();