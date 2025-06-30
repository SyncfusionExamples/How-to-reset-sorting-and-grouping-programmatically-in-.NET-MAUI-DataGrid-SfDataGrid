#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Runtime;

namespace SfDataGridSample.Model
{
    public class Orders
    {

        private int orderID;
        private int supplierID;
        private string? customerID;
        private string? shipCity;
        private string? shipCountry;
        private double freight;
        private DateTime shippingDate;

        public int OrderID
        {
            get
            {
                return this.orderID;
            }

            set
            {
                this.orderID = value;
            }
        }

        public string? CustomerID
        {
            get
            {
                return this.customerID;
            }

            set
            {
                this.customerID = value;
            }
        }

        public DateTime ShippingDate
        {
            get
            {
                return this.shippingDate;
            }

            set
            {
                this.shippingDate = value;
            }
        }

        public int SupplierID
        {
            get
            {
                return this.supplierID;
            }

            set
            {
                this.supplierID = value;
            }
        }
        
        public string? ShipCity
        {
            get
            {
                return this.shipCity;
            }

            set
            {
                this.shipCity = value;
            }
        }

        public string? ShipCountry
        {
            get
            {
                return this.shipCountry;
            }

            set
            {
                this.shipCountry = value;
            }
        }

        public double Freight
        {
            get
            {
                return this.freight;
            }

            set
            {
                this.freight = value;
            }
        }
    }
}
