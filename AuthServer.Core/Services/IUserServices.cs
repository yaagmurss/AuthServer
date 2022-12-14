using AuthServer.Core.Dtos;
using SharedLibrary.Dtos;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IUserService
    {

        Task<ResponseDto<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<ResponseDto<UserAppDto>> GetUserByNameAsync(string userName);
    }
}
