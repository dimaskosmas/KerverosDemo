using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(16)]
        public string CustomerCode { get; set; }
        public int UserCode { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(20)]
        public string MobilePhone { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string MobileEmail { get; set; }

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
