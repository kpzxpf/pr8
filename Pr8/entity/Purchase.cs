namespace Pr8.entity;

public class Purchase
{
    public int id { get; set; }
    public int user_id { get; set; }
    public string product_name { get; set; }
    public ProductCategory category { get; set; }
    public decimal price { get; set; }
    public DateTime purchase_date { get; set; }
}

public enum ProductCategory
{
    Electronics = 1, 
    Clothing = 2,    
    Books = 3,      
    HomeAppliances = 4 
}