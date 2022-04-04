namespace Override;

public class Sousage : Product
{
    public string Kind { get; set; }
    
    public Sousage(int id, double price, int quantity, string name, DateTime term, double weight, string kind)
    {
        Id = id;
        Price = price;
        Quantity = quantity;
        Name = name;
        Term = term;
        Weight = weight;
        Kind = kind;
    }
    
    public override string ToString()
    {
        return $"ID: {this.Id}\nPrice: {this.Price}\nQuantity: {this.Quantity}\nName: {this.Name}\n" +
               $"Term: {this.Term.ToString()}\nWeigth: {this.Weight}\nKind: {this.Kind}";
    }
}