namespace Standard52CardDeckTest;

using Xunit;
using Standard52CardDeck;


public class DeckTests
{
    [Fact]
    public void Deck_Should_Have_Correct_Number_Of_Cards()
    {
        // Arrange
        var deck = new Deck();

        // Act
        int numberOfCards = deck.Cards.Count;

        // Assert
        Assert.Equal(52, numberOfCards);
    }

    [Fact]
    public void Deal_Should_Return_Card_From_Deck()
    {
        // Arrange
        var deck = new Deck();

        // Act
        Card dealtCard = deck.Deal("Player 1");

        // Assert
        Assert.NotNull(dealtCard);
        Assert.DoesNotContain(dealtCard, deck.Cards);
        Assert.Contains(dealtCard, deck.DealedCards.Keys);
        Assert.Equal("Player 1", deck.DealedCards[dealtCard]);
    }

    [Fact]
    public void Discard_Should_Add_Card_To_Discard_Pile()
    {
        // Arrange
        var deck = new Deck();
        var card = new Card(5, Suit.CLUBS);

        // Act
        deck.Discard(card);

        // Assert
        Assert.Contains(card, deck.DiscardPile);
    }

        [Fact]
    public void DiscardFromDeck_Should_Add_The_Specified_Number_Of_Card_To_Discard_Pile()
    {
        // Arrange
        var deck = new Deck();

        // Act
        deck.DiscardFromDeck(3);

        // Assert
        Assert.Equal(3, deck.DiscardPile.Count);
        Assert.Equal(Deck.CARDS_PER_DECK - 3, deck.Cards.Count);
    }
}
