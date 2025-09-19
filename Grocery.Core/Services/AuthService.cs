using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IClientService _clientService;
        public AuthService(IClientService clientService)
        {
            _clientService = clientService;
        }
        public Client? Login(string email, string password)
        {
            // Haal de gegevens op
            Client? client = _clientService.Get(email);
            
            // Controleer of de klant bestaat en of het wachtwoord klopt
            if (client != null && PasswordHelper.VerifyPassword(password, client.Password)) { return client; }
            else { return null; }
        }
    }
}
