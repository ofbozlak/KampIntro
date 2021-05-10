using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=1,FirstName="Faruk",LastName="Bozlak",Age=22};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer1);
            Console.ReadLine();

        }    
    }
    [ToTable("Customers")]
    class Customer
    {
        
        public int Id { get; set; }
        //[RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, intead use AddNew Methot")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!",customer.Id,customer.FirstName,
                customer.LastName,customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!", customer.Id, customer.FirstName,
                customer.LastName, customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    class RequiredPropertyAttribute:Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


}
