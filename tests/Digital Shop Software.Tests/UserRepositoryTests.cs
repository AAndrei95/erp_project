using Digital_Shop_Software.Data.Repositories;
using Xunit;

namespace Digital_Shop_Software.Tests
{
    public class UserRepositoryTests
    {
        [Fact]
        public void AddUser_ShouldAllowUserToBeRetrievedByUsername()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository repository = new UserRepository();

                repository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                var user = repository.GetUserByUsername("testuser");

                Assert.NotNull(user);
                Assert.Equal("testuser", user.Value.Username);
                Assert.Equal("TestPasswordHash", user.Value.Password);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetUserId_ShouldReturnCorrectUserId()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository repository = new UserRepository();

                repository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                int userId = repository.GetUserId("testuser");

                Assert.True(userId > 0);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void UpdatePassword_ShouldUpdateStoredPassword()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository repository = new UserRepository();

                repository.AddUser(
                    "Admin",
                    "testuser",
                    "OldPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                repository.UpdatePassword("testuser", "NewPasswordHash");

                var user = repository.GetUserByUsername("testuser");

                Assert.NotNull(user);
                Assert.Equal("NewPasswordHash", user.Value.Password);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetSecurityQuestion_ShouldReturnCorrectQuestion()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository repository = new UserRepository();

                repository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                string? question = repository.GetSecurityQuestion("testuser");

                Assert.Equal("What is your favourite colour?", question);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetSecurityQuestionAnswer_ShouldReturnCorrectAnswer()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository repository = new UserRepository();

                repository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                string? answer = repository.GetSecurityQuestionAnswer("testuser");

                Assert.Equal("Blue", answer);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetUserByUsername_ShouldReturnNullForUnknownUsername()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository repository = new UserRepository();

                var user = repository.GetUserByUsername("doesnotexist");

                Assert.Null(user);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetPosition_ShouldReturnCorrectPosition()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository repository = new UserRepository();

                repository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                string? position = repository.GetPosition("testuser");

                Assert.Equal("Admin", position);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void RemoveUser_ShouldRemoveUser()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository repository = new UserRepository();

                repository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                int userId = repository.GetUserId("testuser");

                repository.RemoveUser(userId);

                var user = repository.GetUserByUsername("testuser");

                Assert.Null(user);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }
    }
}
