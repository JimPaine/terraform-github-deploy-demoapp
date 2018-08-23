using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace Demo
{
    public static class Function
    {
        [FunctionName("DemoFunc")]        
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post")]HttpRequest request)
        {
            return new OkObjectResult("How on earth?");
        }
    }
}