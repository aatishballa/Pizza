using DominosApi;
using DominosApi.RestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
	class Pizza
	{
		public static string profileName,
			addr, town, state, addrType, zip,
			cardNum, cardType, expire, back, order,
			customerFirstName, customerLastName, customerEmail,
			customerPhoneNumber;

        public static bool orderPlaced;

        public void placeOrder()
        {
			IDominosApi api = new DominosApi.DominosApi();
			var htype = (addrType == "House") ? Address.UnitCategory.House : Address.UnitCategory.Apartment;
			var deliveryAddress = new Address(addr, town, state, zip, htype);
			var customerInfo = new Customer(customerFirstName, customerLastName, deliveryAddress, customerEmail, customerPhoneNumber);
			/*

string storeId = "3712";    // Get this value from a call to SearchLocations(...)

// Two medium pepperoni pizzas, one medium cheese, and cinnastix
var products = new List<Product> {  new Product("14SCREEN", 2, new List<string> { "C", "P", "X" }),
	new Product("14SCREEN", 1, new List<string> { "C", "X" }),
	new Product("CINNASTIX8", 1)};

var coupons = new List<Coupon> { new Coupon("3510", 1) };   // This particular coupon saves us money on three medium pizzas.
                                                            // Get this value from a call to GetMenu(...)

var myOrder = new Order(customerInfo, storeId, products, coupons);

var pricedOrder = await api.PriceOrder(myOrder);   // This may throw if, for instance, the store is closed.

decimal totalAmountToPay = pricedOrder.Order.Amounts.Payment.Value;

var payments = new List<Payment> { new Payment("1112223334444", CreditCardType.Visa, "0918", "111", "02170", totalAmountToPay) };

var order = await api.PlaceOrder(myOrder, payments);
			 */
		}

		public void trackOrder()
        {

        }
	}
}
