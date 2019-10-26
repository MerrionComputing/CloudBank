using System.Threading.Tasks;

namespace CloudBank.Auth
{
    public interface ILoginService
    {

        Task Login(string token);

        Task Logout();

    }
}
