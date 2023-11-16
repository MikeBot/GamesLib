namespace Standard52CardDeck;

public class Card
{
    public int CardNumber { get;}
    public Suit CardSuit { get;}

    public Card(int cardNumber, Suit cardSuit) {
        CardNumber = cardNumber;
        CardSuit = cardSuit;
    }

    public string GetCardName() {
        switch (CardNumber) {
            case 1: return "Ace";
            case 11: return "Jack";
            case 12: return "Queen";
            case 13: return "King";
            default: return CardNumber.ToString();
        }
    }

    public override string ToString() {
        return $"{this.GetCardName()} of {CardSuit}";
    }
}
