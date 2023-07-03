namespace RateForProfessor.Services.Interfaces
{
    public interface IGoogleAuthenticationService
    {
        public Task Login(string email);
        public Task GoogleResponse();
        public Task LogOut();
    }
}
