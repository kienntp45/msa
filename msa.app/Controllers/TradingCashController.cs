namespace msa.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradingCashController : ControllerBase
    {
        private readonly ITradingCashQuery _tradingCashQuery;
        private readonly Context _context;

        public TradingCashController(ITradingCashQuery tradingCashQuery, Context context)
        {
            _tradingCashQuery = tradingCashQuery ?? throw new ArgumentNullException(nameof(tradingCashQuery));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpPost("1")]
        public void add()
        {
            var i = 106;
            var value = i.ToString();
            var tradingCash = new TradingCash(value, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i);
            _context.Add(tradingCash);
            _context.SaveChanges();
        }

        [HttpGet("get-all-tradingcash")]
        public IActionResult GetAllTradingCash()
        {
            try
            {
                var lstTradingCash = _tradingCashQuery.GetAll();
                if (lstTradingCash == null)
                {
                    return StatusCode(204, "Not context");
                }
                return Ok(lstTradingCash);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("get-by-amount-tradingcash/{amount}")]
        public IActionResult GetAllTradingCashInAmout(int amount)
        {
            try
            {
                var lstTradingCash = _tradingCashQuery.GetTradingCashMemoryCaChe(amount);
                if (lstTradingCash == null)
                {
                    return StatusCode(204, "Not context");
                }
                return Ok(lstTradingCash);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("get-all-tradingcash-memory")]
        public IActionResult GetAllTradingCashMemory()
        {
            try
            {
                var lstTradingCash = _tradingCashQuery.GetTradingCashMemoryCaChe();
                if (lstTradingCash == null)
                {
                    return StatusCode(204, "Not context");
                }
                return Ok(lstTradingCash);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("get-all-tradingcash-memory-by-client-code/{clientCode}")]
        public IActionResult GetAllTradingCashMemoryById(string clientCode)
        {
            try
            {
                var tradingCash = _tradingCashQuery.GetByClientCodeInMemoryAsync(clientCode);
                return Ok(tradingCash);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("get-tradingcash-by-id")]
        public IActionResult GetTradingCashById(int id)
        {
            try
            {
                var tradingCash = _tradingCashQuery.GetByIdAsync(id);
                if (tradingCash == null)
                {
                    return StatusCode(204, "Not context");
                }
                return Ok(tradingCash);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("get-tradingcash-by-client-code")]
        public IActionResult GetTradingCashByClientCode(string clientCode)
        {
            try
            {
                var tradingCash = _tradingCashQuery.GetByClientCodeAsync(clientCode);
                if (tradingCash == null)
                {
                    return StatusCode(204, "Not context");
                }
                return Ok(tradingCash);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //[HttpPut("put")]
        //public IActionResult UpdateTradingCash([FromBody] UpdateTradingCashCommand updateTradingCashCommand)
        //{
        //    try
        //    {
        //        var result = _mediator.Send(updateTradingCashCommand);
        //        return Ok(result);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}
