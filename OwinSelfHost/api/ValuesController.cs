using System.Collections.Generic;
using System.Web.Http;

namespace OwinSelfHost
{

    public class ValuesController:ApiController
    {
        public IEnumerable<string> Get()
        {
            return new List<string> { "ASP.NET", "Docker", "Windows Containers" };
        }

    }
}
