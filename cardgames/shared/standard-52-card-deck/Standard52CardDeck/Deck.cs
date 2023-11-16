namespace Standard52CardDeck;

public class Deck
{
    public const int CARDS_PER_SUIT = "13";
    
    public Stack<Card> cards { get; set; }
    public List<Card> dealedCards { get; set; }
    public Stack<Card> discardCards { get; set; }

    public Deck() {
        this.BuildDeck();
        this.dealedCards = new List<Card>();
        this.discardCards = new Stack<Card>();
    }

    private BuildDeck() {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            for(int i = 1; i <= CARDS_PER_SUIT; i++) {
                cards.Push(new Card(suit, i));
            }
        }
    }

    public void Shuffle() {
        List<T> cardsList = this.cards.ToList();
        Random random = new Random();
        cardsList.Shuffle(random);

        this.cards = new Stack<Card>(cardsList);
    }

    public Card DealCard() {
        return this.cards.Pop();
    }
}
