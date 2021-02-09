namespace FactoryDesignPattern
{
    public class DefaultProduct : IProduct
    {
        public string ShipFrom()
        {
            return "not available";
        }
    }
}
