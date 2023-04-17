namespace DI.Service
{
    public class LogDB : ILog
    {
        public void Info(string msg)
        {
            File.AppendAllText("log-db.txt", $"{Environment.NewLine}{DateTime.Now} - {msg}");
        }
    }
}
