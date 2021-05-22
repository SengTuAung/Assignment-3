namespace Assignment3.Classes
{
    //4-6-2021 Saung NEW 5L :  Order class for burger orders
    public class BurgerOrder : Order
    {
        //4-6-2021 Saung NEW 5L :  Parameterless constructor for serialization
        public BurgerOrder(): base(0) { }
        public BurgerOrder(int amount) : base(amount) { }
        public override string Name { get => "Burger"; }
    }
}
