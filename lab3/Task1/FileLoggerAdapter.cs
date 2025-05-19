public class FileLoggerAdapter : Logger
{
    private FileWriter _fileOutput; 

    public FileLoggerAdapter(FileWriter fileOutput)
    {
        _fileOutput = fileOutput;
    }

    public override void Log(string message)
    {
        _fileOutput.WriteLine("[LOG] " + message);
    }

    public override void Error(string message)
    {
        _fileOutput.WriteLine("[ERROR] " + message);
    }

    public override void Warn(string message)
    {
        _fileOutput.WriteLine("[WARN] " + message);
    }
}