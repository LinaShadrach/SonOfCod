using SonOfCodSeafood.Models;
using Xunit;

namespace SonOfCodSeafood.Tests
{

    public class RecipientTest
    {
        [Fact]
        public void Recipient_IsCreated_Test()
        {
            Recipient recipient = new Recipient(0, "Lila", "lila@mai.com", 99654, 0);
            Recipient otherRecipient = new Recipient(0, "Lila", "lila@mai.com", 99654, 0);
            Assert.Equal(recipient, otherRecipient);
        }

    }
}

