using MVCApplication.Core.Contracts;
using Ninject.Extensions.Interception;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApplication.Infrastructure.Interceptors
{
    public class TraceInterceptor : IInterceptor
    {
        private readonly ILogger logger;

        public TraceInterceptor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                string message = string.Format("{0}\n{1}", ex.Message, ex.StackTrace);
                logger.Error(message, ex);

                throw;
            }
        }
    }
}
