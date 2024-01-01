using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, User> UserData()
        {
            return new UserRepo();
        }
        public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }
        public static IRepo<Product, int, Product> ProductData()
        {
            return new ProductRepo();
        }
        public static IRepo<Customer, int, Customer> CustomerData()
        {
            return new CustomerRepo();
        }
        public static IRepo<OrderDetails, int, bool> OrderDetailsData()
        {
            return new OrderDetailsRepo();
        }
        public static IRepo<Order, int, bool> OrderData()
        {
            return new OrderRepo();
        }
    }
}
