using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Text;

namespace BankingApp.Api.Filters
{
    public class AuthorizeActionFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                var base64Token = context.HttpContext.Request.Headers["Authorization"].ToString();
                var encoding = Encoding.GetEncoding("iso-8859-1");
                var authorization = base64Token;
                if (authorization.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        var authToken = authorization.Substring("Bearer ".Length).Trim();
                        //var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Jwt:Key"]));
                        //TokenValidationParameters validationParameters = new TokenValidationParameters
                        //{
                        //    ValidateIssuer = true,
                        //    ValidateAudience = true,
                        //    ValidateLifetime = true,
                        //    ValidateIssuerSigningKey = true,
                        //    ValidIssuer = _config["Jwt:Issuer"],
                        //    ValidAudience = _config["Jwt:Issuer"],
                        //    IssuerSigningKey = securityKey,
                        //    RequireExpirationTime = false
                        //};
                        //ClaimsPrincipal jwtPrincipal = new JwtSecurityTokenHandler().ValidateToken(authToken, validationParameters, out SecurityToken validatedToken);
                        //if (jwtPrincipal == null)
                        //{
                        //    HandleUnauthorized(context);
                        //    return;
                        //}
                        //ClaimsIdentity identity = ((ClaimsIdentity)jwtPrincipal.Identity);
                        //var dbName = identity.Claims.FirstOrDefault(i => i.Type == "DBName").Value;

                        //User user = _bUser.CheckUserLogin(null, authToken);
                        //if (user != null)
                        //{
                        //    user.Token = authToken;
                        //    _bUser.UpdateAuthToken(user);
                        //    var identity = new ClaimsIdentity();
                        //    identity.AddClaim(new Claim(ClaimTypes.Name, user.DbName));
                        //    identity.AddClaim(new Claim("LOGGEDIN", user.UserName));
                        //    var principal = new ClaimsPrincipal(identity);
                        //    Thread.CurrentPrincipal = principal;
                        //    context.HttpContext.Response.Headers.Add("token", user.Token);
                        //    return;
                        //    //DateTime currendDateTime = Utils.GetCurrentDateTime(DateTime.Now);
                        //    //if (user.Expiration.Value > currendDateTime)
                        //    //{
                        //    //    user.Token = authToken;
                        //    //    _bUser.UpdateAuthToken(user);
                        //    //    var identity = new ClaimsIdentity();
                        //    //    identity.AddClaim(new Claim(ClaimTypes.Name, user.DbName));
                        //    //    identity.AddClaim(new Claim("LOGGEDIN", user.UserName));                                
                        //    //    var principal = new ClaimsPrincipal(identity);
                        //    //    Thread.CurrentPrincipal = principal;                                                                
                        //    //    context.HttpContext.Response.Headers.Add("token", user.Token);
                        //    //    return;
                        //    //}
                        //    //else
                        //    //{
                        //    //    context.Result = new JsonResult("Token expired!!");
                        //    //    return;
                        //    //}
                        //}
                        //else
                        //{
                        //    HandleUnauthorized(context);
                        //    return;
                        //}
                    }
                    catch
                    {
                        HandleUnauthorized(context);
                        return;
                    }
                }
                else
                {
                    HandleUnauthorized(context);
                    return;
                }
            }
            else
            {
                HandleUnauthorized(context);
                return;
            }
        }
        void HandleUnauthorized(AuthorizationFilterContext actionContext)
        {
            actionContext.Result = new UnauthorizedResult();
        }
    }
}
