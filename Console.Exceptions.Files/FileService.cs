namespace Console.Exceptions.Files;

using System;
using System.IO;

public class FileService : IDisposable
{
    private readonly StreamWriter _streamWriter = new StreamWriter("text.txt");

    public FileService() { }

    ~FileService()
    {
        _streamWriter.Dispose();
        Console.WriteLine("Finalizer of FileService");
    }

    public void Dispose()
    {
        _streamWriter.Dispose();
    }
}

