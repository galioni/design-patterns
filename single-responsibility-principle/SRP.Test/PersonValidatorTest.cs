using Xunit;

namespace SRP.Test
{
	public class PersonValidatorTest
	{
		[Fact]
		public void Person_InvalidUser()
		{
			Person user = new Person();

			user.FirstName = string.Empty;
			user.LastName = string.Empty;

			Assert.False(PersonValidator.Validate(user), "Invalid User");
		}

		[Fact]
		public void Person_ValidUser()
		{
			Person user = new Person();

			user.FirstName = "Andre";
			user.LastName = "Galioni";

			Assert.True(PersonValidator.Validate(user), "Valid User");
		}
	}
}
