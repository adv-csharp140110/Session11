using DI.Service;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        public ILog Log { get; }

        public SampleController(ILog log)
        {
            Log = log;
            
        }


        [HttpGet()]
        public string Get()
        {
            //var log = new Log();
            Log.Info("ip: " + Request.Path);

            return "Hello World!";
        }
    }


    class SampleControllerTest {
        void Test1() {
            var ctrl = new SampleController(new LogEmpty());
            if(ctrl.Get() == "Hello World!")
            {
                //
            }
        }

    }
}
