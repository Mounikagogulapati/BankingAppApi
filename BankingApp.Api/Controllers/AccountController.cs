using BankingApp.Api.Filters;
using BankingApp.Interfaces.BL;
using BankingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IBAccount _bAccount = null;
        public AccountController(IBAccount bAccount)
        {
            _bAccount = bAccount;
        }

        [CustomAuthorizationFilter]
        [Route("AccLogin")]
        [HttpPost]        
        public IActionResult AccLogin(AccountLogin accountLogin)
        {
            //BSmartMeter bSmartMeter = new BSmartMeter();
            var response = _bAccount.VerifyLogin(accountLogin);
            return Ok(response);
        }
    }
}
