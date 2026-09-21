using Digital_Shop_Software.Data.Repositories;

namespace Digital_Shop_Software.Services
{
    internal class UserService
    {
        private readonly UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }

        public (string Username, string Password)? GetUserByUsername(string username)
        {
            return userRepository.GetUserByUsername(username);
        }

        public int GetUserId(string username)
        {
            return userRepository.GetUserId(username);
        }

        public void UpdatePassword(string username, string passwordHash)
        {
            userRepository.UpdatePassword(username, passwordHash);
        }

        public string? GetSecurityQuestionAnswer(string username)
        {
            return userRepository.GetSecurityQuestionAnswer(username);
        }

        public string? GetSecurityQuestion(string username)
        {
            return userRepository.GetSecurityQuestion(username);
        }

        public string? GetPosition(string username)
        {
            return userRepository.GetPosition(username);
        }

        public List<Dictionary<string, object>> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public void AddUser(
            string position,
            string username,
            string passwordHash,
            string dob,
            string sex,
            string email,
            string phoneNumber,
            string securityQuestion,
            string securityAnswer)
        {
            userRepository.AddUser(
                position,
                username,
                passwordHash,
                dob,
                sex,
                email,
                phoneNumber,
                securityQuestion,
                securityAnswer);
        }

        public void RemoveUser(int userId)
        {
            userRepository.RemoveUser(userId);
        }

        public void ModifyUser(
            int userId,
            string position,
            string username,
            string passwordHash,
            object dob,
            string sex,
            string email,
            string phoneNumber,
            string securityQuestion,
            string securityAnswer)
        {
            userRepository.ModifyUser(
                userId,
                position,
                username,
                passwordHash,
                dob,
                sex,
                email,
                phoneNumber,
                securityQuestion,
                securityAnswer);
        }
    }
}
