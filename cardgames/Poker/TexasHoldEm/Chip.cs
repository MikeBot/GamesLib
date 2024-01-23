namespace TexasHoldEm;

public class Chip {
    public ChipType Type { get; }
    public decimal Value { get; }

    public Chip(ChipType type, decimal value) {
        this.Type = type;
        this.Value = value;
    }

    public override string ToString() {
        return $"Chip with value {this.Value} and type {this.Type}";
    }
}

public enum ChipType {
    SMALL, MEDIUM, LARGE
}