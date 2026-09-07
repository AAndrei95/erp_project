using Digital_Shop_Software;
using Xunit;

namespace Digital_Shop_Software.Tests
{
    public class PasswordHasherTests
    {
        [Fact]
        public void HashPassword_ShouldReturnHashedPassword()
        {
            string password = "MyPassword123";
            string hash = PasswordHasher.HashPassword(password);

            Assert.NotEmpty(hash);
            Assert.Contains(":", hash);
        }

        [Fact]
        public void VerifyPassword_ShouldReturnTrueForCorrectPassword()
        {
            string password = "MyPassword123";
            string hash = PasswordHasher.HashPassword(password);
            bool result = PasswordHasher.VerifyPassword(password, hash);

            Assert.True(result);
        }

        [Fact]
        public void VerifyPassword_ShouldReturnFalseForIncorrectPassword()
        {
            string password = "MyPassword123";
            string incorrectPassword = "WrongPassword123";
            string hash = PasswordHasher.HashPassword(password);
            bool result = PasswordHasher.VerifyPassword(incorrectPassword, hash);

            Assert.False(result);
        }

        [Fact]
        public void HashPassword_ShouldGenerateDifferentHashesForSamePassword()
        {
            string password = "MyPassword123";
            string firstHash = PasswordHasher.HashPassword(password);
            string secondHash = PasswordHasher.HashPassword(password);

            Assert.NotEqual(firstHash, secondHash);
        }
    }
}
