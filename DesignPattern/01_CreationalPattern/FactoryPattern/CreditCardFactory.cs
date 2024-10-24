namespace DatastructureMSTest.DesignPattern.CreationalPattern.FactoryPattern
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            switch (cardType.ToLower())
            {
                case "gold":
                    return new GoldCard();
                case "platinum":
                    return new PlatinumCard();
                default:
                    throw new ArgumentException("Invalid card type");
            }
        }
    }
}
