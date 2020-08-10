namespace Tema7si8

//    1. Model a simple Hotel app.

{
    public class Rate
    {
        public int _amount;
        public string _currency;
        public Rate(int amount, string currency)
        {
            this._amount = amount;
            this._currency = currency;
        }

        public void Print()
        {
            System.Console.WriteLine($"The amount is {_amount}, and the currency : {_currency}");
        }

    }
}
