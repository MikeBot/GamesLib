namespace Standard52CardDeck;

public class Card
{
    public int CardNumber { get;}
    public Suit CardSuit { get;}

    public Card(int cardNumber, Suit cardSuit) {
        CardNumber = cardNumber;
        CardSuit = cardSuit;
    }

    public string GetCardValueName() {
        switch (CardNumber) {
            case 1: return "Ace";
            case 11: return "Jack";
            case 12: return "Queen";
            case 13: return "King";
            default: return CardNumber.ToString();
        }
    }

        public string GetCardValueSymbol() {
        switch (CardNumber) {
            case 1: return "A";
            case 11: return "J";
            case 12: return "Q";
            case 13: return "K";
            default: return CardNumber.ToString();
        }
    }


    public override string ToString() {
        return $"{this.GetCardValueName()} of {CardSuit}";
    }
}
