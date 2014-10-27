using MVCApplication.Core.Contracts;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApplication.Infrastructure.Logging
{
    public class NLogLogger : ILogger
    {
        private Logger logger = null;

        public NLogLogger(string name)
        {
            this.logger = LogManager.GetLogger(name);
        }

        public void Trace(string message)
        {
            this.logger.Trace(message);
        }

        public void Debug(string message)
        {
            this.logger.Debug(message);
        }

        public void Info(string message)
        {
            this.logger.Info(message);
        }

        public void Warn(string message)
        {
            this.logger.Warn(message);
        }

        public void Warn(string message, Exception exception)
        {
            this.logger.Warn(message, exception);
        }

        public void Error(string message, Exception exception)
        {
            this.logger.Error(message, exception);
        }

        public void Fatal(string message, Exception exception)
        {
            this.logger.Fatal(message, exception);
        }
    }
}
