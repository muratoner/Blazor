using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace JavascriptInterop.Shared
{
    public class DotNetDataForJs
    {
        [JSInvokable]
        public static DateTime GetCurrenctTime()
        {
            return DateTime.Now;
        }
        
        [JSInvokable("GetCurrentTimeAsync")]
        public async static Task<DateTime> GetCurrentTimeAsync()
        {
            return await Task.FromResult<DateTime>(DateTime.Now);
        }
    }
}
