namespace Override;

public class Income
{
    public static void Come(Good[] goods, string type, int quantity)
    {
        foreach (var good in goods)
        {
            if (good.GetType().Name == type)
            {
                good.Quantity += quantity;
                Console.WriteLine(good);
            }
        }
    }
}