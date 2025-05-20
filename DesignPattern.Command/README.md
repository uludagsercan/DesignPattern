# Command Design Pattern

This project demonstrates the **Command Design Pattern** in C#. The pattern is used to encapsulate requests as objects, allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations.

## Structure

- **ICommand**: Interface that defines the `Execute` method.
- **ExcelFileActionCommand, PdfFileActionCommand, WordFileActionCommand**: Concrete command classes that implement `ICommand`. Each class is responsible for executing a specific file creation action (Excel, PDF, Word).
- **FileInvoker**: Invoker class that holds a command and executes it. The command can be set dynamically, allowing the invoker to execute different actions at runtime.

## Example Usage

```csharp
var excelAction = new ExcelFileAction();
var excelCommand = new ExcelFileActionCommand(excelAction);

var invoker = new FileInvoker();
invoker.SetCommand(excelCommand);
await invoker.ExecuteFile();
```

## Benefits

- Makes it easy to add new commands without changing existing code.
- Supports extensibility and maintainability.

## Related Patterns

- **Invoker**: Responsible for executing commands.
- **Command**: Encapsulates a request as an object.
- **Receiver**: The object that performs the actual action (e.g., `ExcelFileAction`, `PdfFileAction`, `WordFileAction`).

---

This implementation is a practical example of how to use the Command Pattern for file operations in C#.
