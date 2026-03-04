using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OpTeamUs.Services;
using OpTeamUs.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace OpTeamUs.Tests
{
	public class JwtServiceTests
	{

		private JwtService CreateJwtService()
		{
			var inMemorySettings = new Dictionary<string, string>
		{
			{"Jwt:Key", "ThisIsASuperSecretKeyForTesting123456"},
			{"Jwt:Issuer", "TestIssuer"},
			{"Jwt:Audience", "TestAudience"},
			{"Jwt:ExpiryMinutes", "60"}
		};

			IConfiguration configuration = new ConfigurationBuilder()
				.AddInMemoryCollection(inMemorySettings!)
				.Build();

			return new JwtService(configuration);
		}

		[Fact]
		public void GenerateToken_ReturnsValidToken()
		{
			// Arrange
			var jwtService = CreateJwtService();
			var user = new User
			{
				Id = Guid.NewGuid(),
				Email = "test@example.com",
				Role = "User"
			};

			// Act
			var token = jwtService.GenerateToken(user);

			// Assert
			Assert.False(string.IsNullOrEmpty(token));
			Assert.Contains(".", token); // JWT format check
		}

	}
}
