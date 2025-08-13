namespace BackEnd.DTOs
{
    public class AuthResponseDTO
    {
        public required string Token { get; set; }
        public required string Username { get; set; }
        public required string Role { get; set; }
        public long Id { get; set; }
    }
}
