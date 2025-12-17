public class Product
{
    public string Name { get; set; }
    public decimal BasePrice { get; set; }
    public decimal CurrentBid { get; set; }    
    public string Buyer { get; set; }           

    public override string ToString()
    {
        return $"{Name} | Başlanğıc: {BasePrice} AZN | Hazırki təklif: {CurrentBid} AZN";
    }
}
