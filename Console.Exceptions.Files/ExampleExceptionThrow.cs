namespace Console.Exceptions.Files;

using System;

public class ExampleExceptionThrow
{
    public void Logic()
    {
        new FileService();
        new FileService();
        new FileService();

        var objectException = new DivideByZeroException("Exception with LogicInvalid function.");
        
        Console.WriteLine(".....");
        LogicInvalid();
    }

    public void LogicInvalid()
    {
        Console.WriteLine("LogicInvalid function");
        throw new MyException() { MyInfo = "123123" };
    }
}
