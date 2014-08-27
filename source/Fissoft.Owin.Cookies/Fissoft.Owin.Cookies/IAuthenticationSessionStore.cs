

using System.Threading.Tasks;
using Microsoft.Owin.Security;

namespace Fissoft.Owin.Cookies
{
    public interface IAuthenticationSessionStore
    {
        Task<string> StoreAsync(AuthenticationTicket ticket);
        Task RenewAsync(string key, AuthenticationTicket ticket);
        Task<AuthenticationTicket> RetrieveAsync(string key);
        Task RemoveAsync(string key);
    }
}
