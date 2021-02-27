namespace ApiCalculadora.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }

        [HttpGet]
        [Route("Add")]
        public int Add2(int numa,int numb)
        {
            return numa + numb;
        }

        [HttpPost]
        [Route("Multiply")]
        public int Multiply([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa * numb;
        }

        [HttpGet]
        [Route("Multiply")]
        public int Multiply2(int numa,int numb)
        {
            return numa * numb;
        }


        [HttpPost]
        [Route("Subtract")]
        public int Subtract([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa - numb;
        }

        [HttpGet]
        [Route("Subtract")]
        public int Subtract2(int numa,int numb)
        {
            return numa - numb;
        }

        [HttpPost]
        [Route("Division")]
        public int Division([FromHeader] int numa, [FromHeader] int numb)
        {
            if (numb == 0)
                return 0;
            return numa / numb;
        }

        [HttpGet]
        [Route("Division")]
        public int Division2(int numa,int numb)
        {
            if (numb == 0)
                return 0;
            return numa / numb;
        }

    }
}
