using System.Threading.Tasks;
using TRMDesktopUI.Library.Models;

namespace RMSDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}