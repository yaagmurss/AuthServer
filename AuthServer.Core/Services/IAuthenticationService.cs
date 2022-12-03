using AuthServer.Core.Dtos;
using SharedLibrary.Dtos;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<ResponseDto<TokenDto>> CreateTokenAsync(LoginDto loginDto);

        Task<ResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

        Task<ResponseDto<NoDataDto>> RevokeRefreshToken(string refreshToken);

        ResponseDto<ClientTokenDto> CreateTokenByClient(ClientLoginDto clientLoginDto);
    }
}
