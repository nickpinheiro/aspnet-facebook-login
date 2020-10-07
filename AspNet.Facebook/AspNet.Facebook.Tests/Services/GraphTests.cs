using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Facebook.Core.Services.Tests
{
    [TestClass()]
    public class GraphTests
    {
        [TestMethod()]
        public async Task GetUserAsyncTestAsync()
        {
            // Arrange
            string accessToken = GenerateRandomAlphaNumeric(332);

            // Act
            Models.User facebookUser = await Graph.GetUserAsync(accessToken);

            // Assert
            Assert.IsNull(facebookUser);
        }

        public string GenerateRandomAlphaNumeric(int length)
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}