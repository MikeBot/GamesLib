namespace Standard52CardDeck;

public class Card
{
    public int CardNumber { get; set; }
    public enum CardSuit { get; set; }

    public Card(int cardNumber, CardSuit cardSuit) {
        CardNumber = cardNumber;
        CardSuit = cardSuit;
    }
}
