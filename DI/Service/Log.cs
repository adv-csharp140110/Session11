namespace DI.Service
{
    public class Log : ILog
    {
        public void Info(string msg)
        {
            File.AppendAllText("log.txt", $"{Environment.NewLine}{DateTime.Now} - {msg}");
        }
    }
}
