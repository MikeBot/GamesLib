namespace Standard52CardDeck;

using Xunit;
using Standard52CardDeck;

public class CardASCIIGeneratorTest
{
    [Fact]
    public void Generate_Should_Return_Card_Correct_Value_And_Suit()
    {
        // Arrange
        var card = new Card(10, Suit.CLUBS);

        // Act
        string cardASCII = CardASCIIGenerator.Generate(card);

        // Assert
        Assert.Contains("10", cardASCII);
        Assert.Contains("♣", cardASCII);

        Console.WriteLine("\nCardASCIIGeneratorTest - Generate_Should_Return_Card_Correct_Value_And_Suit\n");
        Console.WriteLine("\nPrinting ASCII for visual check : \n");
       
        Console.Write(cardASCII);
    }
    [Fact]
    public void Generate_Should_Return_Card_Correct_Value_Symbol()
    {
        // Arrange
        var card = new Card(11, Suit.CLUBS);

        // Act
        string cardASCII = CardASCIIGenerator.Generate(card);

        // Assert
        Assert.Contains("J", cardASCII);
        Assert.Contains("♣", cardASCII);

        Console.WriteLine("\nCardASCIIGeneratorTest - Generate_Should_Return_Card_Correct_Value_Symbol\n");
        Console.WriteLine("\nPrinting ASCII for visual check : \n");
        Console.Write(cardASCII);
    }
}