using SonOfCodSeafood.Models;
using Xunit;

namespace SonOfCodSeafood.Tests
{

    public class RecipientTest
    {
        [Fact]
        public void Recipient_IsCreated_Test()
        {
            Recipient recipient = new Recipient("Lila", "lila@mai.com");
            Recipient otherRecipient = new Recipient("Lila", "lila@mai.com");
            Assert.Equal(recipient, otherRecipient);
        }

    }
}

