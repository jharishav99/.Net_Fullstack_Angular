using Moq;
using MyApp1;
using Xunit;

namespace MyApp1.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void HasUsers_ReturnsTrue_WhenCountGreaterThanZero()
        {
            // Arrange
            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.GetUserCount()).Returns(5);

            var service = new UserService(mockRepo.Object);

            // Act
            var result = service.HasUsers();

            // Assert
            Assert.True(result);
        }
    }
}