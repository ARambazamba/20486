using Microsoft.AspNetCore.Mvc.Filters;

namespace Vouchers
{
    public class LogFilter : ActionFilterAttribute
    {
        private readonly ILog logger;
        private readonly string logName;

        public LogFilter(ILog logger, string logName)
        {
            this.logger = logger;
            this.logName = logName;
        }

        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            logger.Log(actionContext.HttpContext.Request, logName);
        }
    }
}