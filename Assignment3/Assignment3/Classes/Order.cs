using System;
using System.Xml.Serialization;

namespace Assignment3.Classes
{
    // // 4-6-2021 Saung NEW 5L :Including derived classes for further correct XML serialization
    [XmlInclude(typeof(BurgerOrder))]
    [XmlInclude(typeof(PizzaOrder))]
    [XmlInclude(typeof(CheesecakeOrder))]
    [Serializable]
    //// 4-6-2021 Saung NEW 5L : Abstract order
    public abstract class Order
    {
        // // 4-6-2021 Saung NEW 5L :Amount of order
        private int _amount;
        public int Amount
        {
            get => _amount;
            set => _amount = value;
        }
        //4-6-2021 Saung NEW 5L :  Name of order remains abstract
        public abstract string Name { get; }
        // 4-6-2021 Saung NEW 5L :  Constructor with setting the amount of order
        public Order(int amount) 
        {
            Amount = amount;
        }
    }
}
