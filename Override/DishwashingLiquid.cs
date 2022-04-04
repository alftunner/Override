namespace Override;

public class DishwashingLiquid : Cleaning
{
    public string Smell { get; set; }

    public DishwashingLiquid(int id, double price, int quantity, string name, int toxicity, string smell)
    {
        Id = id;
        Price = price;
        Quantity = quantity;
        Name = name;
        Toxicity = toxicity;
        Smell = smell;
    }

    public override string ToString()
    {
        return $"ID: {this.Id}\nPrice: {this.Price}\nQuantity: {this.Quantity}\nName: {this.Name}" +
               $"Toxicity: {this.Toxicity}\nSmell: {this.Smell}\n";
    }
}