using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapihw1.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        public string rose()
        {
            return "Rose";

        }
        public string lily()
        {
            return "lily";

        }
        public string tulip()
        {
            return "tulip";

        }
        public string orchid()
        {
            return "orchid";

        }
    }
}
