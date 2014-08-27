using Microsoft.Owin;
using Microsoft.Owin.Infrastructure;

namespace Fissoft.Owin.Cookies
{
    public class FisCookieManager : ICookieManager
    {
        public string GetRequestCookie(IOwinContext context, string key)
        {
            throw new System.NotImplementedException();
        }

        public void AppendResponseCookie(IOwinContext context, string key, string value, CookieOptions options)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCookie(IOwinContext context, string key, CookieOptions options)
        {
            throw new System.NotImplementedException();
        }
    }
}