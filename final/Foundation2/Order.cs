class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.GetPrice();
        }

        // Add shipping cost based on customer's location
        if (customer.GetAddress().IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += "Product Name: " + product.GetName() + ", Product ID: " + product.GetProductId() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Customer Name: " + customer.GetName() + "\n" + customer.GetAddress().GetFullAddress();
    }
}