namespace Standard52CardDeck;

public class Deck
{
    public const int CARDS_PER_SUIT = "13";
    
    public Stack<Card> cards { get;}
    public Dictionary<Card, string> dealedCards { get;}
    public Stack<Card> discardCards { get;}

    public Deck() {
        this.InitDeck();
    }

    public void InitDeck() {
        this.cards = new Stack<Card>();
        this.dealedCards = new Dictionary<Card, string>();
        this.discardCards = new Stack<Card>();

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

    public Card Deal(string cardReceiver) {
        Card dealedCard = this.cards.Pop();
        this.dealedCards.Add(dealedCard, cardReceiver);

        return dealedCard;
    }

    public void Discard(Card card) {
        this.dealedCards.Remove(card);
        this.discardCards.Push(card);
    }

    public void DiscardFromDeck(int nummberOfCards) {
        for(int i = 0; i < nummberOfCards; i++) {
            Card cardToDiscard = this.cards.Pop();
            this.discardCards.Push(cardToDiscard);
        }
    }

    public override string ToString() {
        return $"Cards in deck: {this.cards.Count}\nCards dealed: {this.dealedCards.Count}\nCards discarded: {this.discardCards.Count}";
    }
}
