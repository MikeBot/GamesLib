namespace TexasHoldEm;

using Standard52CardDeck;

class GameEngine
{
    public GameType GameType { get; set; }
    public GameStageType GameStage { get; set; }
    public List<Player> Players { get; set; }
    public List<Player> Spectators { get; set; }
    public List<Card> CommunityCards { get; set; }
    public Chip[] Pot { get; set; }
    public Dictionary<Player[], Chip[]> SidePots { get; set; }
    public Deck CardDeck { get; set; }

    public GameEngine() {
        this.InitializeGame();
    }

    public void InitializeGame() {
        this.GameStage = GameStageType.PREFLOP;
        this.Players = new List<Player>();
        this.Spectators = new List<Player>();
        this.CommunityCards = [];
        this.Pot = [];
        this.SidePots = new Dictionary<Player[], Chip[]>(); 
        this.CardDeck = new Deck();
        this.CardDeck.Shuffle();
    }

    public void NextGame(Player[] newPlayers, Player[] leavingPlayers) {
        this.GameStage = GameStageType.PREFLOP;
        //TODO: Reevaluate this for spectators
        this.Players.AddRange(newPlayers);
        this.Players.RemoveAll(x => leavingPlayers.Contains(x));
        //TODO: --------------------------
        this.CommunityCards = [];
        this.Pot = [];
        this.SidePots = new Dictionary<Player[], Chip[]>(); 
        this.CardDeck.InitDeck();
        this.CardDeck.Shuffle();
    }

    public void AddPlayer(Player player) {
        if(this.Spectators.Contains(player)) {
            this.Spectators.Remove(player);
        }
        this.Players.Add(player);
    }

    public void AddSpectator(Player player) {
        if(this.Players.Contains(player)) {
            this.Players.Remove(player);
        }
        this.Spectators.Add(player);
    }

    public void DrawPlayerCards() {
        if(this.GameStage == GameStageType.PREFLOP) {
            foreach(Player player in this.Players) {
                player.Hand.AddRange(this.CardDeck.DealMultiple(2, player.Name));
            }        
        }
    }

    public Card[] DrawFlopCards() {
        if(this.CommunityCards.Count == 0 && this.GameStage == GameStageType.FLOP) {
            Card[] drawnCards = this.CardDeck.DealMultiple(3, "Community Cards");
            this.CommunityCards.AddRange(drawnCards);
            return drawnCards;
        } else return [];
    }

    public Card? DrawTurnCard() {
        if(this.CommunityCards.Count == 3 && this.GameStage == GameStageType.TURN) {
            Card drawnTurnCard = this.CardDeck.Deal("Community Cards");
            this.CommunityCards.Add(drawnTurnCard);
            return drawnTurnCard;
        } else return null;
    }

    public Card? DrawRiverCard() {
        if(this.CommunityCards.Count == 4 && this.GameStage == GameStageType.RIVER) {
            Card drawnRiverCard = this.CardDeck.Deal("Community Cards");
            this.CommunityCards.Add(drawnRiverCard);
            return drawnRiverCard;
        } else return null;
    }
}