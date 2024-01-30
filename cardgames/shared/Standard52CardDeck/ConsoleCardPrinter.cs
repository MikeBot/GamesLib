namespace Standard52CardDeck;

public class ConsoleCardPrinter : ICardPrinter
{
    public void PrintCard(Card card) {
        CardASCIIGenerator.Generate(card);
    }
}