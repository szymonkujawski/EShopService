using Xunit;
using EShop.Application;

namespace EShop.Application.Tests
{
    public class CreditCardServiceTests
    {
        private readonly CreditCardService _creditCardService;

        public CreditCardServiceTests()
        {
            _creditCardService = new CreditCardService();
        }

        [Theory]
        [InlineData("1234")]
        [InlineData("123456789")]
        [InlineData("3213123")]
        public void ValidateCard_ReturnsFalse_WhenTooShort(string cardNumber)
        {
            var result = _creditCardService.ValidateCard(cardNumber);
            Assert.False(result);
        }

        [Theory]
        [InlineData("12345678912347656765756757657")]
        [InlineData("1234567891234897879789595879789")]
        [InlineData("123456789123454353464564564563546")]
        public void ValidateCard_ReturnsFalse_WhenTooLong(string cardNumber)
        {
            var result = _creditCardService.ValidateCard(cardNumber);
            Assert.False(result);
        }

        [Theory]
        [InlineData("4532015112830366")] 
        [InlineData("6011111111111117")] 
        [InlineData("378282246310005")]  
        public void ValidateCard_ReturnsTrue_WhenValidCardNumber(string cardNumber)
        {
            var result = _creditCardService.ValidateCard(cardNumber);
            Assert.True(result);
        }

        [Theory]
        [InlineData("4532015112830366", "Visa")]
        [InlineData("5105105105105100", "MasterCard")]
        [InlineData("378282246310005", "American Express")]
        [InlineData("6011111111111117", "Discover")]
        [InlineData("3528000000000000", "JCB")]
        public void GetCardType_ReturnsCorrectType(string cardNumber, string expectedType)
        {
            var result = _creditCardService.GetCardType(cardNumber);
            Assert.Equal(expectedType, result);
        }
    }
}
