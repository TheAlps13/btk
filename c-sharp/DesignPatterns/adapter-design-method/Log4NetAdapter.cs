namespace adapter_design_method
{
    class Log4NetAdapter : ILogger
    {
        Log4Net _log4net = new();
        public void Log(string message)
        {
            _log4net.LogMessage(message);
        }
    }
}
