using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Linq.Enumerable;

namespace AspNet.Facebook.Core.Services.Tests
{
    [TestClass()]
    public class LoginTests
    {
        [TestMethod()]
        public async Task GetAccessTokenAsyncTestAsync()
        {
            // Arrange
            string facebookAppId = GenerateRandomNumeric(15);
            string facebookAppSecret = GenerateRandomAlphaNumeric(23);
            string facebookRedirectUri = "https://localhost";
            string code = GenerateRandomAlphaNumeric(323);

            // Act
            Models.Login.AccessToken accessToken = await Login.GetAccessTokenAsync(facebookAppId, facebookAppSecret, facebookRedirectUri, code);

            // Assert
            Assert.IsNull(accessToken);
        }

        public string GenerateRandomNumeric(int length)
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < length; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
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