using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Api.Filters
{
    public class CustomAuthorizationFilter : TypeFilterAttribute
    {
        public CustomAuthorizationFilter()
        : base(typeof(AuthorizeActionFilter))
        {

        }
    }
}
