using System;

namespace StoreExercice
{
    class Program
    {
        //        4. Model in c# the following business model

        //- Store(IStore)
        //- Customer(IPerson)
        //- Order(IOrder)
        //- Producer(IProducer)
        //- Car(IVehicle)
        //Inside the main method to implement the following behavior: 
        //- Alex intended to buy a Ford Focus 2015 model.
        //- He walked to the FordStore in Bucuresti and agreed to buy one for 15000Euro.
        //- They informed him it will take 4 weeks for delivery.
        //- He then decided to visit another store SkodaStore and agreed to buy one for 14000Euro and 3 weeks delivery.
        //- He then canceled his original order from the FordStore.
        //- After 3 weeks, he received the model.



        static void Main(string[] args)
        {

            IPerson alex = new NaturalCustomer("Alex", "Popescu", 30);
            ICustomer alexAutoConsult = new JuridicalCustomer(alex, "alexAutoConsult");

            Store fordStore = new FordStore();
            IVehicle fordVehicle = new FordFocus(2016, 15000);
            IOrder order1 = new Order(fordVehicle, alexAutoConsult);
            fordStore.ProcessOrder(order1, alexAutoConsult);
            fordStore.AskForDeliveryTime(order1);

            Store skodaStore = new SkodaStore();
            IVehicle skodaVehicle = new SkodaCar(2017, 17000);
            IOrder order2 = new Order(skodaVehicle, alexAutoConsult);
            skodaStore.ProcessOrder(order2, alexAutoConsult);
            fordStore.CancelOrder(order1, alexAutoConsult);

        }
    }
}
