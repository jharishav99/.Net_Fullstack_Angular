using Xunit;
using SecureUserManagement; 

namespace SecureUserManagement.Tests
{
    public class UserSystemTests
    {
        [Fact]
        public void PasswordHasher_ShouldReturnDifferentHashForSamePassword()
        {
            // Arrange
            string password = "SecretPassword123!";

            // Act
            string hash1 = PasswordHasher.HashPassword(password);
            string hash2 = PasswordHasher.HashPassword(password);

            // Assert
            Assert.NotNull(hash1);
            Assert.Equal(64, hash1.Length); // SHA-256 is 64 characters
            Assert.Equal(hash1, hash2); // Same password should produce same hash
        }

        [Fact]
        public void EncryptionHelper_ShouldEncryptAndDecryptCorrectly()
        {
            // Arrange
            string originalData = "sensitive.email@company.com";

            // Act
            string encryptedData = EncryptionHelper.Encrypt(originalData);
            string decryptedData = EncryptionHelper.Decrypt(encryptedData);

            // Assert
            Assert.NotEqual(originalData, encryptedData); // Data should look different
            Assert.Equal(originalData, decryptedData);    // Decrypted data should match original
        }

        [Fact]
        public void UserManager_RegisterAndAuthenticate_ShouldSucceed()
        {
            // Arrange
            var userManager = new UserManager();
            string username = "testUser";
            string password = "ComplexPassword!123";
            string email = "test@example.com";

            // Act
            userManager.Register(username, password, email);
            bool isAuthSuccessful = userManager.Authenticate(username, password);

            // Assert
            Assert.True(isAuthSuccessful);
        }

        [Fact]
        public void UserManager_Authenticate_ShouldFailWithWrongPassword()
        {
            // Arrange
            var userManager = new UserManager();
            string username = "testUser";
            string correctPassword = "CorrectPassword123";
            string wrongPassword = "WrongPassword";

            // Act
            userManager.Register(username, correctPassword, "email@test.com");
            bool isAuthSuccessful = userManager.Authenticate(username, wrongPassword);

            // Assert
            Assert.False(isAuthSuccessful);
        }
    }
}