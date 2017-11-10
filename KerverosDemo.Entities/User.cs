namespace KerverosDemo.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public int UserCode { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string MobileEmail { get; set; }

        public virtual Customer Customer { get; set; }

        public User(int id, string customerCode, int userCode, string name, string phone, string mobilePhone, string email, string mobileEmail)
        {
            Id = id;
            CustomerCode = customerCode;
            UserCode = userCode;
            Name = name;
            Phone = phone;
            MobilePhone = mobilePhone;
            Email = email;
            MobileEmail = mobileEmail;
        }

        public User()
        {
               
        }
    }
}
