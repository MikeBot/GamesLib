namespace Standard52CardDeck;

public class CardASCIIGenerator
{
    public static string Generate(Card card) {
        string cardValueSymbol = card.GetCardValueSymbol();
        string cardSuitSymbol = "";

        switch (card.CardSuit) {
            case Suit.CLUBS:
                cardSuitSymbol = "♣";
                break;
            case Suit.DIAMONDS:
                cardSuitSymbol = "♦";
                break;
            case Suit.HEARTS:
                cardSuitSymbol = "♥";
                break;
            case Suit.SPADES:
                cardSuitSymbol = "♠";
                break;
        }

        return buildCardASCII(cardValueSymbol, cardSuitSymbol);
    }

    private static string buildCardASCII(string cardValueSymbol, string cardSuitSymbol) {
        string[] cardLines = new string[9];
        
        cardLines[0] = $"┌─────────┐\n";
        cardLines[1] = $"│ {cardValueSymbol, -2}      │\n";
        cardLines[2] = $"│ {cardSuitSymbol}       │\n";
        cardLines[3] = $"│         │\n";
        cardLines[4] = $"│    {cardSuitSymbol}    │\n";
        cardLines[5] = $"│         │\n";
        cardLines[6] = $"│       {cardSuitSymbol} │\n";
        cardLines[7] = $"│      {cardValueSymbol, 2} │\n";
        cardLines[8] = $"└─────────┘\n";

        return string.Join("", cardLines);
    }

}