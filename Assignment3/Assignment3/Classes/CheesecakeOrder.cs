namespace Assignment3.Classes
{
    // // 4-6-2021 Saung NEW 5L :Order class for cheesecake orders
    public class CheesecakeOrder : Order
    {
        //// 4-6-2021 Saung NEW 5L Parameterless constructor for serialization
        public CheesecakeOrder() : base(0) { }
        public CheesecakeOrder(int amount) : base(amount) { }
        public override string Name { get => "Cheesecake"; }
    }
}
