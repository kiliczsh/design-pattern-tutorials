namespace FactoryMethod;

public abstract class ShoeCreator
{
    protected abstract IShoe ShoeFactory();
    
    public string Produce()
    {
        var shoe = ShoeFactory();
        var details = "Creator: The same creator's code has just worked with "
                     + shoe.GetProductDetails();

        return details;
    }
}