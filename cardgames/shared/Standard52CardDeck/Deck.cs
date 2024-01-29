namespace Standard52CardDeck;

public class Deck
{
    public const int CARDS_PER_SUIT = 13;
    public const int CARDS_PER_DECK = CARDS_PER_SUIT * 4;
    
    public Stack<Card> Cards { get; private set;}
    public Dictionary<Card, string> DealedCards { get; private set;}
    public Stack<Card> DiscardPile { get; private set;}

    public Deck() {
        this.Cards = new Stack<Card>();
        this.DealedCards = new Dictionary<Card, string>();
        this.DiscardPile = new Stack<Card>();

        this.InitDeck();
    }

    public void InitDeck() {
        this.Cards = new Stack<Card>();
        this.DealedCards = new Dictionary<Card, string>();
        this.DiscardPile = new Stack<Card>();

        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            for(int i = 1; i <= CARDS_PER_SUIT; i++) {
                Cards.Push(new Card(i, suit));
            }
        }
    }

    public void Shuffle() {
        List<Card> cardsList = this.Cards.ToList();

        this.Cards = new Stack<Card>(cardsList.OrderBy(x => Random.Shared.Next()).ToList());
    }

    public Card Deal(string cardReceiver) {
        Card dealedCard = this.Cards.Pop();
        this.DealedCards.Add(dealedCard, cardReceiver);

        return dealedCard;
    }

    public Card[] DealMultiple(int timesDealed, string cardReceiver) {
        Card[] dealedCards = new Card[timesDealed];
        for(int i = 0; i < timesDealed; i++) {
            dealedCards[i] = this.Cards.Pop();
            this.DealedCards.Add(dealedCards[i], cardReceiver);
        }

        return dealedCards;
    }

    public void Discard(Card card) {
        this.DealedCards.Remove(card);
        this.DiscardPile.Push(card);
    }

    public void DiscardMultiple(Card[] cards) {
        foreach(Card card in cards) {
            this.Discard(card);
        }
    }

    public void DiscardFromDeck(int nummberOfCards) {
        for(int i = 0; i < nummberOfCards; i++) {
            Card cardToDiscard = this.Cards.Pop();
            this.DiscardPile.Push(cardToDiscard);
        }
    }

    public override string ToString() {
        return $"Cards in deck: {this.Cards.Count}\nCards dealed: {this.DealedCards.Count}\nCards discarded: {this.DiscardPile.Count}";
    }
}
