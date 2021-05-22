namespace Assignment3.Classes
{
    //4-6-2021 Saung NEW 5L :  Order class for pizza orders
    public class PizzaOrder: Order
    {
        //4-6-2021 Saung NEW 5L :  Parameterless constructor for serialization
        public PizzaOrder() : base(0) { }
        public PizzaOrder(int amount) : base(amount) { }
        public override string Name { get => "Pizza"; }
    }
}
