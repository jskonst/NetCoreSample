namespace HelloWorld.Controllers
{
    using System.Linq;
    using HelloWorld.Models;
    using Microsoft.AspNetCore.Mvc;

    public class DemoController : Controller
    {
        public string Dummy(int id)
        {
            return $"id++={id + 1}";
        }

        public string RequestDummy()
        {
            int id = int.Parse(Request.Query.FirstOrDefault(p => p.Key == "id").Value);
            return $"id++={id + 1}";
        }
    }
}