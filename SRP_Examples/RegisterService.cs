using System;

namespace SRP_Examples
{
    public class RegisterService
    {
        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            UserRepository _userRepository = new UserRepository();
            _userRepository.Insert(...);

            EmailService _emailService = new EmailService();
            _emailService.Send(...);
        }
    }
}
