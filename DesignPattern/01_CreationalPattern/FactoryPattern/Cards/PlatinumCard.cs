namespace DatastructureMSTest.DesignPattern.CreationalPattern.FactoryPattern
{
    public class PlatinumCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Card";
        }

        public int GetCreditLimit()
        {
            return 100000;
        }

        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
