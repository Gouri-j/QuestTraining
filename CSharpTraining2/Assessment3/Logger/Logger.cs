using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Loggers
{
    public class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

        static Logger()
        {
            ConfigureLogging();
        }
        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();

            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();
            var consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = Level.Info
            };
            var errorFileAppender = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "error.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Error
            };
            BasicConfigurator.Configure(repository, consoleAppender, errorFileAppender);

        }

        public static void LogInfo(string message)
        {
            log.Info(message);
        }
        public static void LogError(string message, Exception ex = null)
        {
            log.Error(message, ex);
        }
    }
}
