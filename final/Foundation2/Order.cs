using System.Runtime.CompilerServices;

class Order 
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    
    public decimal GetTotalCost()
    {
        decimal totalCost = products.Sum(product => product.GetTotalPrice());
        
        decimal shippingCost = customer.IsInUSA() ? 5 : 35;

        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", products.Select(product => product.GetProductInfo()));
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}