namespace DatastructureMSTest.DesignPattern.CreationalPattern.FactoryPattern
{
    public class GoldCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Gold Card";
        }

        public int GetCreditLimit()
        {
            return 50000;
        }

        public int GetAnnualCharge()
        {
            return 1000;
        }
    }
}
