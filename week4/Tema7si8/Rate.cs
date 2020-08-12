namespace Tema7si8

//    1. Model a simple Hotel app.

{
    public class Rate
    {
        public double amount;
        public string currency;
        public Rate(double amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public void Print()
        {
            System.Console.WriteLine($"The amount is {amount}, and the currency : {currency}");
        }

    }
}
