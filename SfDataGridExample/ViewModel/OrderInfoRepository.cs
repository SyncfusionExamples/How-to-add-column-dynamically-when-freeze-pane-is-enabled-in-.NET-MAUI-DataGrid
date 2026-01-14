using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SfDataGridExample
{
    public class OrderInfoRepository
    {
        private ObservableCollection<OrderInfo> orderInfo;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin", "Laptop", 2, 1200.5, 0.1, DateTime.Now,
                "Electronics", "TechSupplier", true, DateTime.Now.AddDays(-2), "Credit Card", 25.0, "TRK1001", "WH-A1", "Alice", "Urgent delivery"));

            orderInfo.Add(new OrderInfo(1002, "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F.", "Mouse", 5, 25.99, 0.05, DateTime.Now,
                "Accessories", "GlobalTech", false, DateTime.Now.AddDays(3), "PayPal", 10.0, "TRK1002", "WH-B2", "Bob", "Standard"));

            orderInfo.Add(new OrderInfo(1003, "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", "Keyboard", 3, 45.0, 0.07, DateTime.Now,
                "Accessories", "KeyMasters", true, DateTime.Now.AddDays(-1), "Debit Card", 12.5, "TRK1003", "WH-C3", "Charlie", "Gift wrap"));

            orderInfo.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London", "Monitor", 1, 300.0, 0.15, DateTime.Now,
                "Electronics", "DisplayWorld", true, DateTime.Now.AddDays(-5), "Credit Card", 30.0, "TRK1004", "WH-D4", "Diana", "Fragile"));

            orderInfo.Add(new OrderInfo(1005, "Tim Adams", "Sweden", "BERGS", "London", "Printer", 1, 150.75, 0.2, DateTime.Now,
                "Office", "PrintTech", false, DateTime.Now.AddDays(2), "Cash", 20.0, "TRK1005", "WH-E5", "Eve", "Include cable"));

            orderInfo.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim", "Tablet", 2, 500.0, 0.1, DateTime.Now,
                "Electronics", "TabZone", true, DateTime.Now.AddDays(-3), "Credit Card", 18.0, "TRK1006", "WH-F6", "Frank", "Express"));

            orderInfo.Add(new OrderInfo(1007, "Andrew Fuller", "France", "BLONP", "Strasbourg", "Smartphone", 1, 800.0, 0.12, DateTime.Now,
                "Electronics", "SmartTech", true, DateTime.Now.AddDays(-1), "UPI", 15.0, "TRK1007", "WH-G7", "Grace", "Include case"));

            orderInfo.Add(new OrderInfo(1008, "Martin King", "Spain", "BOLID", "Madrid", "Webcam", 4, 60.0, 0.08, DateTime.Now,
                "Accessories", "CamWorld", false, DateTime.Now.AddDays(4), "Credit Card", 8.0, "TRK1008", "WH-H8", "Henry", "Bulk order"));

            orderInfo.Add(new OrderInfo(1009, "Lenny Lin", "France", "BONAP", "Marsiella", "Headset", 2, 75.25, 0.05, DateTime.Now,
                "Accessories", "SoundTech", true, DateTime.Now.AddDays(-2), "Debit Card", 9.5, "TRK1009", "WH-I9", "Ivy", "Noise canceling"));

            orderInfo.Add(new OrderInfo(1010, "John Carter", "Canada", "BOTTM", "Lenny Lin", "Charger", 3, 20.0, 0.03, DateTime.Now,
                "Accessories", "ChargePro", false, DateTime.Now.AddDays(1), "Cash", 5.0, "TRK1010", "WH-J10", "Jack", "Fast charge"));

            orderInfo.Add(new OrderInfo(1011, "Laura King", "UK", "AROUT", "London", "Laptop", 2, 1200.5, 0.1, DateTime.Now,
                "Electronics", "TechSupplier", true, DateTime.Now.AddDays(-2), "Credit Card", 25.0, "TRK1011", "WH-A1", "Alice", "Repeat customer"));

            orderInfo.Add(new OrderInfo(1012, "Anne Wilson", "Germany", "BLAUS", "Mannheim", "Mouse", 5, 25.99, 0.05, DateTime.Now,
                "Accessories", "GlobalTech", false, DateTime.Now.AddDays(3), "PayPal", 10.0, "TRK1012", "WH-B2", "Bob", "Standard"));

            orderInfo.Add(new OrderInfo(1013, "Martin King", "France", "BLONP", "Strasbourg", "Keyboard", 3, 45.0, 0.07, DateTime.Now,
                "Accessories", "KeyMasters", true, DateTime.Now.AddDays(-1), "Debit Card", 12.5, "TRK1013", "WH-C3", "Charlie", "Gift wrap"));

            orderInfo.Add(new OrderInfo(1014, "Gina Irene", "UK", "AROUT", "London", "Monitor", 1, 300.0, 0.15, DateTime.Now,
                "Electronics", "DisplayWorld", true, DateTime.Now.AddDays(-5), "Credit Card", 30.0, "TRK1014", "WH-D4", "Diana", "Fragile"));
        }
    }
}
