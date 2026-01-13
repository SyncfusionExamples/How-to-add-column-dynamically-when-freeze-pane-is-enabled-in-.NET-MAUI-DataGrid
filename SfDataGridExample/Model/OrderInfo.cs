using System;
using System.Collections.Generic;
using System.Text;

namespace SfDataGridExample
{
    public class OrderInfo
    {
        private int orderID;
        private string? customerID;
        private string? customer;
        private string? shipCity;
        private string? shipCountry;
        private string? productName;
        private int quantity;
        private double unitPrice;
        private double discount;
        private DateTime orderDate;

        private string? category;
        private string? supplier;
        private bool isDelivered;
        private DateTime deliveryDate;
        private string? paymentMethod;
        private double shippingCost;
        private string? trackingNumber;
        private string? warehouseLocation;
        private string? salesPerson;
        private string? notes;

        public int OrderID 
        {
            get => orderID; 
            set => orderID = value; 
        }

        public string? CustomerID 
        { 
            get => customerID; 
            set => customerID = value; 
        }

        public string? Customer 
        { 
            get => customer; 
            set => customer = value; 
        }

        public string? ShipCity 
        { 
            get => shipCity; 
            set => shipCity = value; 
        }

        public string? ShipCountry 
        { 
            get => shipCountry; 
            set => shipCountry = value; 
        }

        public string? ProductName 
        { 
            get => productName; 
            set => productName = value; 
        }
        
        public int Quantity 
        { 
            get => quantity; 
            set => quantity = value; 
        }
        
        public double UnitPrice 
        { 
            get => unitPrice; 
            set => unitPrice = value; 
        }
        
        public double Discount 
        { 
            get => discount; 
            set => discount = value; 
        }
        
        public DateTime OrderDate 
        { 
            get => orderDate; 
            set => orderDate = value; 
        }

        public string? Category 
        { 
            get => category; 
            set => category = value; 
        }
        
        public string? Supplier 
        { 
            get => supplier; 
            set => supplier = value; 
        }
        
        public bool IsDelivered 
        { 
            get => isDelivered; 
            set => isDelivered = value; 
        }
        
        public DateTime DeliveryDate 
        { 
            get => deliveryDate; 
            set => deliveryDate = value; 
        }
        
        public string? PaymentMethod 
        { 
            get => paymentMethod; 
            set => paymentMethod = value; 
        }

        public double ShippingCost 
        { 
            get => shippingCost; 
            set => shippingCost = value; 
        }
        
        public string? TrackingNumber 
        { 
            get => trackingNumber; 
            set => trackingNumber = value; 
        }
        
        public string? WarehouseLocation 
        { 
            get => warehouseLocation; 
            set => warehouseLocation = value; 
        }

        public string? SalesPerson 
        {
            get => salesPerson; 
            set => salesPerson = value; 
        }
        public string? Notes 
        { 
            get => notes; 
            set => notes = value; 
        }

        public OrderInfo(int orderId, string customerId, string country, string customer, string shipCity,
            string productName, int quantity, double unitPrice, double discount, DateTime orderDate,
            string category, string supplier, bool isDelivered, DateTime deliveryDate, string paymentMethod,
            double shippingCost, string trackingNumber, string warehouseLocation, string salesPerson, string notes)
        {
            OrderID = orderId;
            CustomerID = customerId;
            Customer = customer;
            ShipCountry = country;
            ShipCity = shipCity;
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Discount = discount;
            OrderDate = orderDate;

            Category = category;
            Supplier = supplier;
            IsDelivered = isDelivered;
            DeliveryDate = deliveryDate;
            PaymentMethod = paymentMethod;
            ShippingCost = shippingCost;
            TrackingNumber = trackingNumber;
            WarehouseLocation = warehouseLocation;
            SalesPerson = salesPerson;
            Notes = notes;
        }
    }
}
