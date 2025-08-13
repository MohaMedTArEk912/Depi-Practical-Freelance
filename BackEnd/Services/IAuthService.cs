using BackEnd.DTOs;

namespace BackEnd.Services
{
    public interface IAuthService
    {
        Task<AuthResponseDTO> Login(LoginDTO loginDTO);
        Task<AuthResponseDTO> Register(RegisterDTO registerDTO);
    }
}
