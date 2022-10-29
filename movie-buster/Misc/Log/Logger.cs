using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace movie_buster.Misc.Log
{
    public class Logger
    {

        private static ILogger<Program> iLogger = InitILogger();

        public Logger () { }

        private static ILogger<Program> InitILogger()
        {
            ServiceProvider serviceProvider = new ServiceCollection()
               .AddLogging((loggingBuilder) => loggingBuilder
                   .SetMinimumLevel(LogLevel.Trace)
                   .AddConsole()
                   )
               .BuildServiceProvider();

            return serviceProvider.GetService<ILoggerFactory>().CreateLogger<Program>();
        }

        public void LogInfo(string str)
        {
            iLogger.LogInformation(str);
        }

        public void LogDebug(string str)
        {
            iLogger.LogDebug(str);
        }
    }
}
