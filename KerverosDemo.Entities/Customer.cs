
namespace KerverosDemo.Entities
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(string name, string customerCode, string address)
        {
            Name = name;
            CustomerCode = customerCode;
            Address = address;
        }

        public Customer()
        {

        }
    }
}
