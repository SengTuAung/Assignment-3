using Assignment3.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        // Queue to hold orders
        private SerializableQueue<Order> _orders = new SerializableQueue<Order>();

        public Form1()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            // Creating the new order based on users choice
            Order order = null;
            var amount = Convert.ToInt32(amountUpDown.Value);
            if (burgerRadioButton.Checked)
                order = new BurgerOrder(amount);
            else if (pizzaRadioButton.Checked)
                order = new PizzaOrder(amount);
            else if (cheesecakeRadioButton.Checked)
                order = new CheesecakeOrder(amount);

            // Adding the order to the queue
            _orders.Enqueue(order);
            // Showing the order's name in list
            queueListBox.Items.Add(order.Name + " " + order.Amount.ToString());
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            // If there are orders in queue then removing the first one
            if (_orders.Count > 0)
            {
                _orders.Dequeue();
                queueListBox.Items.RemoveAt(0);
            }
        }

        // Name of the file to store the data
        private readonly string _filename = "data.xml";

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            // Creating new XmlSerializer of the type of the queue
            var serializer = new XmlSerializer(typeof(SerializableQueue<Order>));
            // Creating new stream writer into the file with name _filename
            var stream = new StreamWriter(_filename);
            // Serializing the queue with orders
            serializer.Serialize(stream, _orders);
            // Closing stream
            stream.Close();
        }

        private void loadFromFileButton_Click(object sender, EventArgs e)
        {
            // Creating new XmlSerializer of the type of the queue
            var serializer = new XmlSerializer(typeof(SerializableQueue<Order>));
            // Creating new stream writer into the file with name _filename
            var stream = new FileStream(_filename, FileMode.Open);
            // Deserializing the queue with orders
            _orders = (SerializableQueue<Order>) serializer.Deserialize(stream);
            // Closing stream
            stream.Close();

            // Filling list box with items
            queueListBox.Items.Clear();
            foreach (var order in _orders)
                queueListBox.Items.Add(order.Name + " " + order.Amount.ToString());
        }
    }
}
