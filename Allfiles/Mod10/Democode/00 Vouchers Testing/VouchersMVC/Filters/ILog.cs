using Microsoft.AspNetCore.Http;

namespace Vouchers
{
    public interface ILog
    {
        void Log(HttpRequest request, string logName);
    }
}